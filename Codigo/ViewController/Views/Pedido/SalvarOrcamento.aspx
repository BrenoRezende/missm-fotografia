<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.PedidoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    SalvarOrcamento
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>SalvarOrcamento</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Salvar Orçamento</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.NomePedido) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.NomePedido) %>
            <%: Html.ValidationMessageFor(model => model.NomePedido) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.IdPessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.IdPessoa, ViewBag.IdCliente as SelectList) %>
            <%: Html.ValidationMessageFor(model => model.IdPessoa) %>
        </div>

        <p>
            <input type="submit" value="Salvar" />
        </p>
    </fieldset>
<% } %>

<div>
        <a href="<%: Url.Action("Index", "Orcamento") %>">
            <button>Voltar</button>
        </a>
    </div>

</asp:Content>
