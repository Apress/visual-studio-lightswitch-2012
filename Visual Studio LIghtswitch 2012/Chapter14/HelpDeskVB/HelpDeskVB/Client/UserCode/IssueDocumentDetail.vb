'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.Windows.Controls
Imports Microsoft.LightSwitch.Threading
Imports System.Runtime.InteropServices.Automation

Namespace LightSwitchApplication

    Public Class IssueDocumentDetail

        Private Sub IssueDocument_Loaded(succeeded As Boolean)
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.IssueDocument)
        End Sub

        Private Sub IssueDocument_Changed()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.IssueDocument)
        End Sub

        Private Sub IssueDocumentDetail_Saved()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.IssueDocument)
        End Sub


        'Listing 7-24. Downloading a Ffile
        Private Sub SaveFileFromDatabase_Execute()

            '1 Invoke the method on the main UI thread                            
            Dispatchers.Main.Invoke(
                Sub()
                    Dim ms As System.IO.MemoryStream =
                        New System.IO.MemoryStream(IssueDocument.IssueFile)

                    Dispatchers.Main.Invoke(
                        Sub()
                    Dim saveDialog As New Controls.SaveFileDialog

                    If saveDialog.ShowDialog = True Then
                        Using fileStream As Stream = saveDialog.OpenFile
                            ms.WriteTo(fileStream)
                        End Using
                    End If
                End Sub)
                End Sub)

        End Sub

        'Listing 7-25. Opening Ffiles in Ttheir Aapplications
        Private Sub OpenFileFromDatabase_Execute()
            ' Write your code here.
            Try
                If (AutomationFactory.IsAvailable) Then
                    'here's where we'll save the file
                    Dim fullFilePath As String =
                        System.IO.Path.Combine(
                            Environment.GetFolderPath(
                                Environment.SpecialFolder.MyDocuments),
                                    IssueDocument.DocumentName)

                    Dim fileData As Byte() = IssueDocument.IssueFile.ToArray()

                    If (fileData IsNot Nothing) Then
                        Using fs As New FileStream(
                                  fullFilePath, FileMode.OpenOrCreate, FileAccess.Write)
                            fs.Write(fileData, 0, fileData.Length)
                            fs.Close()
                        End Using
                    End If

                    Dim shell = AutomationFactory.CreateObject("Shell.Application")
                    shell.ShellExecute(fullFilePath)

                End If
            Catch ex As Exception
                Me.ShowMessageBox(ex.ToString())
            End Try

        End Sub

    End Class

End Namespace