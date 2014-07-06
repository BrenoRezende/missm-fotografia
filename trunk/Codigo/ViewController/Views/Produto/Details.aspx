<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.ProdutoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Details</h2>

<fieldset>
    <legend>Produto</legend>

    <div class="display-label"><b>Código</b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdProduto) %>
    </div>

    <div class="display-label"><b>Nome</b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nome) %>
    </div>

    <div class="display-label"><b>Numero de Páginas</b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NumeroDePaginas) %>
    </div>

    <div class="display-label"><b>Formato</b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Formato) %>
    </div>

    <div class="display-label"><b>Numero de Imagens</b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NumeroDeImagens) %>
    </div>

    <div class="display-label"><b>Valor do Produto</b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ValorDoProduto) %>
    </div>

    <div class="display-label"><b>Valor por Imagem Adicional</b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ValorImagemAdicional) %>
    </div>
</fieldset>
<p>
    <%: Html.ActionLink("Edit", "Edit", new { id=Model.IdProduto }) %> |
    <%: Html.ActionLink("Back to List", "Index") %>
</p>

</asp:Content>
