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
        End Sub

        Private Sub CreateNewIssue_Saved()
            ' Write your code here.
            Me.Close(False)
            Application.Current.ShowDefaultScreen(Me.IssueProperty)
        End Sub

        Private Sub CreateNewIssue_Activated()

            'Listing 11-2. Data-Binding a ComboBox Control 
            Dim comboControl As IContentItemProxy = Me.FindControl("Priority2")
            comboControl.SetBinding(
                  System.Windows.Controls.ComboBox.ItemsSourceProperty,
                  "Screen.Priorities",
                  Windows.Data.BindingMode.OneWay)

            comboControl.SetBinding(
            System.Windows.Controls.ComboBox.SelectedItemProperty,
            "Screen.IssueProperty.Priority",
            Windows.Data.BindingMode.TwoWay)

        End Sub
    End Class

End Namespace