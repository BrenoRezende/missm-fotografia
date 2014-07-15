<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.EventoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>EventoModel</legend>

    <div class="display-label">IdEvento</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdEvento) %>
    </div>

    <div class="display-label">Nome</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nome) %>
    </div>

    <div class="display-label">Data</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Data) %>
    </div>

    <div class="display-label">IdTipoEvento</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdTipoEvento) %>
    </div>

    <div class="display-label">NomeTipoEvento</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NomeTipoEvento) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Delete" /> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>
<% } %>

</asp:Content>
