using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace FedericoWebForm1 {
	public partial class RicercaPezzo : Page {
		protected void Page_Load(object sender,EventArgs e) {
		 prodotto = new Prodotto();
		}
		DataAccessObject Prova = new DataAccessObject();
		public  Prodotto prodotto {get; set;}
		public List<Prodotto> prodotti {get; set;}

		

		protected void Ricerca_Click(object sender,EventArgs e) {
		  
			
			if(Cod.Text !="" && int.TryParse(Cod.Text ,out int codice)) {
				prodotto = Prova.RicercaperID(codice);				
			}  else if (!String.IsNullOrEmpty(Desc.Text)) {
				string descrizione = Desc.Text;
                prodotti = Prova.RicercaperDescrizione(descrizione);
            }		
			  
			

		}
	}
}