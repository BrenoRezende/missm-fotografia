<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.ServicoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Delete</h2>



<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>ServicoModel</legend>

    <div class="display-label">IdServico</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdServico) %>
    </div>

    <div class="display-label">Tipo de Serviço</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TipoServico) %>
    </div>

    <div class="display-label">Parceiro</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Parceiro) %>
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
        <input type="submit" value="Delete" /> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>
<% } %>


</asp:Content>
