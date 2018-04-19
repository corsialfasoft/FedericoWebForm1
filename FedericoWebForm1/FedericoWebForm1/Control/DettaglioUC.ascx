<%@ Control Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="DettaglioUC.ascx.cs" 
    Inherits="FedericoWebForm1.Control.DettaglioUC" %>

<div class="col-sm-4">
    <asp:Label runat="server">Codice Prodotto </asp:Label>
</div>
<div class="col-sm-8">
     <%=prodotto.Id %>
</div>

<div class="col-sm-4">
    <asp:Label runat="server">Descrizione Prodotto </asp:Label>
</div>
<div class="col-sm-8">
    <%=prodotto.Descrizione %>
</div>

<div class="col-sm-4">
    <asp:Label runat="server">Giacenza </asp:Label>
</div>
<div class="col-sm-8">
   <%=prodotto.Quantita %> 
</div>