'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Namespace LightSwitchApplication

    Public Class Issue

        Private Sub IssueSummary_Compute(ByRef result As String)
            ' Set result to the desired field value
            result = String.Format("({0}) - {1}", Id.ToString, Strings.Left(ProblemDescription, 50))
        End Sub

        Private Sub Issue_AllowSaveWithErrors(ByRef result As Boolean)
            result =
                Application.User.HasPermission(Permissions.CanBypassValidation)
        End Sub

        Private Sub AssignedTo_IsReadOnly(ByRef result As Boolean)
            result =
                Application.User.HasPermission(Permissions.CanAssignIssueToEngineer)
        End Sub

        Private Sub ProblemDescription_IsReadOnly(ByRef result As Boolean)
            result =
                Application.User.HasPermission(Permissions.CanChangeIssueDescription)
        End Sub

        Private Sub ClosedByEngineer_Validate(results As EntityValidationResultsBuilder)
            If ClosedByEngineer IsNot Nothing And
                ClosedDateTime.HasValue = False Then
                results.AddPropertyError("Closed By Date must be entered")
            End If
        End Sub

    End Class

End Namespace


