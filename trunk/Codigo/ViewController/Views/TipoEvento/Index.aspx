﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Model.Models.TipoEventoModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Tipo de Evento
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>Tipos de Evento</h2>

<table>
    <tr>
        <th>
            Código
        </th>
        <th>
            Nome
        </th>
        <th>
            Total de Convidados
        </th>
        <th>
            Valor
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.IdTipoEvento) %>
        </td>
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
            <%: Html.ActionLink("Editar", "Edit", new { id=item.IdTipoEvento }) %> |
            <%: Html.ActionLink("Detalhes", "Details", new { id=item.IdTipoEvento })%> |
            <%: Html.ActionLink("Remover", "Delete", new { id=item.IdTipoEvento })%>
        </td>
    </tr>
<% } %>
</table>
<p>
    <%: Html.ActionLink("Cadastrar Novo Tipo de Evento", "Create") %>
</p>
</asp:Content>