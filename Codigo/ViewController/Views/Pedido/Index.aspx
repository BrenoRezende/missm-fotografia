<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Model.Models.PedidoModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Realizar Pedido
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Realizar Pedido</h2>

<th></th>
<fieldset>
<legend>Produtos</legend>
<table>
    <tr>
        <th>
            Código
        </th>
        <th>
            Produto
        </th>
        <th>
            N° de Páginas
        </th>
        <th>
            N° de Imagens
        </th>
        <th>
            Valor do Produto
        </th>
        <th>
            Valor da Imagem Adicional
        </th>
        <th>
            Escolhes
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            
        </td>
        <td>
          
        </td>
        <td>
          
        </td>
        <td>
            
        </td>
        <td>
            
        </td>
        <td>
            
        </td>
        <td>
            
        </td>
        <td>
            <%: Html.ActionLink("Editar", "Edit", new { }) %> |
            <%: Html.ActionLink("Detalhes", "Details", new { }) %> |
            <%: Html.ActionLink("Remover", "Delete", new {  }) %>
        </td>
    </tr>  
<% } %>
</table>
</fieldset>

<th></th>

<fieldset>
<legend>Tipo de Eventos</legend>
<table>
    <tr>
        <th>
            Código
        </th>
        <th>
            Tipo de Evento
        </th>
        <th>
            Categoria
        </th>
        <th>
            Total de Convidados
        </th>
        <th>
            Valor do Evento
        </th>
       
        <th>
            Escolhes
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            
        </td>
        <td>
          
        </td>
        <td>
          
        </td>
        <td>
            
        </td>
        <td>
            
        </td>
        <td>
            
        </td>

        <td>
            <%: Html.ActionLink("Editar", "Edit", new { }) %> |
            <%: Html.ActionLink("Detalhes", "Details", new { }) %> |
            <%: Html.ActionLink("Remover", "Delete", new {  }) %>
        </td>
    </tr>  
<% } %>
</table>
</fieldset>
<th></th>

<fieldset>
<legend>Serviços</legend>
<table>
    <tr>
        <th>
            Código
        </th>
        <th>
            Tipo de Serviço
        </th>
        <th>
            Parceiro
        </th>
        <th>
            Contatos
        </th>
        <th>
            Valor do Serviço
        </th>
       
        <th>
            Escolhes
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            
        </td>
        <td>
          
        </td>
        <td>
          
        </td>
        <td>
            
        </td>
        <td>
            
        </td>
        <td>
            
        </td>

        <td>
            <%: Html.ActionLink("Editar", "Edit", new { }) %> |
            <%: Html.ActionLink("Detalhes", "Details", new { }) %> |
            <%: Html.ActionLink("Remover", "Delete", new {  }) %>
        </td>
    </tr>  
<% } %>
</table>
</fieldset>
<p>
    <%: Html.ActionLink("Gerar Orçamento", "Create") %>
</p>

</asp:Content>
