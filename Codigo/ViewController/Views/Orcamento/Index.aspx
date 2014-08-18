<%@Page Title="" Language="C#" MaintainScrollPositionOnPostback="true" MasterPageFile="~/Views/Shared/Site.Master"
    Inherits="System.Web.Mvc.ViewPage<Model.Models.OrcamentoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Arquivo necessário para as View partial -->
    <script src="<%: Url.Content("~/Scripts/jquery-1.5.1.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>"
        type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>"
        type="text/javascript"></script>
    
    <% using (Html.BeginForm())
       { %>
    <%: Html.ValidationSummary(true)%>
    
    <fieldset>
        <legend>Produtos</legend>
        <div class="thumbnail">
             <% Html.RenderPartial("../Orcamento/NovoProduto", Model.Produto); %>
             <br />
             <% Html.RenderPartial("../Orcamento/ListaProduto", Model.ListaProdutos); %>
        </div>
    </fieldset>
    <fieldset>
        <legend>Serviços</legend>
        <div class="thumbnail">
             <% Html.RenderPartial("../Orcamento/NovoServico", Model.Servico); %>
             <br />
             <% Html.RenderPartial("../Orcamento/ListaServico", Model.ListaServico); %>
        </div>
    </fieldset>
    <fieldset>
        <legend>Tipos de Evento</legend>
        <div class="thumbnail">
             <% Html.RenderPartial("../Orcamento/NovoTipoEvento", Model.TipoEvento); %>
             <br />
             <% Html.RenderPartial("../Orcamento/ListaTipoEvento", Model.ListaTipoEvento); %>
        </div>
    </fieldset>
    <% } %>

    <div>
        <a href="<%: Url.Action("SalvarOrcamento", "Pedido") %>">
            <button>Salvar Orçamento</button>
        </a>
        <a href="<%: Url.Action("Limpar", "Orcamento") %>">
            <button>Limpar Campos</button>
        </a>
    </div>
</asp:Content>
