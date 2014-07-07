<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Model.Models.PessoaModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<p>
    <%: Html.ActionLink("Cadastrar Nova Pessoa", "Create") %>
</p>
<table>
    <tr>
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
            <%: Html.DisplayFor(modelItem => item.NomePessoa) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.CpfPessoa) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.EmailPessoa) %>
        </td>        
        <td>
            <%: Html.ActionLink("Editar", "Edit", new { id=item.IdPessoa }) %> |
            <%: Html.ActionLink("Detalhes", "Details", new { id=item.IdPessoa }) %> |
            <%: Html.ActionLink("Remover", "Delete", new { id=item.IdPessoa}) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
