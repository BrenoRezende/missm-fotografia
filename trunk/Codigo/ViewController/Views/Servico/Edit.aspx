<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.ServicoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Editar Serviço
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Editar Serviço</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Dados do Serviço</legend>

        <div class="editor-field">
            <%: Html.HiddenFor(model => model.IdServico) %>
            <%: Html.ValidationMessageFor(model => model.IdServico) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.NomeServico)%>
        </div>
        <p></p>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.NomeServico)%>
            <%: Html.ValidationMessageFor(model => model.NomeServico)%>
        </div>
        <p></p>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.NomeParceiro)%>
        </div>
        <p></p>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.NomeParceiro)%>
            <%: Html.ValidationMessageFor(model => model.NomeParceiro)%>
        </div>
        <p></p>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.TelefoneParceiro) %>
        </div>
        <p></p>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.TelefoneParceiro) %>
            <%: Html.ValidationMessageFor(model => model.TelefoneParceiro) %>
        </div>
        <p></p>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.ValorServico) %>
        </div>
        <p></p>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.ValorServico) %>
            <%: Html.ValidationMessageFor(model => model.ValorServico) %>
        </div>
        <p></p>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.ValorCobradoAoCliente) %>
        </div>
        <p></p>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.ValorCobradoAoCliente) %>
            <%: Html.ValidationMessageFor(model => model.ValorCobradoAoCliente) %>
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
