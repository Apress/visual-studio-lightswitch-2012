'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

'Listing 11-9. WebBrowser Control .NET Code
Partial Public Class WebBrowser
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    '1 Code that registers the Dependency Property
    Public Shared ReadOnly URIProperty As DependencyProperty =
        DependencyProperty.Register(
            "uri",
            GetType(Uri),
            GetType(WebBrowser),
            New PropertyMetadata(Nothing, AddressOf OnUriPropertyChanged))

    Public Property uri() As Uri
        Get
            Return DirectCast(GetValue(URIProperty), Uri)
        End Get
        Set(value As Uri)
            SetValue(URIProperty, value)
        End Set
    End Property

    '2 Code that runs when the underlying URL changes
    Private Shared Sub OnUriPropertyChanged(
        re As DependencyObject, e As DependencyPropertyChangedEventArgs)

        If e.NewValue IsNot Nothing Then
            Dim web As WebBrowser =
               DirectCast(re, WebBrowser)
            web.wb.Navigate(DirectCast(e.NewValue, Uri))
        End If
    End Sub

End Class