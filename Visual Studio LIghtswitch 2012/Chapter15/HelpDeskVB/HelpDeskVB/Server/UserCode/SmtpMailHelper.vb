﻿'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.Net
Imports System.Net.Mail
Imports System.IO

Public Module SmtpMailHelper
    Const SMTPServer As String = "relay.yourmailserver.net"
    Const SMTPUserId As String = "myUsername "
    Const SMTPPassword As String = "myPassword"
    Const SMTPPort As Integer = 25

    Public Sub SendMail(sendFrom As String,
     sendTo As String,
     subject As String,
     body As String,
     attachment As Byte(),
     filename As String)

        Dim fromAddress As New MailAddress(sendFrom)
        Dim toAddress As New MailAddress(sendTo)
        Dim mail As New MailMessage()

        'mail.From = fromAddress
        mail.To.Add(toAddress)
        mail.Subject = subject
        mail.Body = body
        If body.ToLower().Contains("<html>") Then
            mail.IsBodyHtml = True
        End If

        'Use the server context API to get the SMTP details from the AppOptions table
        Dim appOptionServer As String
        Dim appOptionPort As String
        Dim appOptionSentFrom As String

        If Not LightSwitchApplication.ServerApplicationContext.Current Is Nothing Then
            Dim appOption = LightSwitchApplication.ServerApplicationContext.Current.DataWorkspace.ApplicationData.AppOptions.FirstOrDefault()
            appOptionServer = appOption.SMTPServer
            appOptionPort = appOption.SMTPPort
            appOptionSentFrom = appOption.EmailFrom
        Else
            Using serverContext = LightSwitchApplication.ServerApplicationContext.CreateContext()
                Dim appOption = serverContext.DataWorkspace.ApplicationData.AppOptions.FirstOrDefault()
                appOptionServer = appOption.SMTPServer
                appOptionPort = appOption.SMTPPort
                appOptionSentFrom = appOption.EmailFrom
            End Using
        End If

        Dim smtp As New SmtpClient(appOptionServer, appOptionPort)
        mail.From = New MailAddress(appOptionSentFrom)

        'This is the code that you'd use to pick up the hardcoded SMTP values instead
        'Dim smtp As New SmtpClient(SMTPServer, SMTPPort)

        If attachment IsNot Nothing AndAlso
           Not String.IsNullOrEmpty(filename) Then
            Using ms As New MemoryStream(attachment)
                mail.Attachments.Add(New Attachment(ms, filename))
                smtp.Send(mail)
            End Using
        Else
            smtp.Send(mail)
        End If

    End Sub

End Module
