'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Namespace LightSwitchApplication

    Public Class AppOptionsEdit

        '7-19. Creating a Screen That works only with the First record
        Private Sub AppOptionsEdit_InitializeDataWorkspace(
            saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            Me.AppOptionProperty =
                DataWorkspace.ApplicationData.AppOptions.FirstOrDefault()
            If AppOptionProperty Is Nothing Then
                AppOptionProperty = New AppOption
            End If
        End Sub

        Private Sub AppOptionsEdit_Saved()
            ' Write your code here.
            Me.Close(False)
            Application.Current.ShowDefaultScreen(Me.AppOptionProperty)
        End Sub

    End Class

End Namespace