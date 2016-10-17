'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System
Imports System.ComponentModel.Composition
Imports System.Runtime.InteropServices
Imports System.Windows
Imports System.Windows.Input
Imports System.Windows.Interop
Imports Microsoft.LightSwitch.Designers.PropertyPages
Imports Microsoft.LightSwitch.Designers.PropertyPages.UI

Public Class MaxIntegerEditor
    Implements IPropertyValueEditor

    Public Sub New(entry As IPropertyEntry)
        Me.command = New EditCommand(entry)
    End Sub

    Private command As ICommand

    Public ReadOnly Property Context As Object Implements IPropertyValueEditor.Context
        Get
            Return Me.command
        End Get
    End Property

    Public Function GetEditorTemplate(entry As IPropertyEntry) As DataTemplate Implements IPropertyValueEditor.GetEditorTemplate
        Dim dict As ResourceDictionary = New ResourceDictionary()
        dict.Source =
           New Uri("ApressExtensionVB.Design;component/EditorTemplates.xaml",
              UriKind.Relative)
        Return dict("MaxIntegerEditorTemplate")
    End Function

    Private Class EditCommand
        Implements ICommand

        Public Sub New(entry As IPropertyEntry)
            Me.entry = entry
        End Sub

        Private entry As IPropertyEntry

        Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
            Return True
        End Function

        Public Event CanExecuteChanged(sender As Object,
           e As System.EventArgs) Implements ICommand.CanExecuteChanged

        Public Sub Execute(parameter As Object) Implements ICommand.Execute

            Dim dialog As MaxIntegerEditorDialog = New MaxIntegerEditorDialog()
            dialog.Value = Me.entry.PropertyValue.Value
            ' Set the parent window of your dialog box to the IDE window; 
            ' this ensures the win32 window stack works correctly.
            Dim wih As WindowInteropHelper = New WindowInteropHelper(dialog)
            wih.Owner = GetActiveWindow()
            dialog.ShowDialog()
            Me.entry.PropertyValue.Value = dialog.Value

        End Sub

        'GetActiveWindow is a Win32 method; import the method to get the 
        ' IDE window
        Declare Function GetActiveWindow Lib "User32" () As IntPtr

    End Class

End Class

<Export(GetType(IPropertyValueEditorProvider))>
<PropertyValueEditorName(
    "ApressExtension:@MaxDurationWindow")>
<PropertyValueEditorType("System.String")>
Friend Class MaxIntegerEditorProvider
    Implements IPropertyValueEditorProvider

    Public Function GetEditor(entry As IPropertyEntry) As IPropertyValueEditor Implements IPropertyValueEditorProvider.GetEditor
        Return New MaxIntegerEditor(entry)
    End Function

End Class
