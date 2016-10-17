
Namespace LightSwitchApplication

    Public Class CreateNewIssue

        Private Sub CreateNewIssue_InitializeDataWorkspace(ByVal saveChangesTo As Global.System.Collections.Generic.List(Of Global.Microsoft.LightSwitch.IDataService))
            ' Write your code here.
            Me.IssueProperty = New Issue()
        End Sub

        Private Sub CreateNewIssue_Saved()
            ' Write your code here.
            Me.Close(False)
            Application.Current.ShowDefaultScreen(Me.IssueProperty)
        End Sub

    End Class

End Namespace