using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace FedericoWebForm1 {

	public class Prodotto {
		public int Id{ get;set;}
		public string Descrizione{ get;set;}
		public int Quantita{ get;set;}	
		public int QuantitaRichiesta { get; set;}
       }
	
		
	   
	   public class DataAccessObject {

	   public string GetConnection(){ 
            SqlConnectionStringBuilder reader = new SqlConnectionStringBuilder();
            reader.DataSource=@"(localdb)\MSSQLLocalDB";
            reader.InitialCatalog = "RICHIESTE";
            return reader.ToString();
        }

		public Prodotto RicercaperID(int Cod) {
			Prodotto product = new Prodotto();		
			SqlConnection connection = new SqlConnection(GetConnection());
			connection.Open();
			SqlCommand command = new SqlCommand("RicercaID",connection);
			command.CommandType = System.Data.CommandType.StoredProcedure;
			command.Parameters.Add("@Id",SqlDbType.Int).Value = Cod;
			SqlDataReader reader = command.ExecuteReader();
			while(reader.Read()){
				product.Id = (int)reader.GetInt32(0);
				product.Descrizione = (string)reader.GetValue(1);
				product.Quantita = (int)reader.GetInt32(2);	
				
			}
			reader.Close();
			connection.Close();
			
			return product;
		}

		public int RichiestaOrdine() {
		int Request=0;
		Prodotto product = new Prodotto();
		List<Prodotto> Listona = new List<Prodotto>();
		SqlConnection connection = new SqlConnection(GetConnection());
		connection.Open();
		SqlCommand command = new SqlCommand("Request",connection);
		command.CommandType = System.Data.CommandType.StoredProcedure;
		command.Parameters.Add("@data",SqlDbType.DateTime).Value = DateTime.Now.ToString("dd-MM-yyyy") ;
		SqlDataReader reader = command.ExecuteReader();
		
				while(reader.Read()) {
					Request = (int)reader.GetDecimal(0);
				}
				reader.Close();
				command.Dispose();
				return Request;
		}

		public void Compra(int Request,Prodotto prodotto)
		{
			SqlConnection connection = new SqlConnection(GetConnection());
			
				connection.Open();
				SqlCommand command = new SqlCommand("AddOrdine",connection);
				command.CommandType=System.Data.CommandType.StoredProcedure;
				command.Parameters.Add("@Richiesta",System.Data.SqlDbType.Int).Value=Request;
				command.Parameters.Add("@Prodotti",System.Data.SqlDbType.Int).Value=prodotto.Id;
				command.Parameters.Add("@Quantita",System.Data.SqlDbType.Int).Value=prodotto.Quantita;
				command.ExecuteNonQuery();
				command.Dispose();				
				connection.Close();
				
		}


		public List<Prodotto> RicercaperDescrizione(string Desc) {
		Prodotto product = new Prodotto();
		SqlConnection connection = new SqlConnection(GetConnection());
		connection.Open();
		List<Prodotto> Listona = new List<Prodotto>();
		SqlCommand command = new SqlCommand("RicercaDESC",connection);
		command.CommandType = System.Data.CommandType.StoredProcedure;
		command.Parameters.Add("@Desc",SqlDbType.NVarChar).Value = Desc;
		SqlDataReader reader = command.ExecuteReader();
		while(reader.Read()){
				
				product.Id = (int)reader.GetInt32(0);
				product.Descrizione = (string)reader.GetValue(1);
				product.Quantita = (int)reader.GetInt32(2);	
				Listona.Add(product);
		}
		reader.Close();
		connection.Close();
		return Listona;

		}
	
	}
}