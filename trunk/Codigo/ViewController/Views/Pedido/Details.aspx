<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Detalhes do Orçamento
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<fieldset>
        <legend>Produtos do Orçamento</legend>
        <p>
        </p>
        <table>
            <tr>
                <th>
                    Nome
                </th>
                <th>
                    Número de páginas
                </th>
                <th>
                    Número de imagens
                </th>
                <th>
                    Formato
                </th>
                <th>
                    Valor
                </th>
            </tr>
            <% foreach (var item in ViewBag.pedidoProdutoModel)
               { %>
            <tr>
                <td>
                    <%: item.Nome %>
                </td>
                <td>
                    <%: item.NumeroDePaginas %>
                </td>
                <td>
                    <%: item.NumeroDeImagens%>
                </td>
                <td>
                    <%: item.Formato%>
                </td>
                <td>
                    <%: item.ValorDoProduto%>
                </td>
            </tr>
            <% } %>
        </table>
</fieldset>
<br />
<fieldset>
        <legend>Serviços do Orçamento</legend>
        <p>
        </p>
        <table>
            <tr>
                <th>
                    Nome
                </th>
                <th>
                    Nome do Parceiro
                </th>
                <th>
                    Telefone do Parceiro
                </th>
                <th>
                    Valor do Serviço
                </th>
                <th>
                    Valor Cobrado ao Cliente
                </th>
            </tr>
            <% foreach (var item in ViewBag.pedidoServicoModel)
               { %>
            <tr>
                <td>
                    <%: item.NomeServico %>
                </td>
                <td>
                    <%: item.NomeParceiro %>
                </td>
                <td>
                    <%: item.TelefoneParceiro%>
                </td>
                <td>
                    <%: item.ValorServico %>
                </td>
                <td>
                    <%: item.ValorCobradoAoCliente%>
                </td>
            </tr>
            <% } %>
        </table>
</fieldset>
<br />
<fieldset>
        <legend>Tipos de Evento do Orçamento</legend>
        <p>
        </p>
        <table>
            <tr>
                <th>
                    Nome
                </th>
                <th>
                    Total de Convidados
                </th>
                <th>
                    Valor
                </th>
            </tr>
            <% foreach (var item in ViewBag.pedidoTipoEventoModel)
               { %>
            <tr>
                <td>
                    <%: item.Nome %>
                </td>
                <td>
                    <%: item.TotalConvidados %>
                </td>
                <td>
                    <%: item.Valor%>
                </td>
            </tr>
            <% } %>
        </table>
</fieldset>

<div>
        <a href="<%: Url.Action("Index", "Pessoa") %>">
            <button>Voltar</button>
        </a>
</div>
</asp:Content>
