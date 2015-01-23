<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Model.Models.TipoEventoModel>" %>


<script src="<%: Url.Content("~/Scripts/jquery-1.5.1.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>
<% using (Html.BeginForm("NovoTipoEvento", "Orcamento"))
   { %>
<%: Html.ValidationSummary(true) %>
   
   
    <div class="row-fluid">
        <div class="span6">
            <div class="editor-field">
            <%: Html.DropDownList("IdTipoEvento", "Selecione") %>
            <%: Html.ValidationMessageFor(model => model.IdTipoEvento) %>
            </div>
        </div>
    </div>
    <div>
        <input type="submit" value="Adicionar" />
    </div>

<% } %>
