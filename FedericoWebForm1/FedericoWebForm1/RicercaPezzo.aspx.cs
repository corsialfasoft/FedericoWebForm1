using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FedericoWebForm1;

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
			    Response.Redirect($"~/Dettaglio.aspx?codice={Cod.Text}");
				//prodotto = Prova.RicercaperID(codice);				
			}  else if (!String.IsNullOrEmpty(Desc.Text)) {
				string descrizione = Desc.Text;
                prodotti = Prova.RicercaperDescrizione(descrizione);
				 
				
				foreach (Prodotto prodotto in prodotti) {
				  TableRow tr = new TableRow();
                    TableCell tdCodice = new TableCell();
                    tdCodice.Controls.Add(new Label() { Text = prodotto.Id.ToString(),CssClass="col-xs-2" });
                    tr.Cells.Add(tdCodice);
                    TableCell tdDescrizione = new TableCell();
                    tdDescrizione.Controls.Add(new Label() { Text = prodotto.Descrizione ,CssClass="col-xs-6" });
                    tr.Cells.Add(tdDescrizione);
                    TableCell tdGiacenza = new TableCell();
                    tdGiacenza.Controls.Add(new Label() { Text = prodotto.Quantita.ToString(),CssClass="col-xs-2" });
                    tr.Cells.Add(tdGiacenza);
                    TableCell tdButton = new TableCell();
                    tdButton.Controls.Add(new Button() { Text = "Dettagli", PostBackUrl = $"Dettaglio?codice={prodotto.Id}" ,CssClass="col-xs-3"});
                    tr.Cells.Add(tdButton);
                    Table1.Rows.Add(tr);
			    }		
			}  
			

		}
	}
}
