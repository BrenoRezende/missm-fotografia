<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<List<Model.Models.ProdutoModel>>" %>

<div class="box-content">
    <table class="table table-bordered table-striped">
        <tr>
            <th>
               Nome do Produto
            </th>
            <th>
                Formato
            </th>
            <th>
                Número de Imagens
            </th>
            <th>
               Número de Páginas
            </th>
            <th>
                Valor do Produto
            </th>
            <th>
                Remover
            </th>
        </tr>
        <% foreach (var item in Model)
           { %>
        <tr>
            <td>
                <%: Html.DisplayFor(modelItem => item.Nome) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.Formato) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.NumeroDeImagens) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.NumeroDePaginas) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.ValorDoProduto) %>
            </td>
        </tr>
        <% } %>
    </table>
</div>


