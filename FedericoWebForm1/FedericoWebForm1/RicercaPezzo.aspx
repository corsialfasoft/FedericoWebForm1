<%@ Page Title="Ricerca Prodotti" 
    Language="C#" 
    MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" 
    CodeBehind="RicercaPezzo.aspx.cs" 
    Inherits="FedericoWebForm1.RicercaPezzo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3>Pagina di ricerca dei prodotti</h3>

    

    <b>CODICE</b> <asp:TextBox ID="Cod" runat="server"></asp:TextBox>
    <b>DESCRIZIONE</b> <asp:TextBox ID="Desc" runat="server"></asp:TextBox>
        <asp:Button OnClick="Ricerca_Click" runat="server" text="Ricerca"/>
        
    <div class="bordo" style="border-bottom: 2px solid black; padding:5px;"></div>
    
    <div class="container">
        
       <div class="table" style="margin-top:25px">
        <asp:Table ID="Table1" runat="server" width="100%"
            CellPadding="20"
            GridLines="None"
            HorizontalAlign="Center">
        </asp:Table>
     </div>         
    </div>

</asp:Content>
