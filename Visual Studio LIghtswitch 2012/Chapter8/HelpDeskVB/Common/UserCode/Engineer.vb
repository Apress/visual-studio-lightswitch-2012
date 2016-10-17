Imports System.Text.RegularExpressions
Namespace LightSwitchApplication

    Public Class Engineer

        Private Sub Fullname_Compute(ByRef result As String)
            result = String.Format("{0} - {1}", Surname, Firstname)
        End Sub

        Private Sub Age_Compute(ByRef result As Integer)
            result = DateDiff(DateInterval.Year, DateOfBirth, Now)
        End Sub


        Private Sub IssueCount_Compute(ByRef result As Integer)
            result = Issues.Count()
        End Sub


        Private Sub SSN_Validate(
                                results As EntityValidationResultsBuilder)
            Dim pattern As String =
                "^(?!000)([0-6]\d{2}|7([0-6]\d|7[012]))([ -]?)(?!00)\d\d\3(?!0000)\d{4}$"
            If (Not SSN Is Nothing) AndAlso
                (Regex.IsMatch(SSN, pattern) = False) Then
                results.AddPropertyError(
                    "Enter SSN in format 078-05-1120")
            End If

        End Sub

        Private Sub EngineerPhoto_Validate(results As EntityValidationResultsBuilder)
            If Me.EngineerPhoto IsNot Nothing Then
                Dim sizeInKB = Me.EngineerPhoto.Length / 1024
                If sizeInKB > 512 Then
                    results.AddPropertyError("File Size cannot be > 512kb")
                End If
            End If

        End Sub



        Private Sub ClearanceReference_Validate(results As EntityValidationResultsBuilder)

            If Len(Me.ClearanceReference) > 0 Then
                Dim duplicateOnServer = (
                    From eng In
                    Me.DataWorkspace.ApplicationData.Engineers.Cast(Of Engineer)()
                    Where
                    eng.Id <> Me.Id AndAlso
                eng.ClearanceReference IsNot Nothing AndAlso
                eng.ClearanceReference.Equals(Me.ClearanceReference,
                                        StringComparison.CurrentCultureIgnoreCase)
                    ).ToArray()

                Dim duplicateOnClients = (
                    From eng In
                    Me.DataWorkspace.ApplicationData.Details.GetChanges().
                       OfType(Of Engineer)()
                    Where
                    eng IsNot Me AndAlso
                eng.ClearanceReference IsNot Nothing AndAlso
                    eng.ClearanceReference.Equals(Me.ClearanceReference,
                       StringComparison.CurrentCultureIgnoreCase)
                    ).ToArray()

                Dim deleltedOnClient = Me.DataWorkspace.ApplicationData.Details.GetChanges().
                    DeletedEntities.OfType(Of Engineer)().ToArray()

                Dim anyDuplicates = duplicateOnServer.Union(duplicateOnClients).Distinct().
                    Except(deleltedOnClient).Any()

                If anyDuplicates Then
                    results.AddPropertyError("The clearance reference already exists")
                End If

            End If

        End Sub

        Private Sub Engineer_AllowSaveWithErrors(ByRef result As Boolean)
            result = Application.User.HasPermission(Permissions.CanBypassValidation)
        End Sub
    End Class

End Namespace


