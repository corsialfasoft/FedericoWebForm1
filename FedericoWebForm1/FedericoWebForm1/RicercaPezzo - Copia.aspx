<%@ Page Title="Ricerca" 
    Language="C#" 
    MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" 
    CodeBehind="RicercaPezzo.aspx.cs" 
    Inherits="FedericoWebForm1.RicercaPezzo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Pagina di ricerca</h3>

    

    <b>CODICE</b> <asp:TextBox ID="Cod" runat="server"></asp:TextBox>
    <b>DESCRIZIONE</b> <asp:TextBox ID="Desc" runat="server"></asp:TextBox>
        <asp:Button OnClick="Ricerca_Click" runat="server" text="Ricerca"/>
    
    <div class="container">
    <%if (prodotto.Id != 0){ %>
    <div class="row">
    <div class="col-sm-4"> <%= prodotto.Id %> </div>
    <div class="col-sm-4"> <%= prodotto.Descrizione %></div>
    </div> 
        <% } %>

    <%if(prodotti != null){ 

    foreach(var prodotto in prodotti) { %>
    <div class="row">
    <div class="col-sm-4"> <%= prodotto.Id %> </div>
    <div class="col-sm-4"> <%= prodotto.Descrizione %></div>
    </div>
    <% } } %>       
    </div>

</asp:Content>
