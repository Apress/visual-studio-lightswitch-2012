'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.Web
Imports System.Web.Services

Public Class SendMail
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest

        '1  Is the user authenticated? Does he belong in the Manager Role?  
        'context.User.Identity.IsAuthenticated 
        'context.User.IsInRole("Manager")

        If context.Request.Params("emailTo") IsNot Nothing AndAlso
        context.Request.Params("subject") IsNot Nothing AndAlso
        context.Request.Params("body") IsNot Nothing Then
            Try
                Dim senderEmail As String = "admin@lsfaq.com"
                SmtpMailHelper.SendMail(senderEmail,
                    context.Request.Params("emailTo").ToString(),
                    context.Request.Params("subject").ToString(),
                    context.Request.Params("body").ToString(), Nothing, Nothing)
                context.Response.Write("Email Sent")
            Catch ex As Exception
                context.Response.Write(ex.Message)
            End Try
        Else
            context.Response.Write("EmailTo, Subject, and Body required")
        End If

    End Sub

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class