'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Namespace LightSwitchApplication

    Public Class Application

        'Listing 17-4. Setting a Screen’s CanRun Method
        Private Sub EngineersManagerGrid_CanRun(ByRef result As Boolean)
            result =    Application.Current.User.HasPermission(Permissions.CanEditEngineers)
        End Sub

        'Listing 17-8. Opening Screens Conditionally
        Private Sub Startup_CanRun(ByRef result As Boolean)
            ' Set result to the desired field value
            If Application.Current.User.HasPermission(Permissions.CanViewAllIssues) Then
                Me.ShowEngineersManagerGrid()
            Else
                Using dw As DataWorkspace = Me.CreateDataWorkspace

                    'This is the code you'd use to find the currently logged on engineer
                    'Dim currentEng As Engineer =
                    '   dw.ApplicationData.Engineers.Where(
                    '      Function(eng) eng.LoginName =
                    '         Application.Current.User.Name).FirstOrDefault()
                    'If currentEng IsNot Nothing Then
                    '    Me.ShowEngineerDashboard(currentEng.Id)
                    'End If

                    Me.ShowEngineerDashboard(dw.ApplicationData.Engineers.FirstOrDefault().Id)

                End Using
            End If

            Me.ShowInfo()
            result = False
        End Sub
    End Class

End Namespace
