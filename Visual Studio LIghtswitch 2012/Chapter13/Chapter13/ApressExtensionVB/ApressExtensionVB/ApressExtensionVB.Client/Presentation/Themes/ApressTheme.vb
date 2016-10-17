'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System
Imports System.ComponentModel.Composition
Imports Microsoft.LightSwitch.Theming

Namespace Presentation.Themes

    <Export(GetType(ITheme))>
    <Theme(ApressTheme.ThemeId, ApressTheme.ThemeVersion)>
    Friend Class ApressTheme
        Implements ITheme

#Region "ITheme Members"

        Public ReadOnly Property ColorAndFontScheme As Uri Implements ITheme.ColorAndFontScheme
            Get
                Return New Uri("/ApressExtensionVB.Client;component/Presentation/Themes/ApressTheme.xaml", UriKind.Relative)
            End Get
        End Property

        Public ReadOnly Property Id As String Implements ITheme.Id
            Get
            Return ApressTheme.ThemeId
            End Get
        End Property

        Public ReadOnly Property Version As String Implements ITheme.Version
            Get
            Return ApressTheme.ThemeVersion
            End Get
        End Property

#End Region

#Region "Constants"

        Friend Const ThemeId As String = "ApressExtensionVB:ApressTheme"
        Friend Const ThemeVersion As String = "1.0"

#End Region

    End Class

End Namespace