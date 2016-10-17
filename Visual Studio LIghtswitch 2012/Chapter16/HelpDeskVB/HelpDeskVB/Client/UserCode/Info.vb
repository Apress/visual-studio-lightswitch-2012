Imports Microsoft.LightSwitch.Threading
Imports System.Windows.Browser
Imports Microsoft.LightSwitch.Security


Namespace LightSwitchApplication

    Public Class Info

        'Listing 16-2. Execution Code for the Logout Button
        Private Sub Logout_Execute()
            Dispatchers.Main.Invoke(
               Sub()
                   HtmlPage.Window.Navigate(
                      New Uri("LogOff.aspx", UriKind.Relative))
               End Sub)
        End Sub

        Private Sub Logout_CanExecute(ByRef result As Boolean)

            Dim logoutCanExecute As Boolean
            Dispatchers.Main.Invoke(
               Sub()
                   logoutCanExecute =
                      (System.Windows.Application.Current.IsRunningOutOfBrowser =
                           False) AndAlso
                       (Application.Current.User.AuthenticationType =
                           AuthenticationType.Forms)
               End Sub)

            result = logoutCanExecute

        End Sub

    End Class

End Namespace
