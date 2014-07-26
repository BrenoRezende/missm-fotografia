<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.FuncionarioModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Remover Funcionário
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Remover Funcionário</h2>
<h1>Tem certeza que deseja remover esse funcionário?</h1>

<fieldset>
    <div class="display-label">Código</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdPessoa) %>
    </div>
    <p></p>
    <div class="display-label">Nome</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nome) %>
    </div>
    <p></p>
    <div class="display-label">Cpf</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Cpf) %>
    </div>
    <p></p>
    <div class="display-label">Sexo</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Sexo) %>
    </div>
    <p></p>
    <div class="display-label">Data de Nascimento</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DataNascimento) %>
    </div>
    <p></p>
    <div class="display-label">Telefone</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Telefone) %>
    </div>
    <p></p>
    <div class="display-label">E-Mail</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Email) %>
    </div>
    <p></p>
    <div class="display-label">Senha</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Senha) %>
    </div>
    <p></p>
    <div class="display-label">Rua</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Rua) %>
    </div>
    <p></p>
    <div class="display-label">Número</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Numero) %>
    </div>
    <p></p>
    <div class="display-label">Bairro</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Bairro) %>
    </div>
    <p></p>
    <div class="display-label">Cidade</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Cidade) %>
    </div>
    <p></p>
    <div class="display-label">Estado</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Estado) %>
    </div>
    <p></p>
     <div class="display-label">Tipo Pessoa</div>
     <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TipoPessoa) %>
    </div>
    <p></p>
    <div class="display-label">Tipo de Conta</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TipoConta) %>
    </div>
    <p></p>
    <div class="display-label">Banco</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Banco) %>
    </div>
    <p></p>
    <div class="display-label">Agência</div>
    <p></p>

    <div class="display-field">
        <%: Html.DisplayFor(model => model.Agencia) %>
    </div>
    <p></p>
    <div class="display-label">Número da Conta</div>
    <p></p>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NumeroConta) %>
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
