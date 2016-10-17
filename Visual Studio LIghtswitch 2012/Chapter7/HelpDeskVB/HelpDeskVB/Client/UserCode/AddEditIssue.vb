'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".


Namespace LightSwitchApplication

    Public Class AddEditIssue


        'Listing 7-14. Issue Add and Edit Code

        Private Sub Issue_Loaded(succeeded As Boolean)
            'Hide the related records section in 'new mode'
            Me.FindControl("RelatedRecords").IsVisible = Me.IssueId.HasValue

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

    End Class

End Namespace