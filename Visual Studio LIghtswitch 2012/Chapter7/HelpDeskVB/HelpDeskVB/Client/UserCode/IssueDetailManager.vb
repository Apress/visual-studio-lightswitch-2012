'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".


Namespace LightSwitchApplication

    Public Class IssueDetailManager

        Private Sub Issue_Loaded(succeeded As Boolean)
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Issue)
        End Sub

        Private Sub Issue_Changed()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Issue)
        End Sub

        Private Sub IssueDetailManager_Saved()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Issue)
        End Sub

        'Listing 4-8. Resolving Conflicts in Code
        Private Sub IssueDetailManager_Saving(ByRef handled As Boolean)

            handled = True

            Try
                Me.DataWorkspace.ApplicationData.SaveChanges()
            Catch ex As ConcurrencyException

                For Each entityConflict In ex.EntitiesWithConflicts.OfType(Of Issue)()
                    entityConflict.Details.EntityConflict.ResolveConflicts(
                       Microsoft.LightSwitch.Details.ConflictResolution.ClientWins)
                Next

                Try
                    Me.DataWorkspace.ApplicationData.SaveChanges()
                    ShowMessageBox(
                       "Your record was modified by another user. Your changes have been kept.")

                Catch ex2 As Exception
                    ' A general exception has occurred 
                    ShowMessageBox(ex2.Message.ToString())
                End Try

            End Try
        End Sub

    End Class

End Namespace