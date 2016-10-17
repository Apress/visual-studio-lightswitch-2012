'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

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

        Private Sub OpenPDFReport_Execute()
            Me.ShowMessageBox("This button would run code that opens the PDF Report. See Chapter 14 to find out exactly how to generate PDF output")
        End Sub

        'Listing 17-5. Editing a Command’s CanExecute Method
        Private Sub OpenPDFReport_CanExecute(ByRef result As Boolean)
            result = Application.User.HasPermission(Permissions.CanViewReport)
        End Sub

    End Class

End Namespace