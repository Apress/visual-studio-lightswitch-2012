
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

    End Class

End Namespace