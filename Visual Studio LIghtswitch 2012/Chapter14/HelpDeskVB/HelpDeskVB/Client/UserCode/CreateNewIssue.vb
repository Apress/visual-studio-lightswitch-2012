
Namespace LightSwitchApplication

    Public Class CreateNewIssue

        Private Sub CreateNewIssue_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            ' Write your code here.
            Me.IssueProperty = New Issue()

            'Listing 7-2. Setting Control Values
            Me.IssueProperty.Priority =
               DataWorkspace.ApplicationData.Priorities.Where(
                  Function(item) item.PriorityDesc = "Medium").
                    FirstOrDefault()


            'Listing 7-9. Setting the Focus to a Control 
            Me.FindControl("ProblemDescription").Focus()


            'Listing 7 - 20.Threading
            'Me.Details.Dispatcher.BeginInvoke(
            '    Sub()
            '        'This code executes on the screen logic thread
            '        Me.IssueProperty.ProblemDescription = "Desc. (screen logic thread)"
            '    End Sub)

            'Microsoft.LightSwitch.Threading.Dispatchers.Main.BeginInvoke(
            '    Sub()
            '        'This code executes on the UI thread 
            '        Me.IssueProperty.ProblemDescription = "Desc. (main thread)"
            '    End Sub)


        End Sub

        'Listing 7-7. Reset the New Data Screen After a Save
        Private Sub CreateNewIssue_Saved()
            'Delete the auto generated lines below 
            'Me.Close(False)
            'Application.Current.ShowDefaultScreen(Me.IssueProperty)
            Me.IssueProperty = New Issue
        End Sub

    End Class

End Namespace