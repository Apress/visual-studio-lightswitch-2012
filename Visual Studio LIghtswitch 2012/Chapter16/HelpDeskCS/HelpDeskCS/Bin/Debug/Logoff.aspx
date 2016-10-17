<%@ Page Language="C#" %> 
<%--Listing 16-1. Logoff.aspx Code--%>
<%
System.Web.Security.FormsAuthentication.SignOut();
Response.Redirect("default.htm");
%>
