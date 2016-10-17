'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports Microsoft.LightSwitch

Namespace LightSwitchApplication

    Public Class AppOptionEdit

        Private Sub AppOptionEdit_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))

            Me.AppOptionProperty =
                DataWorkspace.ApplicationData.AppOptions.FirstOrDefault()

            If AppOptionProperty Is Nothing Then
                AppOptionProperty = New AppOption
            End If

            'Listing 11-1. Calling the SetBinding Method
            Dim password = Me.FindControl("SMTPPassword")
            password.SetBinding(
                System.Windows.Controls.PasswordBox.PasswordProperty,
               "Value",
               Windows.Data.BindingMode.TwoWay)

        End Sub

        Private Sub AppOptionEdit_Activated()
            ' Bind the web browser control here
            Dim reportingSrv As IContentItemProxy =
               Me.FindControl("AppOptionProperty_ReportingServicesURL")
            reportingSrv.SetBinding(
                ApressControlsVB.WebBrowser.URIProperty,
                "Value",
                Windows.Data.BindingMode.OneWay)
        End Sub

    End Class

End Namespace