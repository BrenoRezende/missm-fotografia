<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.EventoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
Detalhes do Evento
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Detalhes do Evento</h2>

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
<p>
    <%: Html.ActionLink("Editar", "Edit", new { id=Model.IdEvento}) %> |
    <%: Html.ActionLink("voltar", "Index") %>
</p>

</asp:Content>
