<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master"Inherits="System.Web.Mvc.ViewPage<Model.Models.PedidoModel>" %>
<%@ Import Namespace="ClienteWeb.Helpers"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Create</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/DropDownCascades.js") %>" type="text/javascript"></script>
<script type="text/javascript" src="../../Scripts/jquery.simple-dtpicker.js"></script>
<script src="../../Scripts/CustomValidation.js" type="text/javascript"></script>

<script type="text/javascript">
    var actionUrl = '<%= Url.Action("AdicionarItem", "Venda", new { id = "idProduto" } ) %>';
    </script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>VendaModel</legend>
        <input id="AddItem" type="button" value="Inserir" class="button dark" onclick="parent.href='
        <%: Url.Action("AdicionarItem", "Venda", new { id = "idProduto" }) %>'" />

        <div class="editor-label">
            <%: Html.Label("Produto") %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("Produto", ViewBag.Produtos as SelectList, new { id = "Produto" })%>
        </div>

        
    <table id='tabelaItems'>
        <tr>
            <th>
                Nome
            </th>
            <th>
                Quantidade
            </th>
            <th>
                Valor
            </th>
            <th>
                
            </th>
        </tr>
    </table>
        <p>
            <input type="submit" value="Create" class="button dark" />
            <input type="button" value="Voltar" class="button dark" onclick="location.href='<%: Url.Action("ListarEmpresas", "Cliente") %>'" />
        </p>
    </fieldset>
<% } %>


</asp:Content>
