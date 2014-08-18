<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Model.Models.ProdutoModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


<table>
    <tr>
        <th>
            Nome
        </th>
        <th>
            NumeroDePaginas
        </th>
        <th>
            Formato
        </th>
        <th>
            NumeroDeImagens
        </th>
        <th>
            ValorDoProduto
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.Nome) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.NumeroDePaginas) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Formato) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.NumeroDeImagens) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.ValorDoProduto) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
