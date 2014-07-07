<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.ServicoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Edit</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Editar Serviço</legend>



        <div class="editor-label">
            <%: Html.LabelFor(model => model.TipoServico) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.TipoServico) %>
            <%: Html.ValidationMessageFor(model => model.TipoServico) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Parceiro) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Parceiro) %>
            <%: Html.ValidationMessageFor(model => model.Parceiro) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.TelefoneParceiro) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.TelefoneParceiro) %>
            <%: Html.ValidationMessageFor(model => model.TelefoneParceiro) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ValorServico) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.ValorServico) %>
            <%: Html.ValidationMessageFor(model => model.ValorServico) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ValorCobradoAoCliente) %>
        </div>
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
