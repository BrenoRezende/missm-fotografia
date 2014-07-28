﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.TipoEventoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
Editar Tipo de Evento
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<h2>Editar Tipo de Evento</h2>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Dados do Tipo de Evento</legend>

        <div class="editor-field">
            <%: Html.HiddenFor(model => model.IdTipoEvento) %>
            <%: Html.ValidationMessageFor(model => model.IdTipoEvento) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Nome) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Nome) %>
            <%: Html.ValidationMessageFor(model => model.Nome) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.TotalConvidados) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.TotalConvidados) %>
            <%: Html.ValidationMessageFor(model => model.TotalConvidados) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Valor) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Valor) %>
            <%: Html.ValidationMessageFor(model => model.Valor) %>
        </div>

        <p>
            <input type="submit" value="Salvar Alterações" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Voltar", "Index") %>
</div>

</asp:Content>