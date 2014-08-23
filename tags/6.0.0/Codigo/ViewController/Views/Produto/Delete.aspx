<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.ProdutoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
Remover Produto
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Remover Produto</h2>
<h3>Tem certeza que deseja remover esse produto?</h3>
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
    <div class="display-label">NumeroDePaginas</div>
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
    <div class="display-label">NumeroDeImagens</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NumeroDeImagens) %>
    </div>
    <p></p>
    <div class="display-label">ValorDoProduto</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ValorDoProduto) %>
    </div>
    <p></p>

</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Remover" /> |
        <%: Html.ActionLink("Voltar", "Index") %>
    </p>
<% } %>

</asp:Content>
