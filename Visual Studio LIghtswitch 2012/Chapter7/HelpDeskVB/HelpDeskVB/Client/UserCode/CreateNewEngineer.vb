'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.ComponentModel

Namespace LightSwitchApplication

    Public Class CreateNewEngineer

        Private Sub CreateNewEngineer_InitializeDataWorkspace(ByVal saveChangesTo As Global.System.Collections.Generic.List(Of Global.Microsoft.LightSwitch.IDataService))
            ' Write your code here.
            Me.EngineerProperty = New Engineer()
        End Sub


        Private Sub CreateNewEngineer_Saved()
            ' Write your code here.
            Me.Close(False)
            Application.Current.ShowDefaultScreen(Me.EngineerProperty)
        End Sub


        'Listing 7-21. Using PropertyChanged on a New Ddata Sscreen 
        Private Sub CreateNewEngineer_Created()
            Microsoft.LightSwitch.Threading.Dispatchers.Main.BeginInvoke(
                Sub()
            AddHandler DirectCast(
              Me.EngineerProperty, INotifyPropertyChanged
            ).PropertyChanged, AddressOf EngineerFieldChanged
        End Sub)

            'Set the initial visibility here
            Me.FindControl("SecurityGroup").IsVisible =
                EngineerProperty.SecurityVetted
        End Sub

        Private Sub EngineerFieldChanged(
            sender As Object, e As PropertyChangedEventArgs)
            If e.PropertyName = "SecurityVetted" Then
                Me.FindControl("SecurityGroup").IsVisible =
                   EngineerProperty.SecurityVetted
            End If
        End Sub


    End Class

End Namespace