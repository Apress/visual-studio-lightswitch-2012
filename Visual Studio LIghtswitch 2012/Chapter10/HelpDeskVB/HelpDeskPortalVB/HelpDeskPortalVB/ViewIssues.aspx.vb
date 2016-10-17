'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports HelpDeskPortalVB.HelpDeskServiceReference

Public Class ViewIssues
    Inherits System.Web.UI.Page

    'Listing 10-4. Web Form Code That Populates a Grid View 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim srvRef As ApplicationData =
        'New ApplicationData(New Uri("http://localhost/HelpDesk/ApplicationData.svc/"))
        'srvRef.Credentials = New Net.NetworkCredential("administrator", "password")
        'Dim issues = srvRef.Issues.Where(Function(i) i.User.Username = "timl")
        'IssuesGrid.DataSource = issues
        'IssuesGrid.DataBind()
    End Sub

    Protected Sub GetIssues_Click(sender As Object, e As EventArgs) Handles GetIssues.Click
        Dim srvRef As ApplicationData =
        New ApplicationData(
           New Uri(ServiceEndPointURL.Text))

        Dim issues = srvRef.Issues.OrderByDescending(Function(a) a.Id).Take(100)
        IssuesGrid.DataSource = issues
        IssuesGrid.DataBind()
    End Sub

End Class


