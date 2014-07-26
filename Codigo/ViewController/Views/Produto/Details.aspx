<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.ProdutoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
Detalhes do Produto
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>Detalhes do Produto</h2>
<fieldset>
    <legend>Dados do Produto</legend>

    <div class="display-label">Código</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdProduto) %>
    </div>
    <p></p>
    <div class="display-label">Nome</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nome) %>
    </div>
    <p></p>
    <div class="display-label">Numero de Páginas</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NumeroDePaginas) %>
    </div>
    <p></p>
    <div class="display-label">Formato</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Formato) %>
    </div>
    <p></p>
    <div class="display-label">Numero de Imagens</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NumeroDeImagens) %>
    </div>
    <p></p>
    <div class="display-label">Valor do Produto</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ValorDoProduto) %>
    </div>
    <p></p>
</fieldset>
<p>
    <%: Html.ActionLink("Editar", "Edit", new { id=Model.IdProduto }) %> |
    <%: Html.ActionLink("Voltar", "Index") %>
</p>

</asp:Content>
