<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Agenda
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<fieldset>
        <legend>Agenda Pessoal</legend>
        <p>
        </p>
        <table>
            <tr>
                <th>
                    Nome
                </th>
                <th>
                    Descrição
                </th>
                <th>
                    Data
                </th>
                <th></th>
            </tr>
            <% foreach (var item in ViewBag.ListaAgenda)
               { %>
            <tr>
                <td>
                    <%: item.Nome %>
                </td>
                <td>
                    <%: item.Descricao %>
                </td>
                <td>
                    <%: item.Data%>
                </td>
                <td>
                     <%: Html.ActionLink("Editar", "Edit", new { id=item.IdAgenda }) %> |
                     <%: Html.ActionLink("Detalhes", "Details", new { id = item.IdAgenda })%> |
                     <%: Html.ActionLink("Remover", "Delete", new { id = item.IdAgenda })%>
                </td>
            </tr>
            <% } %>
        </table>
        <p>
            <%: Html.ActionLink("Cadastrar Nova Atividade", "Create") %>
        </p>
</fieldset>
    <p></p>
<fieldset>
    <legend>Agenda de Eventos</legend>
        <p>
        </p>
        <table>
            <tr>
                <th>
                    Nome
                </th>
                <th>
                    Tipo do Evento
                </th>
                <th>
                    Data
                </th>
            </tr>
            <% foreach (var item in ViewBag.ListaEvento)
               { %>
            <tr>
                <td>
                    <%: item.Nome %>
                </td>
                <td>
                    <%: item.NomeTipoEvento %>
                </td>
                <td>
                    <%: item.Data%>
                </td>
            </tr>
            <% } %>
        </table>
</fieldset>
</asp:Content>
