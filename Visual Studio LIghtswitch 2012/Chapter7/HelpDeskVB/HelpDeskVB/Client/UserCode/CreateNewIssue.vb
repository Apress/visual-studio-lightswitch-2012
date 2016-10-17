'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".


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