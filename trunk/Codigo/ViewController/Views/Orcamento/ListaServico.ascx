<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<List<Model.Models.ServicoModel>>" %>

<div class="box-content">
    <table class="table table-bordered table-striped">
        <tr>
            <th>
               Nome do Servico 
            </th>
            <th>
                Nome do Parceiro
            </th>
            <th>
                Telefone do Parceiro
            </th>
            <th>
               Valor Cobrado ao Cliente
            </th>
            <th>
                Valor do Servico
            </th>
            <th>
                Remover
            </th>
        </tr>
        <% foreach (var item in Model)
           { %>
        <tr>
            <td>
                <%: Html.DisplayFor(modelItem => item.NomeServico) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.NomeParceiro) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.TelefoneParceiro) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.ValorCobradoAoCliente) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.ValorServico) %>
            </td>
            <td>
                <%: Html.ActionLink("Remover", "RemoverServico", new { id = item.IdServico })%>
            </td>
        </tr>
        <% } %>
    </table>
</div>
