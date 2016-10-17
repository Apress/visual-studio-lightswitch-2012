Imports HelpDeskPortalVB.HelpDeskServiceReference

Public Class CreateIssue
    Inherits System.Web.UI.Page

    Protected Sub AddIssue_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim srvRef As ApplicationData =
        'New ApplicationData(
        '   New Uri("http://localhost:50478/ApplicationData.svc/"))

        Dim srvRef As ApplicationData =
        New ApplicationData(
           New Uri(ServiceEndPointURL.Text))

        Dim issue As HelpDeskServiceReference.Issue =
            New HelpDeskServiceReference.Issue()

        issue.Subject = IssueSubject.Text
        issue.CreateDateTime = DateTime.Now
        issue.TargetEndDateTime = DateTime.Now.AddDays(3)
        issue.ProblemDescription = IssueDescription.Text
        Try
            srvRef.AddToIssues(issue)
            srvRef.SaveChanges()
            ConfirmLabel.Text = "Issue Created"
            issue.Subject = ""
            issue.ProblemDescription = ""
        Catch ex As Exception
            ConfirmLabel.Text = ex.Message
        End Try

    End Sub

End Class
