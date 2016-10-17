'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.ComponentModel

Namespace LightSwitchApplication

    Public Class EngineerDetail

        'Listing 17-7. Adding a Username ComboBox
        Private cbo As ComboBox
        Private Sub OkModalWindow_Execute()
            Microsoft.LightSwitch.Threading.Dispatchers.Main.BeginInvoke(
               Sub()
                   Engineer.LoginName = cbo.SelectedItem.ToString
               End Sub)
        End Sub

        Private Sub CloseModalWindow_Execute()
            Me.CloseModalWindow("LoginPicker")
        End Sub

        Private Sub EngineerDetail_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService)
)

            Microsoft.LightSwitch.Threading.Dispatchers.Main.BeginInvoke(
              Sub()
                  AddHandler Me.Details.Properties.Engineer.Loader.ExecuteCompleted,
                      AddressOf Me.EngineerLoaderExecuted
              End Sub)

            'Listing 17-7. Adding a Username ComboBox
            'Set assigned login details
            Dim items = DataWorkspace.SecurityData.UserRegistrations.Cast(
               Of Microsoft.LightSwitch.Security.UserRegistration)().ToList

            AddHandler FindControl("LoginNameProperty").ControlAvailable,
               Sub(sender As Object, e As ControlAvailableEventArgs)
                   cbo = CType(e.Control, ComboBox)

                   Microsoft.LightSwitch.Threading.Dispatchers.Main.BeginInvoke(
                      Sub()
                          cbo.ItemsSource = items
                          cbo.DisplayMemberPath = "FullName"
                      End Sub)
               End Sub
        End Sub

        Private Sub Engineer_Loaded(succeeded As Boolean)
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Engineer)

            Me.FindControl("LoginPicker").IsEnabled = Me.Application.User.HasPermission(Permissions.CanEditEngineers)

        End Sub

        Private Sub Engineer_Changed()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Engineer)
        End Sub

        Private Sub EngineerDetail_Saved()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Engineer)
        End Sub



        'Listing 7-18. Assigning and Unassigning Subordinates
        Private Sub AssignSubordinate_Execute()
            Engineer.Subordinates.Add(EngineerToAdd)
            Subordinates.Refresh()
        End Sub

        Private Sub UnassignSubordinate_Execute()
            Engineer.Subordinates.Remove(Subordinates.SelectedItem)
            Subordinates.Refresh()
        End Sub

        ' Listing 7-22. Using PropertyChanged on a Ddetails Sscreen 
        Private monitoredEngineer As Engineer

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