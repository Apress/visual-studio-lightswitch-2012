'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

'Listing 12-20. SilverlightEntityPropertyDropdownEditor Class

Imports System.ComponentModel.Composition
Imports System.Windows
Imports System.Windows.Markup
Imports Microsoft.LightSwitch.Designers.PropertyPages
Imports Microsoft.LightSwitch.RuntimeEdit

Namespace ApressExtensionVB.Editors

    <Export(GetType(IPropertyValueEditorProvider))>
    <PropertyValueEditorName("EntityPropertyDropdown")>
    <PropertyValueEditorType("System.String")>
    Public Class SilverlightEntityPropertyDropdownEditor
        Implements IPropertyValueEditorProvider

        Public Function GetEditor(entry As IPropertyEntry) As IPropertyValueEditor Implements IPropertyValueEditorProvider.GetEditor
            Return New Editor()
        End Function

        Private Class Editor
            Implements IPropertyValueEditor
            Public Function GetEditorTemplate(entry As IPropertyEntry) As DataTemplate Implements IPropertyValueEditor.GetEditorTemplate
                Return XamlReader.Load(
                   SilverlightEntityPropertyDropdownEditor.ControlTemplate)
            End Function

        End Class

        Private Const ControlTemplate As String =
            "<DataTemplate" +
            " xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""" +
            " xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml""" +
            " xmlns:editors=""clr-namespace:ApressExtensionVB.Editors;assembly=ApressExtensionVB.Client.Design"">" +
            "   <editors:SilverlightEntityPropertyDropdown/>" +
            "</DataTemplate>"

    End Class
End Namespace
