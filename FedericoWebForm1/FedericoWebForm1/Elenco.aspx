<%@ Page Title="Ricerca per descrizione" 
    Language="C#" 
    MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" 
    CodeBehind="Elenco.aspx.cs" 
    Inherits="FedericoWebForm1.Elenco" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3>Rappresentazione elenco prodotti per descrizione</h3>

    <%if(prodotti != null){
    foreach(var prodotto in prodotti) { %>
    <div class="row">
    <div class="col-sm-4"> <b>ID</b> </div>
    <div class="col-sm-4"> <b>Descrizione</b> </div>
    <div class="col-sm-4"> <b>Dettagli</b></div>
    </div>
        
    <div class="row">
    <div class="col-sm-4"> <%= prodotto.Id %> </div>
    <div class="col-sm-4"> <%= prodotto.Descrizione %></div>
    <div class="col-sm-4"> <asp:Button PostBackUrl="~/Dettaglio.aspx" runat="server" text="Dettaglio"/> </div>
    </div>
    <% } } %>    
  

</asp:Content>
