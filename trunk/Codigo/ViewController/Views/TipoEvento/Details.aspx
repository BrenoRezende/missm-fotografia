<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.TipoEventoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
Tipo de Evento
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>Detalhes do Tipo de Evento</h2>
<fieldset>
    <legend>Dados do Tipo de Evento</legend>

    <div class="display-label">Código</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdTipoEvento) %>
    </div>

    <div class="display-label">Nome</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nome) %>
    </div>

    <div class="display-label">TotalConvidados</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TotalConvidados) %>
    </div>

    <div class="display-label">Valor</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Valor) %>
    </div>
</fieldset>
<p>
    <%: Html.ActionLink("Editar", "Edit", new { id=Model.IdTipoEvento }) %> |
    <%: Html.ActionLink("Voltar", "Index") %>
</p>

</asp:Content>
