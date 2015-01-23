<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Model.Models.ServicoModel>" %>


<script src="<%: Url.Content("~/Scripts/jquery-1.5.1.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>
<% using (Html.BeginForm("NovoServico", "Orcamento"))
   { %>
<%: Html.ValidationSummary(true) %>

   
    <div class="row-fluid">
        <div class="span6">
            <div class="editor-field">
            <%: Html.DropDownList("IdServico", "Selecione") %>
            <%: Html.ValidationMessageFor(model => model.IdServico) %>
            </div>
        </div>
    </div>
    <div>
        <input type="submit" value="Adicionar" />
    </div>

<% } %>