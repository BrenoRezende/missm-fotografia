<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.PedidoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Remover
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


<h3>Tem certeza que deseja remover esse orçamento?</h3>
<fieldset>
    <legend>Remover Orçamento</legend>

    <div class="display-field">
        <%: Html.HiddenFor(model => model.IdPedido) %>
    </div>

    <div class="display-label">Nome do Orçamento</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NomePedido) %>
    </div>

    <div class="display-label">Data de Criacão</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DataCriacao) %>
    </div>

    <div class="display-label">Valor</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Valor) %>
    </div>


    <div class="display-label">Data de Emissão</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DataEmissao) %>
    </div>

    <div class="display-label">Nome do Cliente</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NomePessoa) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Remover" /> 
    </p>
<% } %>
<div>
        <a href="<%: Url.Action("Index", "Pessoa") %>">
            <button>Voltar</button>
        </a>
</div>
</asp:Content>
