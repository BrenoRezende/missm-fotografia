
<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master"Inherits="System.Web.Mvc.ViewPage<Model.Models.PedidoModel>" %>

<script runat="server">

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Criar Orçamento
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1" runat="server">
<h2>Criar Orçamento</h2>


<% using (Html.BeginForm()) { %>
    
    <fieldset>       
        <legend> Lista de Produtos</legend>
            <p></p>
            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" 
                onselectedindexchanged="GridView1_SelectedIndexChanged" AllowPaging="True" 
                AutoGenerateColumns="False" Width="1144px">
                <Columns>
                    <asp:BoundField DataField="nomeProduto" HeaderText="Nome" />
                    <asp:BoundField DataField="formato" HeaderText="Formato" />
                    <asp:BoundField DataField="numeroDePaginas" HeaderText="Número De Páginas" />
                    <asp:BoundField DataField="numeroDeImagens" HeaderText="Número de Imagens" />
                    <asp:BoundField DataField="valorDoProduto" DataFormatString="{0:c}" 
                        HeaderText="Valor" />
                    <asp:CheckBoxField HeaderText="Escolher" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:missmfotografiaConnectionString4 %>" 
                ProviderName="<%$ ConnectionStrings:missmfotografiaConnectionString4.ProviderName %>" 
                
                SelectCommand="SELECT nomeProduto, numeroDePaginas, formato, numeroDeImagens, valorDoProduto FROM tb_produto" 
                OldValuesParameterFormatString="original_{0}">
            </asp:SqlDataSource>            
    </fieldset>
<% } %>


    </form>


</asp:Content>
