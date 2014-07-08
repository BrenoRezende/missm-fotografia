<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Model.Models.ProdutoModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<p>
    <%: Html.ActionLink("Cadastrar Novo Produto", "Create") %>
</p>
<table>
    <tr>
        <th>
            Código
        </th>
        <th>
            Nome
        </th>
        <th>
            Numero de Páginas
        </th>
        <th>
            Formato
        </th>
        <th>
            Numero de Imagens
        </th>
        <th>
            Valor do Produto
        </th>
        <th>
            Valor por Imagem Adicional
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.IdProduto) %>
        </td>
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
        <td>
            <%: Html.DisplayFor(modelItem => item.ValorImagemAdicional) %>
        </td>
        <td>
            <%: Html.ActionLink("Editar", "Edit", new { id=item.IdProduto }) %> |
            <%: Html.ActionLink("Detalhes", "Details", new { id=item.IdProduto }) %> |
            <%: Html.ActionLink("Remover", "Delete", new { id=item.IdProduto}) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
