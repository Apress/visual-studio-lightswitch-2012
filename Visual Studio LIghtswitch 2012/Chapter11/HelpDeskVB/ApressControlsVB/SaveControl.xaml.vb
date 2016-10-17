'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

'Listing 11-11. Code to Call a Screen Method Called SaveData
Imports Microsoft.LightSwitch.Presentation

Partial Public Class SaveControl
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub CustomButton_Click(
    sender As System.Object, e As System.Windows.RoutedEventArgs)

        ' Get a reference to the LightSwitch Screen
        Dim objDataContext = DirectCast(Me.DataContext, IContentItem)
        Dim clientScreen = DirectCast(
            objDataContext.Screen, Microsoft.LightSwitch.Client.IScreenObject)

        Me.CustomButton1.IsEnabled = False

        clientScreen.Details.Dispatcher.BeginInvoke(
            Sub()
                Try
                    ' Call the Method on the LightSwitch screen
                    clientScreen.Details.Commands.Item("SaveData").Execute()
                Finally
                    SetEnabled()
                End Try
            End Sub)

    End Sub

    Private Sub SetEnabled()
        Me.Dispatcher.BeginInvoke(
            Sub()
                Me.CustomButton1.IsEnabled = True
            End Sub
        )
    End Sub

End Class
