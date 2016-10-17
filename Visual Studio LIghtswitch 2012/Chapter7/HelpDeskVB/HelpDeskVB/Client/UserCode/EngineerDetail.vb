'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.ComponentModel

Namespace LightSwitchApplication

    Public Class EngineerDetail

        Private Sub Engineer_Loaded(succeeded As Boolean)
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Engineer)

            'Set the initial visibility here
            Me.FindControl("SecurityGroup").IsVisible =
                Me.Engineer.SecurityVetted

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

        'Listing 7-18. Assigning and Unassigning Subordinates
        Private Sub AssignSubordinate_Execute()
            Engineer.Subordinates.Add(EngineerToAdd)
            Me.Save()
            Subordinates.Refresh()
        End Sub

        Private Sub UnassignSubordinate_Execute()
            Engineer.Subordinates.Remove(Subordinates.SelectedItem)
            Me.Save()
            Subordinates.Refresh()
        End Sub

        ' Listing 7-22. Using PropertyChanged on a Details Screen 
        Private monitoredEngineer As Engineer

        Private Sub EngineerDetail_InitializeDataWorkspace(
           saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            ' Write your code here.
            Microsoft.LightSwitch.Threading.Dispatchers.Main.BeginInvoke(
              Sub()

                  AddHandler Me.Details.Properties.Engineer.Loader.ExecuteCompleted,
                                                          AddressOf Me.EngineerLoaderExecuted
              End Sub)
        End Sub

        Private Sub EngineerLoaderExecuted(
            sender As Object, e As Microsoft.LightSwitch.ExecuteCompletedEventArgs)

            If monitoredEngineer IsNot Me.Engineer Then
                If monitoredEngineer IsNot Nothing Then
                    RemoveHandler TryCast(monitoredEngineer, 
                        INotifyPropertyChanged).PropertyChanged,
                            AddressOf Me.EngineerChanged
                End If

                monitoredEngineer = Me.Engineer

                If monitoredEngineer IsNot Nothing Then
                    AddHandler TryCast(
                       monitoredEngineer, INotifyPropertyChanged).PropertyChanged,
                          AddressOf Me.EngineerChanged

                    'Set the initial visibility here
                    Me.FindControl("SecurityGroup").IsVisible =
                        monitoredEngineer.SecurityVetted

                End If
            End If
        End Sub

        Private Sub EngineerChanged(
           sender As Object, e As PropertyChangedEventArgs)
            If e.PropertyName = "SecurityVetted" Then
                Me.FindControl("SecurityGroup").IsVisible =
                    monitoredEngineer.SecurityVetted
            End If
        End Sub

    End Class

End Namespace