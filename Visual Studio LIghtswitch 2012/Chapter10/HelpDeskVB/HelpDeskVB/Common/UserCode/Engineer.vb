'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.Text.RegularExpressions

Namespace LightSwitchApplication

    Public Class Engineer

        Private Sub Fullname_Compute(ByRef result As String)
            result = String.Format("{0} - {1}", Surname, Firstname)
        End Sub

        Private Sub Age_Compute(ByRef result As Integer)
            result = DateDiff(DateInterval.Year, DateOfBirth, Now)
        End Sub

        'Listing 5-1. Creating a Validation Warning  
        Private Sub EmailAddress_Validate(results As EntityValidationResultsBuilder)
            ' results.AddPropertyError("<Error-Message>")
            If String.IsNullOrEmpty(EmailAddress) Then
                results.AddPropertyResult(
                   "Providing an Email Address is recommended",
                     ValidationSeverity.Informational)
            End If

        End Sub

        'Listing 5-4. Regex Validation to Check Social Security Numbers
        Private Sub SSN_Validate(results As EntityValidationResultsBuilder)
            ' results.AddPropertyError("<Error-Message>")
            Dim pattern As String =
    "^(?!000)([0-6]\d{2}|7([0-6]\d|7[012]))([ -]?)(?!00)\d\d\3(?!0000)\d{4}$"
            If (Not SSN Is Nothing) AndAlso
               (Regex.IsMatch(SSN, pattern) = False) Then
                results.AddPropertyError(
                   "Enter SSN in format 078-05-1120")
            End If


        End Sub

        'Listing 5-5. Validating File Sizes
        Private Sub EngineerPhoto_Validate(results As EntityValidationResultsBuilder)
            ' results.AddPropertyError("<Error-Message>")
            If Me.EngineerPhoto IsNot Nothing Then
                Dim sizeInKB = Me.EngineerPhoto.Length / 1024
                If sizeInKB > 512 Then
                    results.AddPropertyError("Image Size cannot be > 512kb")
                End If
            End If

        End Sub

        'Listing 5-7. Enforcing Unique Records
        Private Sub ClearanceReference_Validate(results As EntityValidationResultsBuilder)
            ' results.AddPropertyError("<Error-Message>")
            If Len(Me.ClearanceReference) > 0 Then
                Dim duplicateOnServer = (
                    From eng In
                    Me.DataWorkspace.ApplicationData.Engineers.Cast(Of Engineer)()
                    Where
                    eng.Id <> Me.Id AndAlso
                    eng.ClearanceReference.Equals(Me.ClearanceReference,
                        StringComparison.CurrentCultureIgnoreCase)
                    ).ToArray()

                Dim duplicateOnClients = (
                    From eng In
                    Me.DataWorkspace.ApplicationData.Details.GetChanges().
                       OfType(Of Engineer)()
                    Where
                    eng IsNot Me AndAlso
                    eng.ClearanceReference.Equals(Me.ClearanceReference,
                       StringComparison.CurrentCultureIgnoreCase)
                    ).ToArray()

                Dim deletedOnClient = Me.DataWorkspace.ApplicationData.Details.GetChanges().
                   DeletedEntities.OfType(Of Engineer)().ToArray()

                Dim anyDuplicates = duplicateOnServer.Union(duplicateOnClients).Distinct().
                   Except(deletedOnClient).Any()

                If anyDuplicates Then
                    results.AddPropertyError("The clearance reference already exists")
                End If

            End If

        End Sub
    End Class

End Namespace
