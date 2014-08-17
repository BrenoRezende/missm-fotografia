<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Página Inicial
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">      
    <link rel="stylesheet" href="../../Content/layout.css" type="text/css" />
    <div class="wrapper col3">
        <div id="gallery">
            <ul>
                <li class="placeholder" style="background-image: url(../../Content/imagens/default.gif);"></li>
                <li><a class="swap" href="#">
                    <img src="../../Content/imagens/1_s.gif" alt="" /><span><img src="../../Content/imagens/1_s.gif"
                        width="950" height="370" alt="" /></span></a></li>
                <li><a class="swap" href="#">
                    <img src="../../Content/imagens/2_s.gif" alt="" /><span><img src="../../Content/imagens/2.gif"
                        width="950" height="370" alt="" /></span></a></li>
                <li><a class="swap" href="#">
                    <img src="../../Content/imagens/3_s.gif" alt="" /><span><img src="../../Content/imagens/3.gif"
                        width="950" height="370" alt="" /></span></a></li>
                <li><a class="swap" href="#">
                    <img src="../../Content/imagens/4_s.gif" alt="" /><span><img src="../../Content/imagens/4.gif"
                        width="950" height="370" alt="" /></span></a></li>
                <li class="last"><a class="swap" href="#">
                    <img src="../../Content/imagens/5_s.gif" alt="" /><span><img src="../../Content/imagens/5.gif"
                        width="950" height="370" alt="" /></span></a></li>
            </ul>
        </div>
    </div>
    <div class="wrapper col4">
        <div id="services">
            <ul>
                <li><a href="#"><strong>Casamentos</strong><img src="../../Content/imagens/234x210.gif"
                    alt="" /></a></li>
                <li><a href="#"><strong>Acompanhamen -to de Bebê</strong><img src="../../Content/imagens/234x210.gif"
                    alt="" /></a></li>
                <li><a href="#"><strong>Ensaio Casal</strong><img src="../../Content/imagens/234x210.gif"
                    alt="" /></a></li>
                <li class="last"><a href="#"><strong>Batizados</strong><img src="../../Content/imagens/234x210.gif"
                    alt="" /></a></li>
                <li><a href="#"><strong>Aniversário de 15 Anos</strong><img src="../../Content/imagens/234x210.gif"
                    alt="" /></a></li>
                <li><a href="#"><strong>Ensaio Infantil</strong><img src="../../Content/imagens/234x210.gif"
                    alt="" /></a></li>
                <li><a href="#"><strong>Ensaio Feminino</strong><img src="../../Content/imagens/234x210.gif"
                    alt="" /></a></li>
                <li class="last"><a href="#"><strong>Ensaio Masculino</strong><img src="../../Content/imagens/234x210.gif"
                    alt="" /></a></li>
            </ul>
            <br class="clear" />
        </div>
    </div>
</asp:Content>
