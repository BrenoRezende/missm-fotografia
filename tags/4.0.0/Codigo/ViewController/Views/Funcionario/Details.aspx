<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.FuncionarioModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Detalhes do Funcionario
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Detalhes do Funcionario</h2>

<fieldset>
    <legend>Dados do Funcionario</legend>

    <div class="display-label">Código</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdPessoa) %>
    </div>

    <div class="display-label">Nome</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nome) %>
    </div>

    <div class="display-label">Cpf</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Cpf) %>
    </div>

    <div class="display-label">Sexo</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Sexo) %>
    </div>

    <div class="display-label">Data de Nascimento</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DataNascimento) %>
    </div>

    <div class="display-label">Telefone</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Telefone) %>
    </div>

    <div class="display-label">E-Mail</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Email) %>
    </div>

    <div class="display-label">Senha</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Senha) %>
    </div>

    <div class="display-label">Rua</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Rua) %>
    </div>

    <div class="display-label">Número</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Numero) %>
    </div>

        <div class="display-label">Bairro</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Bairro) %>
    </div>

    <div class="display-label">Cidade</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Cidade) %>
    </div>

    <div class="display-label">Estado</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Estado) %>
    </div>

    <div class="display-label">Tipo Pessoa</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TipoPessoa) %>
    </div>

    <div class="display-label">Tipo de Conta</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TipoConta) %>
    </div>

    <div class="display-label">Banco</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Banco) %>
    </div>

        <div class="display-label">Agência</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Agencia) %>
    </div>

    <div class="display-label">Número da Conta</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NumeroConta) %>
    </div>
</fieldset>
<p>
    <%: Html.ActionLink("Editar", "Edit", new { id=Model.IdPessoa }) %> |
    <%: Html.ActionLink("Voltar", "Index") %>
</p>
</asp:Content>
