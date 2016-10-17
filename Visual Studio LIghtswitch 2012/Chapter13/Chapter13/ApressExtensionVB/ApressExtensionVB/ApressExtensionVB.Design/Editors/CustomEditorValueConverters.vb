'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System
Imports System.Globalization
Imports System.Windows.Data
Imports Microsoft.LightSwitch.Model

Namespace Editors

    ' This appends ':' to the end of the property name label
    Public Class AppendSemiColonConverter
        Implements IValueConverter

        Public Function Convert(value As Object, targetType As System.Type,
            parameter As Object, culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.Convert

            If value IsNot Nothing Then
                Return String.Format(CultureInfo.CurrentCulture, "{0}:", value)
            End If
            Return String.Empty

        End Function

        Public Function ConvertBack(value As Object, targetType As System.Type,
           parameter As Object, culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.ConvertBack
            Throw New NotSupportedException()
        End Function

    End Class

    ' This gets a collection of property names for an entity type and the result
    ' inclues an entry that contains an empty string. 
    ' The return value fills the values in the ComboBox.
    Public Class GetAllEntityPropertiesConverter
        Implements IValueConverter

        Public Function Convert(value As Object, targetType As System.Type,
            parameter As Object, culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.Convert

            Dim textProperties As List(Of String) = New List(Of String)()

            textProperties.Add(String.Empty)

            Dim contentItemDefinition As IContentItemDefinition =
              TryCast(value, IContentItemDefinition)
            If contentItemDefinition IsNot Nothing Then
                Dim entityType As IEntityType =
                    TryCast(contentItemDefinition.DataType, IEntityType)
                If entityType IsNot Nothing Then
                    For Each p As IPropertyDefinition In
                       CustomEditorHelper.GetTextPropertiesForEntity(entityType)
                        textProperties.Add(p.Name)
                    Next
                End If
            End If
            Return textProperties

        End Function

        Public Function ConvertBack(value As Object, targetType As System.Type,
           parameter As Object, culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.ConvertBack
            Throw New NotSupportedException()
        End Function

    End Class

    ' If the developer hasn't entered a display name, this converts the dislay 
    ' text of the empty value to '<Summmary>' 
    Public Class EmptyStringToSummaryConverter
        Implements IValueConverter

        Public Function Convert(value As Object, targetType As System.Type,
           parameter As Object, culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.Convert

            If TypeOf value Is String AndAlso
                String.IsNullOrEmpty(DirectCast(value, String)) Then
                Return "<Summary>"
            End If
            Return value

        End Function

        Public Function ConvertBack(value As Object, targetType As System.Type,
            parameter As Object, culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.ConvertBack
            Throw New NotSupportedException()
        End Function

    End Class

End Namespace
