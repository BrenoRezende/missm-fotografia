<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Model.Models.EventoModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<p>
    <%: Html.ActionLink("Create New", "Create") %>
</p>
<table>
    <tr>
        <th>
            Nome
        </th>
        <th>
            Data
        </th>
        <th>
            NomeTipoEvento
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
            <%: Html.ActionLink("Edit", "Edit", new { id = item.IdEvento })%> |
            <%: Html.ActionLink("Details", "Details", new { id=item.IdEvento }) %> |
            <%: Html.ActionLink("Delete", "Delete", new { id = item.IdEvento })%>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
