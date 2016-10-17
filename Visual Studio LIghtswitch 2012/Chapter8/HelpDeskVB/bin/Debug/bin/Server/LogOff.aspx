<%@ Page Language="vb" %> 
<%
System.Web.Security.FormsAuthentication.SignOut()
Response.Redirect("default.htm")
%>
