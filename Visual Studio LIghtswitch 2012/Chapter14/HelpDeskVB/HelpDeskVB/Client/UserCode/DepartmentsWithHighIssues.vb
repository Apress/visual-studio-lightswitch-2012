'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.Runtime.InteropServices.Automation
Imports System.Reflection

'Listing 14-11. Mail-Merge Code 
Namespace LightSwitchApplication

    Public Class DepartmentsWithHighIssues

        ' Declare Global Variables
        Private wordApp As Object
        Private wordDoc As Object
        Private missingValue As Object = System.Reflection.Missing.Value

        ' Here are the values of the WdMailMergeDestination Enum
        Const wdSendToNewDocument As Integer = 0
        Const wdSendToPrinter As Integer = 1
        Const wdSendToEmail As Integer = 2
        Const wdSendToFax As Integer = 3

        Private Sub DoMailMerge_Execute()
            Dim wordMailMerge As Object
            Dim wordMergeFields As Object

            'Copy the word template file to 'My Documents'
            SaveTemplateToMyDocuments()
            Dim path = Environment.GetFolderPath(
              Environment.SpecialFolder.MyDocuments) + "\MailMergeTemplate.dotx"

            ' Create an instance of Word  and make it visible.
            wordApp = AutomationFactory.CreateObject("Word.Application")
            wordApp.Visible = True

            ' Open the template file
            wordDoc = wordApp.Documents.Open(path)
            wordDoc.Select()

            wordMailMerge = wordDoc.MailMerge

            ' Create a MailMerge Data file.
            CreateMailMergeDataFile()

            wordMergeFields = wordMailMerge.Fields
            wordMailMerge.Destination = wdSendToNewDocument
            wordMailMerge.Execute(False)

            ' Close the original form document.
            wordDoc.Saved = True
            wordDoc.Close(False, missingValue, missingValue)

            ' Release References.
            wordMailMerge = Nothing
            wordMergeFields = Nothing
            wordDoc = Nothing
            wordApp = Nothing

        End Sub

        Private Sub CreateMailMergeDataFile()

            Dim wordDataDoc As Object

            'Specify a Location with write access
            Dim fileName As String =
                 Environment.GetFolderPath(
                              Environment.SpecialFolder.MyDocuments) + "\DataDoc.doc"

            Dim header As Object =
               "DepartmentName, DepartmentManager, Address1"

            wordDoc.MailMerge.CreateDataSource(
               fileName, missingValue, missingValue, header)

            ' Open the data document to insert data.
            wordDataDoc = wordApp.Documents.Open(fileName)

            ' Loop through the department screen collection
            ' Start at rowCount 2 because row 1 contains the column headers

            Dim rowCount As Integer = 2
            For Each d As Department In Departments
                FillRow(wordDataDoc, rowCount,
                    d.DepartmentName, d.DepartmentManager, d.Address1)
                rowCount += 1
            Next

            ' Save and close the file.
            wordDataDoc.Save()
            wordDataDoc.Close(False)

        End Sub

        Private Sub FillRow(WordDoc As Object, Row As Integer,
           Text1 As String, Text2 As String, Text3 As String)

            If Row > WordDoc.Tables(1).Rows.Count Then
                WordDoc.Tables(1).Rows.Add()
            End If

            ' Insert the data into the table.
            WordDoc.Tables(1).Cell(Row, 1).Range.InsertAfter(Text1)
            WordDoc.Tables(1).Cell(Row, 2).Range.InsertAfter(Text2)
            WordDoc.Tables(1).Cell(Row, 3).Range.InsertAfter(Text3)

        End Sub


        'Listing 14-12. Creating the Mail Merge Fields in Code
        Private Sub DoMailMergeInCode_Execute()

            Dim wordMailMerge As Object
            Dim wordMergeFields As Object

            ' Create an instance of Word  and make it visible.
            wordApp = AutomationFactory.CreateObject("Word.Application")
            wordApp.Visible = True

            ' Create a new file rather than open it from a template 
            wordDoc = wordApp.Documents.Add()

            Dim wordSelection As Object
            wordSelection = wordApp.Selection
            wordMailMerge = wordDoc.MailMerge

            ' Create a MailMerge Data file.
            CreateMailMergeDataFile()

            wordMergeFields = wordMailMerge.Fields

            ' Type the salutation and add the 'DepartmentManager' merge field
            If FormalityProperty.GetValueOrDefault(False) Then
                wordSelection.TypeText("Dear ")
            Else
                wordSelection.TypeText("Hi ")
            End If

            Dim wordRange As Object = wordSelection.Range

            wordMergeFields.Add(wordRange, "DepartmentManager")
            wordSelection.TypeText("," & Environment.NewLine)
            ' add the paragraph text that the user has entered

            wordSelection.TypeText("Here's an example of a mail merge that doesn't rely on a .DOT or .DOTX file. " & Environment.NewLine)

            wordSelection.TypeText(FirstParagraphProperty)

            ' Perform mail merge.
            wordMailMerge.Destination = 0
            wordMailMerge.Execute(False)

            ' Close the original form document.
            wordDoc.Saved = True
            wordDoc.Close(False, missingValue, missingValue)

            ' Release References.
            wordMailMerge = Nothing
            wordMergeFields = Nothing
            wordDoc = Nothing
            wordApp = Nothing


        End Sub


        'Listing 14-10. Saving the Word Template to My Documents\LetterTemplate.dot
        Private Sub SaveTemplateToMyDocuments()

            Dim resourceInfo = System.Windows.Application.GetResourceStream(
               New Uri("Resources/MailMergeTemplate.dotx", UriKind.Relative))

            Dim path = Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments) + "\MailMergeTemplate.dotx"

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

        Private Sub DepartmentsWithHighIssues_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            FirstParagraphProperty = "Enter your letter text here.."
        End Sub

    End Class

End Namespace



