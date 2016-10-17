'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Namespace LightSwitchApplication

    Public Class EngineersManagerGrid

        Private Sub EngineersManagerGrid_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))
            'Listing 7-11. Making Check Boxes Read-Only 
            For Each eng In Engineers
                Me.FindControlInCollection(
                    "SecurityVetted", eng).IsEnabled = False
            Next

        End Sub

    End Class

End Namespace
