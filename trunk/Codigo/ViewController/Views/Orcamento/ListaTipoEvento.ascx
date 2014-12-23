<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<List<Model.Models.TipoEventoModel>>" %>

<div class="box-content">
    <table class="table table-bordered table-striped">
        <tr>
            <th>
               Nome do Tipo de Evento
            </th>
            <th>
                Total de Convidados
            </th>
            <th>
                Valor
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
                <%: Html.DisplayFor(modelItem => item.TotalConvidados) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.Valor) %>
            </td>
            <td>
                <%: Html.ActionLink("Remover", "RemoverTipoEvento", new { id = item.IdTipoEvento })%>
            </td>
        </tr>
        <% } %>
    </table>
</div>

