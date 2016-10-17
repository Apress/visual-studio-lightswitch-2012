'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.Windows.Data
Imports System.Globalization
Imports Microsoft.LightSwitch
Imports System.Text

Namespace Presentation.Shells

    Public Class WorkspaceDirtyConverter
        Implements IValueConverter

        Public Function Convert(value As Object, targetType As Type,
           parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
            Return If(CType(value, Boolean),
              Visibility.Visible, Visibility.Collapsed)
        End Function

        Public Function ConvertBack(value As Object, targetType As Type,
           parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotSupportedException()
        End Function

    End Class

    Public Class ScreenHasErrorsConverter
        Implements IValueConverter

        Public Function Convert(value As Object, targetType As Type,
           parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
            Return If(CType(value, Boolean),
               Visibility.Visible, Visibility.Collapsed)
        End Function

        Public Function ConvertBack(value As Object, targetType As Type,
           parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotSupportedException()
        End Function

    End Class

    Public Class ScreenResultsConverter
        Implements IValueConverter

        Public Function Convert(value As Object, targetType As Type,
           parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert

            Dim results As ValidationResults = value
            Dim sb As StringBuilder = New StringBuilder()
            For Each result As ValidationResult In results.Errors
                sb.Append(String.Format("Errors: {0}", result.Message))
            Next
            Return sb.ToString()
        End Function

        Public Function ConvertBack(value As Object, targetType As Type,
           parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotSupportedException()
        End Function

    End Class

    Public Class CurrentUserConverter
        Implements IValueConverter

        Public Function Convert(value As Object, targetType As Type,
           parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim currentUser As String = value

            If currentUser Is Nothing OrElse currentUser.Length = 0 Then
                Return "Authentication is not enabled."
            End If

            Return currentUser
        End Function

        Public Function ConvertBack(value As Object, targetType As Type,
           parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotSupportedException()
        End Function

    End Class

End Namespace

