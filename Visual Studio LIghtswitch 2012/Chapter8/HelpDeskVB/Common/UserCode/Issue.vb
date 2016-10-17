
Namespace LightSwitchApplication

    Public Class Issue

        Private Sub ClosedByEngineer_Validate(
            results As EntityValidationResultsBuilder)

            'If ClosedDateTime.HasValue Then
            '    results.AddPropertyError("Closed By Engineer must be entered")
            'End If





        End Sub

        Private Sub IssueSummary_Compute(ByRef result As String)
            ' Set result to the desired field value
            result = String.Format("({0}) - {1}", Id.ToString, Strings.Left(ProblemDescription, 50))
        End Sub

        Private Sub Issue_AllowSaveWithErrors(ByRef result As Boolean)
            result =
                Application.User.HasPermission(Permissions.CanBypassValidation)



        End Sub

        Private Sub Engineer_IsReadOnly(ByRef result As Boolean)
            result =
                Current.User.HasPermission(Permissions.CanAssignIssueToEngineer)
        End Sub

        Private Sub ProblemDescription_IsReadOnly(ByRef result As Boolean)
            result =
                Current.User.HasPermission(Permissions.CanChangeIssueDescription)
        End Sub

    End Class

End Namespace


