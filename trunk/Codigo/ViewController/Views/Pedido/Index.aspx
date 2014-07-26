
<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master"Inherits="System.Web.Mvc.ViewPage<Model.Models.PedidoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Criar Orçamento
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1" runat="server">
<h2>Criar Orçamento</h2>


<% using (Html.BeginForm()) { %>
    
    <fieldset>
        <legend>Lista de Produtos</legend>
        
        <div class="editor-label">
            <%: Html.Label("Nome do Produto           Formato         Número de úmero de Imagens          Valor do Produto")%>            
        </div>
        <div class="editor-label">
            
            
            <%: Html.ListBox("Produtos", ViewBag.Produtos as SelectList)%>            
            
            <asp:GridView ID="GridView1" runat="server" 
                onselectedindexchanged="GridView1_SelectedIndexChanged">
            </asp:GridView>
            
        </div>


    </fieldset>
<% } %>


    </form>


</asp:Content>
