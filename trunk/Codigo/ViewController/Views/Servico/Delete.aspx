<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.ServicoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Remover Serviço
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Remover Serviço</h2>
<h3>Tem certeza de que deseja exluir esse serviço?</h3>
<fieldset>
    <legend>Dados do Serviço</legend>

    <div class="display-label">Código</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdServico) %>
    </div>

    <div class="display-label">Tipo de Serviço</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NomeServico)%>
    </div>

    <div class="display-label">Parceiro</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NomeParceiro)%>
    </div>

    <div class="display-label">Telefone do Parceiro</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TelefoneParceiro) %>
    </div>

    <div class="display-label">Valor do Serviço</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ValorServico) %>
    </div>

    <div class="display-label">Valor Cobrado ao Cliente</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ValorCobradoAoCliente) %>
    </div>

</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Remover" /> |
        <%: Html.ActionLink("Voltar", "Index") %>
    </p>
<% } %>


</asp:Content>
