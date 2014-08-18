<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Model.Models.PessoaModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Lista de Clientes
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Lista de Clientes</h2>

<table>
    <tr>
        <th>
            Código
        </th>
        <th>
            Nome
        </th>
        <th>
            CPF
        </th>
        <th>
            E-Mail
        </th>
        <th>
            Orçamentos
        </th>
        <th>
            Contratos
        </th>
        <th>
            Pagamentos
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.IdPessoa) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Nome) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Cpf) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Email) %>
        </td>
        <td>
            <%: Html.ActionLink("Orçamentos", "VisualizarOrcamentos", "Orcamento", new { id = item.IdPessoa }, null)%>
        </td>
        <td>
            
        </td>
        <td>
            
        </td>
        <td>
            <%: Html.ActionLink("Editar", "Edit", new { id=item.IdPessoa }) %> |
            <%: Html.ActionLink("Detalhes", "Details", new { id=item.IdPessoa }) %> |
            <%: Html.ActionLink("Remover", "Delete", new { id=item.IdPessoa}) %>
        </td>
    </tr>
<% } %>
</table>

<p>
    <%: Html.ActionLink("Cadastrar Novo Cliente", "Create") %>
</p>

</asp:Content>
