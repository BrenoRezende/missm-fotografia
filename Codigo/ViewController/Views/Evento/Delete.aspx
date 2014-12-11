<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.EventoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Remover Evento
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Remover Evento</h2>
<h3>Tem certeza que deseja remover esse Evento?</h3>
<fieldset>
    <legend>Dados do Evento</legend>

    <div class="display-label">Nome</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nome) %>
    </div>
    <p></p>
    <div class="display-label">Data</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Data) %>
    </div>
    <p></p>
    <div class="display-label">Tipo do Evento</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NomeTipoEvento) %>
    </div>
    <p></p>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Remover" /> |
        <%: Html.ActionLink("Voltar", "Index") %>
    </p>
<% } %>

</asp:Content>
