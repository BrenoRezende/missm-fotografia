<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.ProdutoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
 Editar Produto
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<h2>Editar Produto</h2>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Dados do Produto</legend>
      
        <div class="editor-field">
            <%: Html.HiddenFor(model => model.IdProduto) %>
            <%: Html.ValidationMessageFor(model => model.IdProduto) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Nome) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Nome) %>
            <%: Html.ValidationMessageFor(model => model.Nome) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.NumeroDePaginas) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.NumeroDePaginas) %>
            <%: Html.ValidationMessageFor(model => model.NumeroDePaginas) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Formato) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Formato) %>
            <%: Html.ValidationMessageFor(model => model.Formato) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.NumeroDeImagens) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.NumeroDeImagens) %>
            <%: Html.ValidationMessageFor(model => model.NumeroDeImagens) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ValorDoProduto) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.ValorDoProduto) %>
            <%: Html.ValidationMessageFor(model => model.ValorDoProduto) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ValorImagemAdicional) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.ValorImagemAdicional) %>
            <%: Html.ValidationMessageFor(model => model.ValorImagemAdicional) %>
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
