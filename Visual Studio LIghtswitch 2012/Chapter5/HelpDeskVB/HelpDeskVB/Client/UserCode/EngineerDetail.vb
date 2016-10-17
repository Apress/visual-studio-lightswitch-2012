'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Namespace LightSwitchApplication

    Public Class EngineerDetail

        Private Sub Engineer_Loaded(succeeded As Boolean)
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Engineer)
        End Sub

        Private Sub Engineer_Changed()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Engineer)
        End Sub

        Private Sub EngineerDetail_Saved()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Engineer)
        End Sub


        ' Listing 5-11. Accessing Validation Results in Screen Code  
        Private Sub ValidationSummary_Execute()
            ' Write your code here.

            '' Examples of calling the IsValidated and HasErrors properties
            'Dim firstnameValid As Boolean = Me.Details.Properties.Firstname.IsValidated
            'Dim firstnameHasErrors As Boolean =
            '    Me.Details.Properties.Firstname.ValidationResults.HasErrors

            '' Get a count of all results with a severity of 'Error'
            'Dim errorCount As Integer = Me.Details.ValidationResults.Errors.Count

            '' Concatenate the error messages into a single string
            'Dim allErrors As String = ""
            'For Each result In Me.Details.ValidationResults
            '    allErrors += result.Message + " "
            'Next



        End Sub
    End Class

End Namespace