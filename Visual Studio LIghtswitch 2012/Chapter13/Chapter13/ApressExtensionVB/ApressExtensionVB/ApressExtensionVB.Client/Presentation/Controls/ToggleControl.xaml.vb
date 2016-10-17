'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.Composition
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports System.Windows.Resources

Imports Microsoft.LightSwitch.Presentation

Namespace Presentation.Controls

    Partial Public Class ToggleControl
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub ToggleButton_Click(sender As Object, e As RoutedEventArgs)
            If ContentPanel.Visibility = Windows.Visibility.Visible Then
                ContentPanel.Visibility = Windows.Visibility.Collapsed
                ToggleButton.Content = "Show"
            Else
                ContentPanel.Visibility = Windows.Visibility.Visible
                ToggleButton.Content = "Hide"
            End If
        End Sub



    End Class

    <Export(GetType(IControlFactory))>
    <ControlFactory("ApressExtensionVB:ToggleControl")>
    Friend Class ToggleControlFactory
        Implements IControlFactory

#Region "IControlFactory Members"

        Public ReadOnly Property DataTemplate As DataTemplate Implements IControlFactory.DataTemplate
            Get
                If Me.cachedDataTemplate Is Nothing Then
                    Me.cachedDataTemplate = TryCast(XamlReader.Load(ToggleControlFactory.ControlTemplate), DataTemplate)
                End If
                Return Me.cachedDataTemplate
            End Get
        End Property

        Public Function GetDisplayModeDataTemplate(ByVal contentItem As IContentItem) As DataTemplate Implements IControlFactory.GetDisplayModeDataTemplate
            Return Nothing
        End Function

#End Region

#Region "Private Fields"

        Private cachedDataTemplate As DataTemplate

#End Region

#Region "Constants"

        Private Const ControlTemplate As String =
            "<DataTemplate" & _
            " xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""" & _
            " xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml""" & _
            " xmlns:ctl=""clr-namespace:ApressExtensionVB.Presentation.Controls;assembly=ApressExtensionVB.Client"">" & _
            "<ctl:ToggleControl/>" & _
            "</DataTemplate>"

#End Region

    End Class

End Namespace