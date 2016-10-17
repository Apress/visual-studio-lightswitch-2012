'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.Text

Namespace LightSwitchApplication

    Public Class EngineerDashboard

        Private Sub Engineer_Loaded(succeeded As Boolean)
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Engineer)

            ScreenTitle = "The details beneath are relevant to the engineer '" & Me.Engineer.Fullname & "'."

            Dim outstandingIssues =
                Engineer.Issues.Where(Function(engIssue) Not engIssue.ClosedDateTime.HasValue)

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


            'Set labels
            OpenIssuesLabel = String.Format("{0} open issues", outstandingIssues.Count.ToString)
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

            Top5Label = sb.ToString

        End Sub

        Private Sub Engineer_Changed()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Engineer)
        End Sub

        Private Sub EngineerDashboard_Saved()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Engineer)
        End Sub

    End Class

End Namespace