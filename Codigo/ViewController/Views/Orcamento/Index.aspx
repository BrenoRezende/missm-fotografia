<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Model.Models.OrcamentoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Criar Orçamento
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<h2>Criar Orçamento</h2>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Lista de Produtos</legend>
                
        <p></p>
        
        <h2>Produtos Escolhidos</h2>

        <div>
            <%: Html.DropDownListFor(model => model.IdProduto, ViewBag.listaProdutos as SelectList)%>
            <%: Html.ValidationMessageFor(model => model.IdTipoEvento) %>
            <input type="submit" value="Adicionar" />
        </div>
        <p></p>
        <div style="overflow: auto; width: 1020px; height: 200px; ">   
        <table class="tabela" style="width:1000px">          
            <tr>
                <th>
                    Nome do Produto
                </th>
                <th>
                    Formato
                </th>
                <th>
                    Número de Páginas
                </th>
                <th>
                    Número de Imagens
                </th>
                <th>
                    Valor do Produto
                </th>
                <th>
                    Remover
                </th>
            </tr>
        
            <% foreach (var item in ViewBag.listaProdutos)
               { %>
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

            </tr>
            <% } %>
        </table>  
        </div>    

    </fieldset>

<p></p>

    <fieldset>
        <legend>Lista de Produtos</legend>
                
        <p></p>
        
        <h2>Serviços Escolhidos</h2>

        <div>
            <%: Html.DropDownListFor(model => model.IdServico, ViewBag.listaServicos as SelectList)%>
            <%: Html.ValidationMessageFor(model => model.IdServico) %>
            <input type="submit" value="Adicionar" />
        </div>
        <p></p>
        <div style="overflow: auto; width: 1020px; height: 200px; ">   
        <table class="tabela" style="width:1000px">          
            <tr>
                <th>
                    Tipo do Servico
                </th>
                <th>
                    Nome do Parceiro
                </th>
                <th>
                    Tel. Parceiro
                </th>
                <th>
                    Valor do Serviço
                </th>
                <th>
                    Remover
                </th>
            </tr>
        
            <% foreach (var item in ViewBag.listaServicos)
               { %>
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


            </tr>
            <% } %>
        </table>  
        </div>    

    </fieldset>

    <p></p>

     <fieldset>
        <legend>Lista de Produtos</legend>
                
        <p></p>
        
        <h2>Produtos Escolhidos</h2>

        <div>
            <%: Html.DropDownListFor(model => model.IdTipoEvento, ViewBag.listaTipoDeEventos as SelectList)%>
            <%: Html.ValidationMessageFor(model => model.IdTipoEvento) %>
            <input type="submit" value="Adicionar" />
        </div>
        <p></p>
        <div style="overflow: auto; width: 1020px; height: 200px; ">   
        <table class="tabela" style="width:1000px">          
            <tr>
                <th>
                    Tipo de Evento
                </th>
                <th>
                    Total de Convidados
                </th>
                <th>
                    Valor do Evento
                </th>
                
                <th>
                    Remover
                </th>
            </tr>
        
            <% foreach (var item in ViewBag.listaTipoDeEventos)
               { %>
            <tr>
                <td>
                               
                </td>
                <td>
                   
                </td>
                <td>
                  
                </td>
                <td>
                   
                </td>

            </tr>
            <% } %>
        </table>  
        </div>    

    </fieldset>
<% } %>



</asp:Content>
