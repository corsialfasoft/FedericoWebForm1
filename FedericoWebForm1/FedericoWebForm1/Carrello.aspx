<%@ Page Title="Conferma carrello" 
    Language="C#" 
    MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" 
    CodeBehind="Carrello.aspx.cs" 
    Inherits="FedericoWebForm1.Carrello" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Dettagli Carrello</h3>
        

        <div class="row">
    <div class="col-sm-4"> <b>ID</b> </div>
    <div class="col-sm-4"> <b>Descrizione</b> </div>
    <div class="col-sm-4"> <b>Quantità Richiesta</b> </div>
    </div>
    
      <%if(prodotti!=null){
      foreach(var prodotto in prodotti){ %>        
        <div class="col-sm-4">
            <%=prodotto.Id%>
        </div>
        <div class="col-sm-4">
            <%=prodotto.Descrizione%>
        </div>
        <div class="col-sm-4">
            <%=prodotto.QuantitaRichiesta%>
        </div>
    <%}} %>
    <asp:Button runat="server" OnClick="Compra_Click" Text="Spedisci richiesta" /> 
    




</asp:Content>
