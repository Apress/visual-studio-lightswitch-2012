'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
Imports System.Runtime.InteropServices.Automation

Namespace LightSwitchApplication

    Public Class AddEditIssue

        'Listing 7-14. Issue Add and Edit Code
        Private Sub Issue_Loaded(succeeded As Boolean)

            If Not Me.IssueId.HasValue Then
                Me.IssueProperty = New Issue()
            Else
                Me.IssueProperty = Me.Issue
            End If

            Me.SetDisplayNameFromEntity(Me.Issue)

        End Sub

        Private Sub Issue_Changed()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Issue)
        End Sub

        Private Sub AddEditIssue_Saved()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Issue)
        End Sub

        Private Sub AddIssueResponse_Execute()
            Application.ShowCreateNewIssueResponse(IssueProperty.Id)
        End Sub

        Private Sub AddIssueDocument_Execute()
            ' Write your code here.
            Application.ShowCreateNewIssueDocument(IssueProperty.Id)

        End Sub

        'The PDF example below uses the silverpdf library 
        'http://silverpdf.codeplex.com/license
        'The license details follow beneath:
        '
        'Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
        'The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
        'THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

        'Listing 14-13. Programming silverPDF 
        Private Sub OpenPDFReport_Execute()

            Microsoft.LightSwitch.Threading.Dispatchers.Main.BeginInvoke(
               Sub()
                   Dim document As New PdfDocument()
                   document.Info.Title = "Issue"

                   ' Create an empty page
                   Dim page As PdfPage = document.AddPage()

                   ' Create a set of  fonts                                          
                   Dim fontHeader1 As New XFont("Verdana", 18, XFontStyle.Bold)
                   Dim fontHeader2 As New XFont("Verdana", 14, XFontStyle.Bold)
                   Dim fontNormal As New XFont("Verdana", 12, XFontStyle.Regular)

                   ' Get an XGraphics object for drawing
                   Dim gfx As XGraphics = XGraphics.FromPdfPage(page)

                   ' Create the report text
                   gfx.DrawString("HelpDesk - Issue Detail", fontHeader1,
                   XBrushes.Black, New XRect(10, 10, 200, 18), XStringFormats.TopLeft)

                   gfx.DrawString("Issue Id:" & Issue.Id.ToString(), fontNormal,
                       XBrushes.Black, New XRect(10, 30, 200, 18), XStringFormats.TopLeft)

                   gfx.DrawString(Issue.Subject, fontHeader2,
                   XBrushes.Black, New XRect(10, 50, 200, 18), XStringFormats.TopLeft)
                   '.... create other Elements here

                   ' Save the document here
                   Dim myDocuments As String = Environment.GetFolderPath(
                       Environment.SpecialFolder.MyDocuments)

                   document.Save(myDocuments & "\IssueReport.pdf")

                   'optionally 'shell' the native PDF application to view the file
                   Dim shell = AutomationFactory.CreateObject("Shell.Application")
                   shell.ShellExecute(myDocuments & "\IssueReport.pdf", "", "", "open", 1)

               End Sub
               )

        End Sub

    End Class

End Namespace
Namespace UserCode

    Public Class AddEditIssue

    End Class

End Namespace
