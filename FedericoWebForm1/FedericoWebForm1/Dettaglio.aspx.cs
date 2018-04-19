using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FedericoWebForm1.Control; 
	
namespace FedericoWebForm1 {

	public partial class Dettaglio : Page {

	
				
		protected void Page_Load(object sender,EventArgs e) {
		 DataAccessObject Nuovo = new DataAccessObject();
		 prodotto = int.TryParse(Request["Codice"], out int code) ? Nuovo.RicercaperID(code) : null;
            if (prodotto == null) {
                Response.Redirect("~/RicercaPezzo.aspx?Message='prodotto non trovato'");
            }
				dettaglio.prodotto = prodotto;
		}
		DataAccessObject Prova = new DataAccessObject();
		public  Prodotto prodotto {get; set;}
		public List<Prodotto> prodotti {get; set;}
		public string Message{get; set;}
		
		
		

		protected void Conferma_Click(object sender,EventArgs e) {
		 if (int.TryParse(QuantitaRichiesta.Text, out int quantitaRichiesta)) {
                List<Prodotto> prodotti = (List<Prodotto>)Session["listaRichieste"] ?? new List<Prodotto>();
                var query = from prod in prodotti
                    where prod.Id == prodotto.Id
                    select prod;
                if(query.FirstOrDefault()!=null){
                    query.FirstOrDefault().QuantitaRichiesta=  query.FirstOrDefault().QuantitaRichiesta +  quantitaRichiesta;
                }else{
                    prodotto.QuantitaRichiesta=quantitaRichiesta;
                    prodotti.Add(prodotto);
                }
                Session["listaRichieste"]=prodotti;
                Response.Redirect("~/RicercaPezzo.aspx?Message=Quantita aggiunta al carrello");
            } else {
               
            }

    }
			
		
		}
	}

