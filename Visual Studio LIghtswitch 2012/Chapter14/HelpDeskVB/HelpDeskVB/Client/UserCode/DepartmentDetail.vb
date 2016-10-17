'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.Runtime.InteropServices.Automation

Namespace LightSwitchApplication

    Public Class DepartmentDetail

        Private Sub Department_Loaded(succeeded As Boolean)
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Department)

        End Sub

        Private Sub Department_Changed()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Department)
        End Sub

        Private Sub DepartmentDetail_Saved()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Department)
        End Sub

        'Listing 14-8. Microsoft Word Automation Code 
        Private Sub CreateWordDoc_Execute()
            If AutomationFactory.IsAvailable Then
                Try

                    'Copy the word template file to 'My Documents'
                    SaveTemplateToMyDocuments()

                    Using wordApp = AutomationFactory.CreateObject("Word.Application")
                        'Dim wordDoc = wordApp.Documents.Open("\\FileServer\Templates\LetterTemplate.dotx")
                        Dim path = Environment.GetFolderPath(
                              Environment.SpecialFolder.MyDocuments) + "\LetterTemplate.dotx"
                        Dim wordDoc = wordApp.Documents.Open(path)
                        wordDoc.Bookmarks("DepartmentName").Range.InsertAfter(
                    Department.DepartmentName)
                        wordApp.Visible = True
                    End Using
                Catch ex As Exception
                    Throw New InvalidOperationException("Failed to create letter.", ex)
                End Try
            End If

        End Sub

        'Listing 14-9. Printing and Closing a Word Document
        Private Sub CreateWordDocPrinter_Execute()
            If AutomationFactory.IsAvailable Then
                Try

                    'Copy the word template file to 'My Documents'
                    SaveTemplateToMyDocuments()

                    Using wordApp = AutomationFactory.CreateObject("Word.Application")
                        'Dim wordDoc = wordApp.Documents.Open("\\FileServer\Templates\LetterTemplate.dotx")
                        Dim path = Environment.GetFolderPath(
                              Environment.SpecialFolder.MyDocuments) + "\LetterTemplate.dotx"
                        Dim wordDoc = wordApp.Documents.Open(path)
                        wordDoc.Bookmarks("DepartmentName").Range.InsertAfter(
                    Department.DepartmentName)
                        wordApp.PrintOut()
                        wordDoc.Close(0)

                    End Using
                Catch ex As Exception
                    Throw New InvalidOperationException("Failed to create letter.", ex)
                End Try
            End If


        End Sub

        'Listing 14-10. Saving the Word Template to My Documents\LetterTemplate.dot
        Private Sub SaveTemplateToMyDocuments()


            Dim resourceInfo = System.Windows.Application.GetResourceStream(
               New Uri("Resources/LetterTemplate.dotx", UriKind.Relative))

            Dim path = Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments) + "\LetterTemplate.dotx"

            If Not File.Exists(path) Then
                Dim file = System.IO.File.Create(path)
                file.Close()

                'Write the stream to the file
                Dim stream As System.IO.Stream = resourceInfo.Stream

                Using fileStream = System.IO.File.Open(path,
                   System.IO.FileMode.OpenOrCreate,
                   System.IO.FileAccess.Write,
                   System.IO.FileShare.None)

                    Dim buffer(0 To stream.Length - 1) As Byte
                    stream.Read(buffer, 0, stream.Length)
                    fileStream.Write(buffer, 0, buffer.Length)
                End Using
            End If

        End Sub


    End Class

End Namespace