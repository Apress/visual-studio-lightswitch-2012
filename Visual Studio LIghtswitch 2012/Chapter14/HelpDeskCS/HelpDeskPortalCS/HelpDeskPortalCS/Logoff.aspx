<%@ Page Language="C#" %>

<%
System.Web.Security.FormsAuthentication.SignOut();
Response.Redirect("default.htm");
%>

