'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Namespace LightSwitchApplication

    Public Class Info

        Private Sub Info_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))

        End Sub

        Private Sub Info_Activated()
            ' Write your code here.
            If Application.Current.User.HasPermission(Permissions.CanViewAllIssues) Then
                Me.FindControl("ManagerGroup").IsVisible = True
                Me.FindControl("NonManagerGroup").IsVisible = False
            Else
                Me.FindControl("ManagerGroup").IsVisible = False
                Me.FindControl("NonManagerGroup").IsVisible = True
            End If

        End Sub
    End Class

End Namespace
