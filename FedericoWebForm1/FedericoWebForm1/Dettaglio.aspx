<%@ Page Title="Dettaglio elemento ricercato" 
    Language="C#" 
    MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" 
    CodeBehind="Dettaglio.aspx.cs" 
    Inherits="FedericoWebForm1.Dettaglio" %>

<%@ Register TagPrefix="MyUC" TagName="Dettaglio" Src="~/Control/DettaglioUC.ascx" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Dettagli del prodotto ricercato</h3>

    
     <%if (prodotto.Id != 0){ %>
    <div class="row">
    <div class="col-sm-4"> <b>ID</b> </div>
    <div class="col-sm-4"> <b>Descrizione</b> </div>
    <div class="col-sm-4"> <b>Quantità da richiedere</b> </div>
    </div>

    <MyUC:Dettaglio ID="dettaglio" runat="server" />

    <div class="row">
    <div class="col-sm-4"> <%= prodotto.Id %> </div>
    <div class="col-sm-4"> <%= prodotto.Descrizione %></div>
    <div class="col-sm-4"> <asp:TextBox ID="QuantitaRichiesta" runat="server"></asp:TextBox> 
    <asp:RequiredFieldValidator
            ID="ReqFieldValCodice"
            ControlToValidate="QuantitaRichiesta"
            Display="Static"
            CssClass="text-danger"
            ErrorMessage=" Quantita Obbligatoria"
            runat="server" />
        <asp:RangeValidator
            ID="RangeValCodice"
            runat="server"
            ControlToValidate="QuantitaRichiesta"
            Display="Static"
            ErrorMessage=" Out of Range(La richiesta deve andare da 1 a 200) e deve essere un valore numerico"
            CssClass="text-danger"
            Type="Integer"
            MinimumValue="1"
            MaximumValue="200" />

    </div>    
    </div> 
        <% } %>

    <asp:Button OnClick="Conferma_Click"  runat="server"  text="Richiedi Ordine"/>
    <asp:Button PostBackUrl="~/RicercaPezzo.aspx" runat="server"  text="Annulla"/>
    
    




</asp:Content>
