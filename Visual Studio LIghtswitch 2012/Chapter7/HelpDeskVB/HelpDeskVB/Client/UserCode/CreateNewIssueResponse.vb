'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".


Namespace LightSwitchApplication

    Public Class CreateNewIssueResponse

        Private Sub CreateNewIssueResponse_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            ' Write your code here.
            Me.IssueResponseProperty = New IssueResponse()


            'Listing 7-13. Handling the Text Box KeyUp Event 

            Dim control = Me.FindControl("ResponseText")
            AddHandler control.ControlAvailable,
                AddressOf TextBoxAvailable

            ResponseTextCount = 1000

            If IssueId.HasValue Then
                'set the default value
                IssueResponseProperty.Issue =
                    DataWorkspace.ApplicationData.Issues.Where(Function(item) item.Id = IssueId).SingleOrDefault
            End If

        End Sub

        Private Sub TextBoxAvailable(
   sender As Object, e As ControlAvailableEventArgs)
            AddHandler CType(e.Control, 
                System.Windows.Controls.TextBox).KeyUp,
                    AddressOf TextBoxKeyUp
        End Sub

        Private Sub TextBoxKeyUp(
            sender As Object, e As System.Windows.RoutedEventArgs)

            Dim textbox = CType(sender, System.Windows.Controls.TextBox)
            ResponseTextCount = 1000 - textbox.Text.Count()
        End Sub


        Private Sub CreateNewIssueResponse_Saved()
            ' Write your code here.
            Me.Close(False)
            Application.Current.ShowDefaultScreen(Me.IssueResponseProperty)
        End Sub

    End Class

End Namespace