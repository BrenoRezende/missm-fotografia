<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.ProdutoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>ProdutoModel</legend>

    <div class="display-label">IdProduto</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdProduto) %>
    </div>

    <div class="display-label">NomeProduto</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NomeProduto) %>
    </div>

    <div class="display-label">NumeroDePaginas</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NumeroDePaginas) %>
    </div>

    <div class="display-label">Formato</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Formato) %>
    </div>

    <div class="display-label">NumeroDeImagens</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NumeroDeImagens) %>
    </div>

    <div class="display-label">ValorDoProduto</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ValorDoProduto) %>
    </div>

    <div class="display-label">ValorImagemAdicional</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ValorImagemAdicional) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Delete" /> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>
<% } %>

</asp:Content>
