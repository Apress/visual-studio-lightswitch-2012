'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".


Imports System.Text

Namespace LightSwitchApplication

    Public Class EngineerDashboard

        Private Sub Engineer_Loaded(succeeded As Boolean)

            'Listing 7-3. Setting the Screen Title in Code
            Me.DisplayName = "Engineer Dashboard"
            'Me.SetDisplayNameFromEntity(Me.Engineer)

            ScreenTitle = "Engineer Dashboard for " & Engineer.Fullname

            Dim outstandingIssues =
                Engineer.Issues.Where(Function(engIssue) engIssue.ClosedDateTime.HasValue = False)

            'Listing 6-2. Using the Any Standard Query Operator
            Dim highPriorityExists As Boolean =
                outstandingIssues.Any(
                    Function(engIssue) engIssue.Priority.PriorityDesc = "High")

            'Listing 6-3. Using the All Standard Query Operator
            Dim oldIssueExists As Boolean =
                Engineer.Issues.Where(
                    Function(engIssue) engIssue.CreateDateTime < DateTime.Now.AddDays(-7)).All(
                        Function(engIssue) engIssue.ClosedDateTime.HasValue)

            'Listing 6-4. Using the ForEach Operator
            Dim sb As StringBuilder = New StringBuilder()

            outstandingIssues.OrderByDescending(
                Function(engItem) engItem.CreateDateTime).Take(5).ToList().ForEach(
                    Function(engItem) sb.AppendLine(engItem.ProblemDescription))

            'Listing 6-5. Querying Data Collections  
            Dim startOfYear = New DateTime(DateTime.Now.Year, 1, 1)

            'Query 1
            Dim issuesLastMonth =
                Engineer.Issues.Where(
                    Function(issueItem) issueItem.CreateDateTime > startOfYear).
                        Count()

            'Query 2
            Dim issuesLastMonth2 =
                Engineer.IssuesQuery.Where(
                    Function(issueItem) issueItem.CreateDateTime > startOfYear).
                        Execute().Count()


            'Listing 7-12. Referencing a Control Using ControlAvailable 
            AddHandler Me.FindControl("IssuesOverdueLabel").ControlAvailable,
                Sub(sender As Object, e As ControlAvailableEventArgs)
                    Dim issueLabel = CType(e.Control, 
                        System.Windows.Controls.TextBlock)
                    issueLabel.Foreground = New SolidColorBrush(Colors.Red)
                End Sub

            'Set labels
            IssuesOverdueLabel =
                String.Format("{0} open issues", outstandingIssues.Count.ToString)

            If highPriorityExists Then
                HighPriorityIssuesLabel = "There are high priority open issues"
            Else
                HighPriorityIssuesLabel = "There are NO high priority open issues"
            End If

            If oldIssueExists Then
                OldIssuesLabel = "All issues that are 7 days or older are closed"
            Else
                OldIssuesLabel = "NOT all issues that are 7 days or older are closed"
            End If

            Issues5OldestLabel = sb.ToString

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

        Private Sub OpenIssue_Execute()
            Application.ShowAddEditIssue(QuickFindIssue.Id)
        End Sub
    End Class

End Namespace