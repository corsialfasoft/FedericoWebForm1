using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FedericoWebForm1;

namespace FedericoWebForm1 {
	public partial class Carrello : Page {
		public string Message{get; set;}
        public List<Prodotto> prodotti{get; set;}
		
		protected void Page_Load(object sender,EventArgs e) {
		 prodotti = (List<Prodotto>)Session["listaRichieste"] ?? null;
	    

		}
		
		protected void Richiesta_Click(object sender, EventArgs e) {
			
            DataAccessObject Richiesta = new DataAccessObject();
			prodotti = Session["listaRichieste"] as List<Prodotto>;
			int x = Richiesta.RichiestaOrdine();
        }

		protected void Compra_Click(object sender,EventArgs e)
		{
			DataAccessObject DAO = new DataAccessObject();
			int Request = DAO.RichiestaOrdine();
			prodotti = Session["carrello"] as List<Prodotto>;
			foreach (Prodotto element in prodotti) {
				DAO.Compra(Request,element);
			}
			Session["carrello"]=new List<Prodotto>();
			prodotti=new List<Prodotto>();
			
				var url=String.Format($"~/RicercaPezzo.aspx");
				Response.Redirect(url);
		}
	}
}