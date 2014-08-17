<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%
    if (Request.IsAuthenticated) {
%>
        Bem vindo <strong><%: Page.User.Identity.Name %></strong>!
        [ <%: Html.ActionLink("Sair", "LogOff", "Account") %> ]
<%
    }
    else {
%> 
        [ <%: Html.ActionLink("Entrar", "Login", "Account") %> ]
<%
    }
%>
