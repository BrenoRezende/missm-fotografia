<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.TipoEventoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Cadastrar Tipo de Evento</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Nome) %>
        </div>
        <p></p>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Nome) %>
            <%: Html.ValidationMessageFor(model => model.Nome) %>
        </div>
        <p></p>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.TotalConvidados) %>
        </div>
        <p></p>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.TotalConvidados) %>
            <%: Html.ValidationMessageFor(model => model.TotalConvidados) %>
        </div>
        <p></p>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Valor) %>
        </div>
        <p></p>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Valor) %>
            <%: Html.ValidationMessageFor(model => model.Valor) %>
        </div>
        <p></p>
        <p>
            <input type="submit" value="Cadastrar" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Voltar", "Index") %>
</div>

</asp:Content>
