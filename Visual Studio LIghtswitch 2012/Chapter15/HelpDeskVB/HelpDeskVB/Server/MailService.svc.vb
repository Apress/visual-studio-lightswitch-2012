'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

' NOTE: You can use the "Rename" command on the context menu to change the class name "MailService" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select MailService.svc or MailService.svc.vb at the Solution Explorer and start debugging.
Imports System.ServiceModel.Activation

'Listing 15-17. Implementing Your Web Service Method
<AspNetCompatibilityRequirements(
    RequirementsMode:=AspNetCompatibilityRequirementsMode.Required)> _
Public Class MailService
    Implements IMailService

    Public Function SendMail(
       emailTo As String, subject As String, body As String
          ) As String Implements IMailService.SendMail
        Try
            Dim senderEmail As String = "admin@lsfaq.com"
            SmtpMailHelper.SendMail(
               senderEmail, emailTo, subject, body,
               Nothing, Nothing) ' optional - add email attachment here...
            Return ("Email Sent")
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

End Class
