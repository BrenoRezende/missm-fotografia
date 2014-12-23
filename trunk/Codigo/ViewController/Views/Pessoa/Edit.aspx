<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.PessoaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Editar Cliente
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<h2>Editar Cliente</h2>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Dados do Cliente</legend>

        <div class="editor-field">
            <%: Html.HiddenFor(model => model.IdPessoa) %>
            <%: Html.ValidationMessageFor(model => model.IdPessoa) %>
        </div>

         <div class="editor-label">
            <%: Html.LabelFor(model => model.Nome) %>
        </div>
        <p></p>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Nome) %>
            <%: Html.ValidationMessageFor(model => model.Nome) %>
        </div>
        <p></p>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Cpf) %>
        </div>
        <p></p>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Cpf) %>
            <%: Html.ValidationMessageFor(model => model.Cpf) %>
        </div>
        <p></p>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Sexo) %>
        </div>
        <p></p>
        <div class="editor-field">
            <%: Html.RadioButtonFor(model => model.Sexo, "M", new { id = "Sexo_true"})%>
            <label for="Sexo_true">Masculino</label>
            <%: Html.RadioButtonFor(model => model.Sexo, "F", new { id = "Sexo_false"})%>
            <label for="Sexo_false">Feminino</label>

            <%: Html.ValidationMessageFor(model => model.Sexo) %>
        </div>
        <p></p>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.DataNascimento) %>
        </div>
        <p></p>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.DataNascimento) %>
            <%: Html.ValidationMessageFor(model => model.DataNascimento) %>
        </div>
        <p></p>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Telefone) %>
        </div>
        <p></p>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Telefone) %>
            <%: Html.ValidationMessageFor(model => model.Telefone) %>
        </div>
        <p></p>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Email) %>
        </div>
        <p></p>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Email) %>
            <%: Html.ValidationMessageFor(model => model.Email) %>
        </div>
        <p></p>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Senha) %>
        </div>
        <p></p>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Senha)%>
            <%: Html.ValidationMessageFor(model => model.Senha) %>
        </div>
        <p></p>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Rua) %>
        </div>
        <p></p>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Rua) %>
            <%: Html.ValidationMessageFor(model => model.Rua) %>
        </div>
        <p></p>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Numero) %>
        </div>
        <p></p>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Numero) %>
            <%: Html.ValidationMessageFor(model => model.Numero) %>
        </div>
        <p></p>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Bairro) %>
        </div>
        <p></p>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Bairro) %>
            <%: Html.ValidationMessageFor(model => model.Bairro) %>
        </div>
        <p></p>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Cidade) %>
        </div>
        <p></p>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Cidade) %>
            <%: Html.ValidationMessageFor(model => model.Cidade) %>
        </div>
        <p></p>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Estado) %>
        </div>
        <p></p>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Estado) %>
            <%: Html.ValidationMessageFor(model => model.Estado) %>
        </div>
         <p></p>       
        <div class="editor-field">
            <%: Html.HiddenFor(model => model.TipoPessoa) %>        
        </div>


        <p>
            <input type="submit" value="Salvar Alterações" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Voltar", "Index") %>
</div>
</asp:Content>
