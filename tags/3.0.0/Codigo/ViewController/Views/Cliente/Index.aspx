﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Model.Models.ClienteModel>>" %>

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
            <%: Html.DisplayFor(modelItem => item.IdCliente) %>
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
            
        </td>
        <td>
            <%: Html.ActionLink("Editar", "Edit", new { id=item.IdCliente }) %> |
            <%: Html.ActionLink("Detalhes", "Details", new { id=item.IdCliente }) %> |
            <%: Html.ActionLink("Remover", "Delete", new { id=item.IdCliente}) %>
        </td>
    </tr>
<% } %>
</table>

<p>
    <%: Html.ActionLink("Cadastrar Novo Cliente", "Create") %>
</p>

</asp:Content>