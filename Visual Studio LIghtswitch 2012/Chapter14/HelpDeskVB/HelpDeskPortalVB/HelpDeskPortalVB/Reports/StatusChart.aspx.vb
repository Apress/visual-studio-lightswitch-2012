Imports System.Security

Public Class StatusChart
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Refer to Chapter 14 to find out how to secure this web page
        ''Listing 14-2. Securing Access to Reports 
        'If User.Identity.Name = "Tim" Then
        '    Throw New SecurityException("Access Denied to Tim")
        'End If
        'If User.IsInRole("Engineers") Then
        '    Throw New SecurityException(
        '        "Access Denied to users in the Engineers group")
        'End If

    End Sub

End Class