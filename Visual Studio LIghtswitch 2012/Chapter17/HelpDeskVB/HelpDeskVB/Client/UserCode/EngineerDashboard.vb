'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, Pro LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.Text

Namespace LightSwitchApplication

    Public Class EngineerDashboard

        Private Sub Engineer_Loaded(succeeded As Boolean)

            'Listing 7-3. Setting the Screen Title in Code
            Me.DisplayName = "Engineer Dashboard"
            'Me.SetDisplayNameFromEntity(Me.Engineer)

            ScreenTitle = "Engineer Dashboard Screen for " & Me.Engineer.Fullname

            Try
                Dim outstandingIssues =
                    Engineer.Issues.Where(Function(engIssue) engIssue.ClosedDateTime.HasValue = False)

                'Listing 6-4. Using the ForEach Operator
                Dim sb As StringBuilder = New StringBuilder()

                outstandingIssues.OrderByDescending(
                    Function(engItem) engItem.CreateDateTime).Take(5).ToList().ForEach(
                        Function(engItem) sb.AppendLine(engItem.ProblemDescription))

                Issues5OldestLabel = sb.ToString

                IssuesOutstandingLabel =
                    String.Format("You have {0} open issue(s)", outstandingIssues.Count().ToString)

            Catch ex As Exception

            End Try


        End Sub

        Private Sub Engineer_Changed()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Engineer)
        End Sub

        Private Sub EngineerDashboard_Saved()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Engineer)
        End Sub

        ' Listing 7-5. Refreshing All Open Screens
        Private Sub RefreshAllScreens_Execute()
            Dim screens = Me.Application.ActiveScreens()
            For Each s In screens
                Dim screen = s.Screen
                screen.Details.Dispatcher.BeginInvoke(
         Sub()
             screen.Refresh()
         End Sub)
            Next

        End Sub

        ' Listing 7-6. Passing Screen Parameters
        Private Sub OpenIssueSearchScreen_Execute()
            Application.ShowIssueSearchAll(Me.Engineer.Id)
        End Sub


        'Listing 7-15. Opening the Combination Screen to Add a New Record
        Private Sub OpenNewIssueScreen_Execute()
            Application.ShowAddEditIssue(Nothing)
        End Sub


    End Class

End Namespace