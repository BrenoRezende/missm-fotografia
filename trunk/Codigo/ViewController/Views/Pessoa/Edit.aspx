<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.PessoaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Editar Pessoa</legend>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.IdPessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.IdPessoa) %>
            <%: Html.ValidationMessageFor(model => model.IdPessoa) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.NomePessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.NomePessoa) %>
            <%: Html.ValidationMessageFor(model => model.NomePessoa) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.CpfPessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.CpfPessoa) %>
            <%: Html.ValidationMessageFor(model => model.CpfPessoa) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.SexoPessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.SexoPessoa) %>
            <%: Html.ValidationMessageFor(model => model.SexoPessoa) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.DataNascimentoPessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.DataNascimentoPessoa) %>
            <%: Html.ValidationMessageFor(model => model.DataNascimentoPessoa) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.TelefonePessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.TelefonePessoa) %>
            <%: Html.ValidationMessageFor(model => model.TelefonePessoa) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.EmailPessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.EmailPessoa) %>
            <%: Html.ValidationMessageFor(model => model.EmailPessoa) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.SenhaPessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.SenhaPessoa) %>
            <%: Html.ValidationMessageFor(model => model.SenhaPessoa) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.RuaPessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.RuaPessoa) %>
            <%: Html.ValidationMessageFor(model => model.RuaPessoa) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.NumeroPessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.NumeroPessoa) %>
            <%: Html.ValidationMessageFor(model => model.NumeroPessoa) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.BairroPessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.BairroPessoa) %>
            <%: Html.ValidationMessageFor(model => model.BairroPessoa) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.CidadePessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.CidadePessoa) %>
            <%: Html.ValidationMessageFor(model => model.CidadePessoa) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.EstadoPessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.EstadoPessoa) %>
            <%: Html.ValidationMessageFor(model => model.EstadoPessoa) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.TipoPessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.TipoPessoa) %>
            <%: Html.ValidationMessageFor(model => model.TipoPessoa) %>
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
