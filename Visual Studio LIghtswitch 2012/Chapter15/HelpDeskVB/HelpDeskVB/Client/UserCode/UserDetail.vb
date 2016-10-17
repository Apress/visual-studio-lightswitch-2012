'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.Runtime.InteropServices.Automation
Imports Microsoft.LightSwitch.Threading
Imports System.ServiceModel

Namespace LightSwitchApplication

    Public Class UserDetail

        Private Sub User_Loaded(succeeded As Boolean)
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.User)
        End Sub

        Private Sub User_Changed()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.User)
        End Sub

        Private Sub UserDetail_Saved()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.User)
        End Sub

        'Listing 15-5. Button Code for Sending E-mail
        Private Sub SendEmail_Execute()
            Using tempWorkspace As New DataWorkspace()
                Dim newEmail =
                    tempWorkspace.ApplicationData.EmailOperations.AddNew()
                With newEmail
                    .RecipientEmail = User.Email
                    .SenderEmail = "admin@lsfaq.com"
                    .Subject = SubjectProperty
                    .Body = BodyProperty
                End With

                Try
                    tempWorkspace.ApplicationData.SaveChanges()

                    ' If you want, you can write some code here to create a record in an audit table
                    newEmail.Delete()
                    tempWorkspace.ApplicationData.SaveChanges()
                    ShowMessageBox("Your email has been sent")

                Catch ex As Exception
                    ShowMessageBox(ex.Message)
                End Try

            End Using

        End Sub

        'Listing 15-7. Screen Code to Send E-mail Attachments
        Private Sub UserDetail_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            AddHandler Me.FindControl("FileUploadButton").ControlAvailable,
               Sub(sender As Object, e As ControlAvailableEventArgs)

                   CType(e.Control, Button).Content = "Send Message With Attachment"

                   AddHandler CType(e.Control, Button).Click,
                      Sub(sender2 As Object, e2 As RoutedEventArgs)

                          Dim dlg As New OpenFileDialog()
                          If dlg.ShowDialog().GetValueOrDefault(False) = True Then
                              Dim data As Byte()
                              Using stream As FileStream = dlg.File.OpenRead()
                                  data = New Byte(stream.Length - 1) {}
                                  stream.Read(data, 0, data.Length)
                              End Using

                              Dim filename = dlg.File.Name

                              'send the email here
                              Me.Details.Dispatcher.BeginInvoke(
                                 Sub()

                                     Using dw As New DataWorkspace()

                                         'Get the email details from the AppOptions table
                                         Dim appOption = DataWorkspace.ApplicationData.AppOptions.FirstOrDefault()

                                         Dim newEmail =
                                            dw.ApplicationData.EmailOperations.AddNew()
                                         With newEmail
                                             .RecipientEmail = User.Email
                                             '.SenderEmail = "admin@lsfaq.com"
                                             .SenderEmail = appOption.EmailFrom
                                             .Subject = SubjectProperty
                                             .Body = BodyProperty
                                             .Attachment = data
                                             .AttachmentFileName = filename
                                         End With

                                         Try
                                             dw.ApplicationData.SaveChanges()
                                             ' If you want, you can write some code here to 
                                             ' create a record in an audit table
                                             newEmail.Delete()
                                             dw.ApplicationData.SaveChanges()
                                             ShowMessageBox("Your email has been sent")

                                         Catch ex As Exception
                                             ShowMessageBox(ex.Message)
                                         End Try
                                     End Using

                                 End Sub
                              )

                          End If
                      End Sub
               End Sub

        End Sub

        'Listing 15-10. Screen Code to Create an Outlook Message 
        Private Sub SendWithOutlook_Execute()
            OutlookMailHelper.CreateEmail(User.Email,
            SubjectProperty, BodyProperty)
        End Sub

        Private Sub SendWithOutlook_CanExecute(ByRef result As Boolean)
            result = AutomationFactory.IsAvailable
        End Sub

        'Listing 15-12. Screen Code to Use the Default Client  
        Private Sub OpenDefaultMailClient_Execute()
            OpenDefaultMailClient(User.Email,
            SubjectProperty, BodyProperty)

        End Sub

        'Listing 15-11. Sending E-mail by Using a mailto Hyperlink 
        Public Sub OpenDefaultMailClient(
   ByVal toAddress As String,
   ByVal subject As String,
   ByVal body As String)

            subject = System.Uri.EscapeDataString(subject)
            body = System.Uri.EscapeDataString(body)

            Dim url As String = String.Format(
               "mailto:{0}?subject={1}&body={2}", toAddress, subject, body)
            Dim uri As Uri = New Uri(url)

            If AutomationFactory.IsAvailable Then
                Dim shell = AutomationFactory.CreateObject("Shell.Application")
                'shell.ShellExecute(url) if Option Strict is Off
                CompilerServices.Versioned.CallByName(
                   shell, "ShellExecute", CallType.Method, url)
            Else
                Microsoft.LightSwitch.Threading.Dispatchers.Main.BeginInvoke(
                   Sub()
              System.Windows.Browser.HtmlPage.Window.Navigate(
                 uri, "_blank")
          End Sub
                 )
            End If
        End Sub

        'Listing 15-19. Screen Code to Send an E-mail via a Web Service Call
        Private Sub SendWithWebService_Execute()
            Microsoft.LightSwitch.Threading.Dispatchers.Main.BeginInvoke(
               Sub()
                   Dim serverUrl As Uri = System.Windows.Application.Current.Host.Source

                   Details.Dispatcher.BeginInvoke(
                      Sub()
                          'serverUrl.AbsoluteUri returns a URL like this: 
                          '    http://localhost:49715/Client/Web/HelpDesk.Client.xap
                          Dim rootUrl =
                                serverUrl.AbsoluteUri.Substring(
                                0, serverUrl.AbsoluteUri.IndexOf("/Client/Web/"))

                          Dim binding = New System.ServiceModel.BasicHttpBinding()

                          'example endPoint url:
                          '  endPoint http://localhost:49715/MailService.svc
                          Dim endPoint =
                             New EndpointAddress(rootUrl + "/MailService.svc ")

                          Dim proxy As MailService.MailServiceClient =
                             New MailService.MailServiceClient(binding, endPoint)

                          AddHandler proxy.SendMailCompleted,
                             Sub(sender As Object, e As MailService.SendMailCompletedEventArgs)
                        Me.Details.Dispatcher.BeginInvoke(
                           Sub()
                              ShowMessageBox(e.Result.ToString())
                          End Sub
                                  )
                    End Sub

                          proxy.SendMailAsync(User.Email, SubjectProperty, BodyProperty)

                      End Sub
                     )
               End Sub
            )

        End Sub
        
    End Class

End Namespace