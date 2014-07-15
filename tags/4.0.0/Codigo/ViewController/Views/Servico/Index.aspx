<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Model.Models.ServicoModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Lista de Serviços
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>Lista de Serviços </h2>
<table>
    <tr>
        <th>
            Código
        </th>
        <th>
            Tipo de Serviço
        </th>
        <th>
            Parceiro
        </th>
        <th>
            Telefone do Parceiro
        </th>
        <th>
            Valor do Serviço
        </th>
        <th>
            Valor Cobrado ao Cliente
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.IdServico) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.TipoServico) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Parceiro) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.TelefoneParceiro) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.ValorServico) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.ValorCobradoAoCliente) %>
        </td>
        
        <td>
            <%: Html.ActionLink("Editar", "Edit", new { id=item.IdServico }) %> |
            <%: Html.ActionLink("Detalhes", "Details", new { id=item.IdServico }) %> |
            <%: Html.ActionLink("Remover", "Delete", new { id=item.IdServico}) %>
        </td>
    </tr>
<% } %>

</table>
<p>
    <%: Html.ActionLink("Cadastrar Novo Serviço", "Create") %>
</p>

</asp:Content>
