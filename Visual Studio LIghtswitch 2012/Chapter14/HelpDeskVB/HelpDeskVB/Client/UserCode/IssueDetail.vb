'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Namespace LightSwitchApplication

    Public Class IssueDetail

        Private Sub Issue_Loaded(succeeded As Boolean)
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Issue)
        End Sub

        Private Sub Issue_Changed()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Issue)
        End Sub

        Private Sub IssueDetail_Saved()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Issue)
        End Sub

        ' Listing 4-6. Discarding Screen Changes
        Private Sub DiscardIssueRespChanges_Execute()

            For Each resp As IssueResponse In _
                DataWorkspace.ApplicationData.Details.GetChanges().OfType(Of IssueResponse)()
                resp.Details.DiscardChanges()
            Next
        End Sub

        Private Sub Issue_Validate(results As ScreenValidationResultsBuilder)

            'Listing 5-8. Performing Screen-Level Validation 
            If Issue.Priority Is Nothing Then
                results.AddScreenError("Priority must be entered")
            End If

            'Listing 5-9. Validating Deletions
            If Issue.Details.EntityState = EntityState.Deleted AndAlso
              (Not Issue.IssueStatus Is Nothing) AndAlso
                  (Issue.IssueStatus.StatusDescription = "Open") Then
                results.AddScreenError("Unable to delete open issue")
            End If

        End Sub

        'Listing 5-9. Validating Deletions
        Private Sub DeleteIssue_Execute()
            Issue.Delete()
        End Sub

    End Class

End Namespace