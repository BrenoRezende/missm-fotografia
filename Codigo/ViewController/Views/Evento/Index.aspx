<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Model.Models.EventoModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
Lista de Eventos
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Lista de Eventos </h2>

<table>
    <tr>
        <th>
            Nome
        </th>
        <th>
            Data
        </th>
        <th>
            Tipo do Evento
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.Nome) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Data) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.NomeTipoEvento) %>
        </td>
        <td>
            <%: Html.ActionLink("Editar", "Edit", new { id = item.IdEvento })%> |
            <%: Html.ActionLink("Detalhes", "Details", new { id=item.IdEvento }) %> |
            <%: Html.ActionLink("Remover", "Delete", new { id = item.IdEvento })%>
        </td>
    </tr>
<% } %>

</table>
<p>
    <%: Html.ActionLink("Cadastrar Novo Evento", "Create") %>
</p>
</asp:Content>
