<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.PessoaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h3>Tem certeza que deseja remover esse produto?</h3>

<fieldset>
    <legend>Remover Pessoa</legend>

    <div class="display-label">Código</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdPessoa) %>
    </div>

    <div class="display-label">Nome</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NomePessoa) %>
    </div>

    <div class="display-label">Cpf</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CpfPessoa) %>
    </div>

    <div class="display-label">Sexo</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.SexoPessoa) %>
    </div>

    <div class="display-label">Data de Nascimento</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DataNascimentoPessoa) %>
    </div>

    <div class="display-label">Telefone</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TelefonePessoa) %>
    </div>

    <div class="display-label">E-Mail</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.EmailPessoa) %>
    </div>

    <div class="display-label">Senha da Pessoa</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.SenhaPessoa) %>
    </div>

    <div class="display-label">Rua</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.RuaPessoa) %>
    </div>

    <div class="display-label">Número</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NumeroPessoa) %>
    </div>

    <div class="display-label">Bairro</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.BairroPessoa) %>
    </div>

    <div class="display-label">Cidade</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CidadePessoa) %>
    </div>

    <div class="display-label">Estado</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.EstadoPessoa) %>
    </div>

    <div class="display-label">Tipo Pessoa</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TipoPessoa) %>
    </div>
</fieldset>

<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Remover" /> |
        <%: Html.ActionLink("Voltar", "Index") %>
    </p>
<% } %>

</asp:Content>
