'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.Windows.Data

Namespace LightSwitchApplication

    Public Class CreateNewOffice

        Private Sub CreateNewOffice_InitializeDataWorkspace(ByVal saveChangesTo As Global.System.Collections.Generic.List(Of Global.Microsoft.LightSwitch.IDataService))
            ' Write your code here.
            Me.OfficeProperty = New Office()
        End Sub

        Private Sub CreateNewOffice_Saved()
            ' Write your code here.
            Me.Close(False)
            Application.Current.ShowDefaultScreen(Me.OfficeProperty)
        End Sub

        Private Sub CreateNewOffice_Activated()
            'Listing 11-4. Data-Binding the Slider Control
            Dim buildingCapacity As IContentItemProxy =
                   Me.FindControl("BuildingCapacity")
            Dim converter As New IntToDoubleConverter
            buildingCapacity.SetBinding(
                Slider.ValueProperty,
                "Value",
                converter,
                BindingMode.TwoWay)

        End Sub

    End Class

End Namespace