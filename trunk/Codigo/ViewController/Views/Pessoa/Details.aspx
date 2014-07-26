<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.PessoaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Detalhes do Cliente
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Detalhes do Cliente</h2>

<fieldset>
    <legend>Dados do Cliente</legend>

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

</fieldset>
<p>
    <%: Html.ActionLink("Editar", "Edit", new { id=Model.IdPessoa }) %> |
    <%: Html.ActionLink("Voltar", "Index") %>
</p>
</asp:Content>
