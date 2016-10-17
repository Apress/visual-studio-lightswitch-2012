'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.Transactions
Imports System.Text

Namespace LightSwitchApplication

    Public Class ApplicationDataService


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


    End Class

End Namespace
