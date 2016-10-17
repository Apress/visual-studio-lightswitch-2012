'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.Windows.Controls
Imports Microsoft.LightSwitch.Threading

Namespace LightSwitchApplication

    Public Class CreateNewIssueDocument

        Private Sub CreateNewIssueDocument_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            ' Write your code here.
            Me.IssueDocumentProperty = New IssueDocument()

            If IssueId.HasValue Then
                'set the default value
                IssueDocumentProperty.Issue =
                    DataWorkspace.ApplicationData.Issues.Where(Function(item) item.Id = IssueId).SingleOrDefault
            End If
        End Sub

        Private Sub CreateNewIssueDocument_Saved()
            ' Write your code here.
            Me.Close(False)
            Application.Current.ShowDefaultScreen(Me.IssueDocumentProperty)
        End Sub

        'Listing 7-23. Uploading a File
        Private Sub UploadFileToDatabase_Execute()

            '1 Invoke the method on the main UI thread                           
            Dispatchers.Main.Invoke(
                Sub()

                    Dim openDialog As New Controls.OpenFileDialog
                    openDialog.Filter = "All files|*.*"
                    'Use this syntax to only allow Word/Excel files
                    'openDialog.Filter = "Word Files|*.doc|Excel Files |*.xls" 

                    If openDialog.ShowDialog = True Then
                        Using fileData As System.IO.FileStream =
                            openDialog.File.OpenRead

                            Dim fileLen As Long = fileData.Length

                            If (fileLen > 0) Then
                                Dim fileBArray(fileLen - 1) As Byte
                                fileData.Read(fileBArray, 0, fileLen)
                                fileData.Close()

                                Me.IssueDocumentProperty.IssueFile = fileBArray
                                Me.IssueDocumentProperty.FileExtension =
                                    openDialog.File.Extension.ToString()
                                Me.IssueDocumentProperty.DocumentName =
                                    openDialog.File.Name

                            End If

                        End Using
                    End If

                End Sub)

        End Sub

    End Class

End Namespace