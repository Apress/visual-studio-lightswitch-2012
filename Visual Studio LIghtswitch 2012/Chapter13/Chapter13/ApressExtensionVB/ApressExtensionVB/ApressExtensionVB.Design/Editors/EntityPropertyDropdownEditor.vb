Imports System.ComponentModel.Composition
Imports System.Windows
Imports System.Windows.Markup
Imports Microsoft.LightSwitch.Designers.PropertyPages
Imports Microsoft.LightSwitch.Designers.PropertyPages.UI

Namespace ApressExtensionVB.Editors

    <Export(GetType(IPropertyValueEditorProvider))>
    <PropertyValueEditorName("EntityPropertyDropdown")>
    <PropertyValueEditorType("System.String")>
    Public Class EntityPropertyDropdownEditorProvider
        Implements IPropertyValueEditorProvider

        Public Function GetEditor(entry As IPropertyEntry) As IPropertyValueEditor Implements IPropertyValueEditorProvider.GetEditor
            Return New Editor()
        End Function

        Private Class Editor
            Implements IPropertyValueEditor

            ' The screen designer calls this method to create the UI control on
            ' the property sheet.
            Public Function GetEditorTemplate(entry As IPropertyEntry) As System.Windows.DataTemplate Implements IPropertyValueEditor.GetEditorTemplate
                Return XamlReader.Parse(EntityPropertyDropdownEditorProvider.ControlTemplate)
            End Function

            Public ReadOnly Property Context As Object Implements IPropertyValueEditor.Context
                Get
                    Return Nothing
                End Get
            End Property

        End Class

#Region "Constants"
        Private Const ControlTemplate As String =
            "<DataTemplate" +
            " xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""" +
            " xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml""" +
            " xmlns:editors=""clr-namespace:ApressExtensionVB.Editors;assembly=ApressExtensionVB.Design"">" +
            "   <editors:EntityPropertyDropdown/>" +
            "</DataTemplate>"
#End Region

    End Class

End Namespace
