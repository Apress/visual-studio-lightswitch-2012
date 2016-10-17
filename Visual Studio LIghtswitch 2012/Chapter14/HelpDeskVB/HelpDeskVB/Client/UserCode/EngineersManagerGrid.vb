'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.Runtime.InteropServices.Automation
Imports System.Windows.Browser

Namespace LightSwitchApplication

    Public Class EngineersManagerGrid

        Private Sub ViewDashboard_Execute()

            ' Listing 7-4. Opening Screens from a Data Grid Command
            Application.ShowEngineerDashboard(
                Engineers.SelectedItem.Id)

        End Sub

        Private Sub EngineersManagerGrid_InitializeDataWorkspace(saveChangesTo As List(Of Microsoft.LightSwitch.IDataService))

            'Listing 7-11. Making Check Boxes Read-Only 
            For Each eng In Engineers
                Me.FindControlInCollection(
                    "SecurityVetted", eng).IsEnabled = False
            Next

            'Build a URL that points to the EngineerIssueReportURL
            '"http://localhost/Reporting/IssuesByEngineer.aspx?EngineerId={0}"
            EngineerIssueReportURL =
                Me.DataWorkspace.ApplicationData.AppOptions.FirstOrDefault().ReportServer.ToString() &
                "/IssuesByEngineer.aspx?EngineerId={0}"

        End Sub

        Private Sub OpenEngineerIssueReport_Execute()

            'Listing 14-5. Opening Reports in a New Browser Window
            'Dim urlPath = String.Format(
            '    "http://localhost/Reporting/IssuesByEngineer.aspx?EngineerId={0}",
            '    Engineers.SelectedItem.Id)

            Dim urlPath = String.Format(
                EngineerIssueReportURL,
                Engineers.SelectedItem.Id)

            If AutomationFactory.IsAvailable Then
                Dim shell = AutomationFactory.CreateObject("Shell.Application")
                shell.ShellExecute(urlPath, "", "", "open", 1)
            Else
                HtmlPage.Window.Invoke(urlPath)
            End If

        End Sub

    End Class

End Namespace
