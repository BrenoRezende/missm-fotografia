﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.EventoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Cadastrar Evento
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<h2>Cadastrar Evento</h2>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Dados do Evento</legend>

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
            <%: Html.LabelFor(model => model.Data) %>
        </div>
        <p></p>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Data)%>
            <%: Html.ValidationMessageFor(model => model.Data) %>
        </div>
        <p></p>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.IdTipoEvento) %>
        </div>
        <p></p>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.IdTipoEvento, ViewBag.IdTipoEvento as SelectList) %>
            <%: Html.ValidationMessageFor(model => model.IdTipoEvento) %>
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