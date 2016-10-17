Imports System.Linq.Expressions
Imports System.Transactions
Imports System.Text

Namespace LightSwitchApplication

    Public Class ApplicationDataService

        'Listing 17-1. Setting Access-Control Permissions
        Private Sub Engineers_CanDelete(ByRef result As Boolean)
            result = Application.User.HasPermission(
               Permissions.CanEditEngineers)
        End Sub

        Private Sub Engineers_CanInsert(ByRef result As Boolean)
            result = Application.User.HasPermission(
                Permissions.CanEditEngineers)
        End Sub

        Private Sub Engineers_CanUpdate(ByRef result As Boolean)
            result = Application.User.HasPermission(
                Permissions.CanEditEngineers)
        End Sub

        'Listing 17-2. Preventing Users from Saving Data
        Private Sub SaveChanges_CanExecute(ByRef result As Boolean)
            'System is down for daily maintenance from midnight to 3am
            If Now.TimeOfDay.Hours >= 0 AndAlso
                Now.TimeOfDay.Hours <= 3 Then
                result = False
            Else
                result = True
            End If
        End Sub


        Private Sub Issues_Validate(entity As Issue, results As EntitySetValidationResultsBuilder)

            'Listing 5-6. Validating the Counts of Child Items 
            If entity.IssueDocuments.Count > 10 Then
                results.AddEntityError(
                   "Issues can only contain a maximum of 10 documents")
            End If

            'Listing 5-10. Validating Deletions on the Server 
            ' Check for validation errors for deletions
            If entity.Details.EntityState = EntityState.Deleted Then
                If entity.IssueResponses.Where(
                   Function(s) s.AwaitingClient).Any() Then
                    results.AddEntityError(
                       "Cannot delete issues with responses awaiting client.")
                End If

            End If

        End Sub

        'Listing 5-10. Validating Deletions on the Server 
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

        'Listing 6-7. Filtering by Child Items   
        Private Sub EngineersWithOutstandingIssues_PreprocessQuery(ByRef query As System.Linq.IQueryable(Of LightSwitchApplication.Engineer))
            query = query.Where(Function(engItem) engItem.Issues.Where(
              Function(issueItem) issueItem.IssueStatus.StatusDescription = "Open").Any())

        End Sub

        'Listing 6-9. Returning All Issues with Related Issue Document Records
        Private Sub IssuesWithAttachments_PreprocessQuery(ByRef query As System.Linq.IQueryable(Of LightSwitchApplication.Issue))
            query = query.Where(Function(issueItem) issueItem.IssueDocuments.Any())
        End Sub

        'Listing 6-11. Returning Issue Records Without Any Issue Responses   
        Private Sub IssuesWithNoResponse_PreprocessQuery(ByRef query As System.Linq.IQueryable(Of LightSwitchApplication.Issue))
            query = query.Where(Function(issueItem) Not issueItem.IssueResponses.Any())
        End Sub

        'Listing 6-12. Filtering by Month and Year Parameter Values   
        Private Sub IssuesByMonthAndYear_PreprocessQuery(IssueMonth As System.Nullable(Of Integer), IssueYear As System.Nullable(Of Integer), ByRef query As System.Linq.IQueryable(Of LightSwitchApplication.Issue))
            If (IssueMonth.HasValue And IssueYear.HasValue) Then
                query = query.Where(
                    Function(item) item.CreateDateTime.Month = IssueMonth.Value AndAlso
                        item.CreateDateTime.Year = IssueYear.Value)
            End If
        End Sub

        'Listing 6-13. Query to Return Issues with the Highest Feedback
        Private Sub IssuesWithHighestFeedback_PreprocessQuery(ByRef query As System.Linq.IQueryable(Of LightSwitchApplication.Issue))
            query = query.OrderByDescending(
    Function(issueItem) issueItem.IssueFeedbacks.Average(
        Function(feedback) feedback.OverallRating)).Take(5)

        End Sub

        'Listing 17-6. Editing a Query’s CanExecute Method
        Private Sub IssuesWithHighestFeedback_CanExecute(ByRef result As Boolean)
            result =
                Application.User.HasPermission(Permissions.CanViewReport)
        End Sub


        'Listing 17-9. Restricting Row-Level Access to Data
        Private Sub Issues_Filter(ByRef filter As System.Linq.Expressions.Expression(Of System.Func(Of Issue, Boolean)))
            ' filter = Function(e) e.IntegerProperty = 0

            If Not Application.User.HasPermission(Permissions.CanViewAllIssues) Then

                'This is the code that filters the records by the actual user
                'Dim currentUser As String = Application.User.Name

                'Dim currentEng As Engineer =
                '    DataWorkspace.ApplicationData.Engineers.Where(
                '        Function(eng) eng.LoginName = currentUser).FirstOrDefault

                'If currentEng IsNot Nothing Then
                '    Filter = Function(e) e.AssignedTo.Id = currentEng.Id
                'End If

                Dim firstEngId = DataWorkspace.ApplicationData.Engineers.FirstOrDefault().Id
                filter = Function(e) e.AssignedTo.Id = firstEngId

            End If

        End Sub

    End Class

End Namespace
