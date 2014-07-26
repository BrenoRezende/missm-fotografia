<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.ServicoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Detalhes do Serviço
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Detalhes do Serviço</h2>

<fieldset>
    <legend>Dados do Serviço</legend>

   <div class="display-label">Código</div>
   <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdServico) %>
    </div>
    <p></p>
    <div class="display-label">Tipo de Serviço</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NomeServico)%>
    </div>
    <p></p>
    <div class="display-label">Parceiro</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NomeParceiro)%>
    </div>
    <p></p>
    <div class="display-label">Telefone do Parceiro</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TelefoneParceiro) %>
    </div>
    <p></p>
    <div class="display-label">Valor do Serviço</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ValorServico) %>
    </div>
    <p></p>
    <div class="display-label">Valor Cobrado ao Cliente</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ValorCobradoAoCliente) %>
    </div>

</fieldset>
<p>
    <%: Html.ActionLink("Editar", "Edit", new { id=Model.IdServico }) %> |
    <%: Html.ActionLink("Voltar", "Index") %>
</p>

</asp:Content>
