'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.Windows.Controls
Imports System.Windows.Data

Namespace LightSwitchApplication

    Public Class EngineerListReport

        Private Sub EngineerListReport_Created()
            ' Listing 14-7. Showing a Web Page on a LightSwitch List and Details Screen 
            Dim control = Me.FindControl("Id")
            Dim converter As New IdToReportUrlConverter()

            'converter.RootURL = "http://localhost:57290/reports/"
            converter.RootURL = DataWorkspace.ApplicationData.AppOptions.FirstOrDefault().ReportServer.ToString()

            control.SetBinding(
                ApressControlsVB.WebBrowser.URIProperty,
                "Value", converter, BindingMode.OneWay)

        End Sub

    End Class

End Namespace

' Listing 14-7. Showing a Web Page on a LightSwitch List and Details Screen 
'Add this after the 'End Class' for your 'EngineerListReport' Class
Public Class IdToReportUrlConverter
    Implements IValueConverter

    Private _rootURL As String
    Public Property RootURL As String
        Get
            Return _rootURL
        End Get
        Set(value As String)
            _rootURL = value
        End Set
    End Property

    Public Function Convert(
    value As Object,
    targetType As System.Type,
    parameter As Object,
    culture As System.Globalization.CultureInfo
) As Object Implements System.Windows.Data.IValueConverter.Convert

        If value IsNot Nothing Then
            'Return New Uri(                                                     
            '"http://localhost:7290/reports/IssuesByEngineer.aspx?EngineerId=" &
            '   value.ToString)

            Return New Uri(
               _rootURL & "/IssuesByEngineer.aspx?EngineerId=" &
                  value.ToString)
        Else
            Return Nothing
        End If
    End Function

    Public Function ConvertBack(
    value As Object,
    targetType As System.Type,
    parameter As Object,
    culture As System.Globalization.CultureInfo
) As Object Implements System.Windows.Data.IValueConverter.ConvertBack

        Return New NotImplementedException
    End Function

End Class


Namespace UserCode

    Public Class EngineerListReport

    End Class

End Namespace
