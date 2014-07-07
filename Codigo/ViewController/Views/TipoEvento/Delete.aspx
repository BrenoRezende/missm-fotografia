<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.TipoEventoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


<h3>Tem certeza que deseja remover esse tipo de evento?</h3>
<fieldset>
    <legend>Remover Tipo de Evento</legend>

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
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Remover" /> |
        <%: Html.ActionLink("Voltar", "Index") %>
    </p>
<% } %>

</asp:Content>
