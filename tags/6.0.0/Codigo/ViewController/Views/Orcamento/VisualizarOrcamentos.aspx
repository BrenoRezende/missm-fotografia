<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Model.Models.PedidoModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    VisualizarOrcamentos
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<fieldset>
    <legend>Orçamentos</legend>
    <br />
    <table>
     <tr>
        <th>
            Nome do Orçamento
        </th>
        <th>
            Data de Criacao
        </th>
        <th>
            Data de Emissão
        </th>
        <th>
            Nome do Cliente
        </th>
        <th>
            Valor
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.NomePedido) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.DataCriacao) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.DataEmissao) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.NomePessoa) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Valor) %>
        </td>
        <td>
            <%: Html.ActionLink("Detalhes", "Details", "Pedido", new { id = item.IdPedido }, null)%> |
            <%: Html.ActionLink("Remover", "Delete", "Pedido", new { id = item.IdPedido }, null)%>
        </td>
    </tr>
<% } %>

</table>
</fieldset>

<div>
   <a href="<%: Url.Action("Index", "Pessoa") %>">
    <button>Voltar</button>
   </a>
</div>
</asp:Content>
