<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Model.Models.FuncionarioModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Lista de Funcionários
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Lista de Funcionários</h2>

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
            Telefone
        </th>
        <th>
            Pagamentos
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.IdFuncionario) %>
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
            
        </td>
        <td>
            
        </td>
        <td>
            <%: Html.ActionLink("Editar", "Edit", new { id=item.IdFuncionario }) %> |
            <%: Html.ActionLink("Detalhes", "Details", new { id=item.IdFuncionario }) %> |
            <%: Html.ActionLink("Remover", "Delete", new { id=item.IdFuncionario}) %>
        </td>
    </tr>
<% } %>
</table>

<p>
    <%: Html.ActionLink("Cadastrar Novo Cliente", "Create") %>
</p>

</asp:Content>
