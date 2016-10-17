'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".


Namespace LightSwitchApplication

    Public Class IssuesManagerGrid


        'Listing 7-17. Bulk- Cclosing Mmultiple Rrecords

        Private WithEvents _datagridControl As DataGrid = Nothing

        Private Sub IssuesManagerGrid_Created()
            '  1 Replace grid with the name of your data grid control                      
            AddHandler Me.FindControl("grid").ControlAvailable,
                Sub(send As Object, e As ControlAvailableEventArgs)
            _datagridControl = TryCast(e.Control, DataGrid)
            _datagridControl.SelectionMode =
                DataGridSelectionMode.Extended
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
