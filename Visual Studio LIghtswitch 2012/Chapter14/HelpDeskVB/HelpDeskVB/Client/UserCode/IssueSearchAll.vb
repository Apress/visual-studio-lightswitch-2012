'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, Pro LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".



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



    End Class

End Namespace
