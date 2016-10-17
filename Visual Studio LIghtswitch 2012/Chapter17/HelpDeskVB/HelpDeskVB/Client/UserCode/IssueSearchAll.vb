'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Namespace LightSwitchApplication

    Public Class IssueSearchAll

        'Listing 7-10. Hiding and Showing Controls 
        Private Sub ToggleVisibility_Execute()
            Dim rowLayout = Me.FindControl("AdvancedGroup")
            rowLayout.IsVisible = Not (rowLayout.IsVisible)
            If rowLayout.IsVisible Then
                Me.FindControl("ToggleVisibility").DisplayName =
                   "Hide Simple Filters"
            Else
                Me.FindControl("ToggleVisibility").DisplayName =
                   "Show Advanced Filters"
            End If
        End Sub

        'Listing 7-16. Controlling the Custom Modal Window

        Private Sub AddItem_Execute()
            Issues.AddNew()
            Me.OpenModalWindow("IssueWindow")
        End Sub

        Private Sub EditItem_Execute()
            Me.OpenModalWindow("IssueWindow")
        End Sub

        Private Sub SaveItem_Execute()
            Me.CloseModalWindow("IssueWindow")
        End Sub

        Private Sub CancelItem_Execute()
            CType(Issues.SelectedItem, Issue).Details.DiscardChanges()
            Me.CloseModalWindow("IssueWindow")
        End Sub


        'Listing 17-10. Modifying Screen Controls by Permission
        Private Sub IssueSearchAll_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            ' Write your code here.
            If Not Application.User.HasPermission(Permissions.CanViewAllIssues) Then

                'This code determines the logged in user
                'Dim currentEng As Engineer =
                '    DataWorkspace.ApplicationData.Engineers.Where(
                '       Function(eng) eng.LoginName = Application.User.Name).FirstOrDefault

                'If currentEng IsNot Nothing Then
                '    EngineerSelectionProperty = currentEng
                '    Me.FindControl("EngineerSelectionProperty").IsEnabled = False
                'End If

                EngineerSelectionProperty = DataWorkspace.ApplicationData.Engineers.FirstOrDefault()
                Me.FindControl("EngineerSelectionProperty").IsEnabled = False

            End If

        End Sub

    End Class

End Namespace
