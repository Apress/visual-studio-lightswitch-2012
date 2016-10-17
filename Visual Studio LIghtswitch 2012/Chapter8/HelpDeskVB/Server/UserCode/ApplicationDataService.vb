'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.Linq.Expressions
Imports System.Transactions
Imports System.Text

Namespace LightSwitchApplication

    Public Class ApplicationDataService

        Private Sub Issues_Validate(entity As Issue, results As EntitySetValidationResultsBuilder
            )
            ' Check for validation errors for deletions
            If entity.Details.EntityState = EntityState.Deleted Then
                If entity.IssueResponses.Where(
                   Function(s) s.AwaitingClient).Any() Then
                    results.AddEntityError(
                        "Cannot delete issues with responses awaiting client.")
                End If
            End If

        End Sub

        Private Sub Issues_Updated(entity As Issue) '
            Dim issueHistory As IssueStatusChange =
            Me.DataWorkspace.ApplicationData.IssueStatusChanges.AddNew()
            issueHistory.OldStatus =
                entity.Details.Properties.IssueStatus.OriginalValue
            issueHistory.NewStatus = entity.IssueStatus
            issueHistory.ChangeDate = DateTime.UtcNow
            issueHistory.Issue = entity
        End Sub


        Private Sub Issues_Deleting(entity As Issue)

            ' Check for validation errors for deletions
            If entity.Details.ValidationResults.Errors.Any Then
                Throw New ValidationException(Nothing,
                    Nothing, entity.Details.ValidationResults)
            End If
            ' Cascade delete children because delete rule is Restricted
            For Each resp In entity.IssueResponses
                resp.Delete()
            Next

        End Sub

        Private Sub EngineersWithOutstandingIssues_PreprocessQuery(ByRef query As IQueryable(Of Engineer))
            query = query.Where(Function(engItem) engItem.Issues.Where(
              Function(issueItem) issueItem.IssueStatus.StatusDescription = "Open").Any())
        End Sub

        Private Sub IssuesWithAttachments_PreprocessQuery(
           ByRef query As IQueryable(Of Issue))
            query = query.Where(Function(issueItem) issueItem.IssueDocuments.Any())
        End Sub

        Private Sub IssuesByMonthAndYear_PreprocessQuery(IssueMonth As System.Nullable(Of Integer), IssueYear As System.Nullable(Of Integer), ByRef query As System.Linq.IQueryable(Of LightSwitchApplication.Issue))

            If (IssueMonth.HasValue And IssueYear.HasValue) Then
                query = query.Where(
                    Function(item) item.CreateDateTime.Month = IssueMonth.Value AndAlso
                        item.CreateDateTime.Year = IssueYear.Value)
            End If
        End Sub

        Private Sub IssuesWithHighestFeedback_PreprocessQuery(ByRef query As System.Linq.IQueryable(Of LightSwitchApplication.Issue))
            query = query.OrderByDescending(
                Function(issueItem) issueItem.IssueFeedback.Average(
                    Function(feedback) feedback.OverallRating)).Take(5)
        End Sub

        Private Sub EmailOperations_Inserting(entity As EmailOperation)
            SmtpMailHelper.SendMail(
              entity.SenderEmail,
              entity.RecipientEmail,
              entity.Subject,
              entity.Body,
              entity.Attachment,
              entity.AttachmentFileName)
        End Sub

    End Class

End Namespace


