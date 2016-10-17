'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.Windows.Data

'Listing 11-3. Value Converter Code
Public Class IntToDoubleConverter
    Implements IValueConverter

    Public Function Convert(
        value As Object,
        targetType As System.Type,
        parameter As Object,
        culture As System.Globalization.CultureInfo
    ) As Object Implements System.Windows.Data.IValueConverter.Convert

        Return CDbl(value)
    End Function

    Public Function ConvertBack(
        value As Object,
        targetType As System.Type,
        parameter As Object,
        culture As System.Globalization.CultureInfo
    ) As Object Implements System.Windows.Data.IValueConverter.ConvertBack

        Return CInt(value)
    End Function

End Class

