'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Namespace LightSwitchApplication

    Public Class IssuesManagerGrid

        'Listing 7-17. Bulk- Closing Multiple Records

        Private WithEvents _datagridControl As DataGrid = Nothing

        Private Sub IssuesManagerGrid_Created()
            '  1 Replace grid with the name of your data grid control                      
            AddHandler Me.FindControl("grid").ControlAvailable,
                Sub(send As Object, e As ControlAvailableEventArgs)
                    _datagridControl = TryCast(e.Control, DataGrid)
                    _datagridControl.SelectionMode =
                        DataGridSelectionMode.Extended
                End Sub

            'Build a URL that looks like this..
            '"http://localhost/reporting/StatusChart.aspx"
            ChartReportURL =
                Me.DataWorkspace.ApplicationData.AppOptions.FirstOrDefault().ReportServer.ToString() &
                "/StatusChart.aspx"

            'Listing 14-6. Showing a Web Page on a LightSwitch Details Screen 
            Dim control = Me.FindControl("ReportProperty")
            AddHandler control.ControlAvailable,
                Sub(send As Object, e As ControlAvailableEventArgs)
                    DirectCast(e.Control, WebBrowser).Navigate(
                        New Uri(ChartReportURL))
                End Sub

            'Reporting Services Example
            ChartReportURL2 =
                Me.DataWorkspace.ApplicationData.AppOptions.FirstOrDefault().ReportServer.ToString() &
                "/IssuesByDepartment.aspx"
            Dim control2 = Me.FindControl("ReportProperty2")
            AddHandler control2.ControlAvailable,
                Sub(send As Object, e As ControlAvailableEventArgs)
                    DirectCast(e.Control, WebBrowser).Navigate(
                        New Uri(ChartReportURL2))
                End Sub

        End Sub

        Private Sub CancelSelectedIssues_Execute()

            Dim closedStatus = DataWorkspace.ApplicationData.IssueStatusSet.Where(
                Function(i) i.StatusDescription = "Closed").FirstOrDefault

            Dim closedEng = DataWorkspace.ApplicationData.Engineers.Where(
                Function(e) e.LoginName = Application.User.Identity.Name).FirstOrDefault

            For Each item As Issue In _datagridControl.SelectedItems

                item.IssueStatus = closedStatus
                item.ClosedByEngineer = closedEng
                item.ClosedDateTime = Date.Now
            Next
        End Sub


    End Class

End Namespace
