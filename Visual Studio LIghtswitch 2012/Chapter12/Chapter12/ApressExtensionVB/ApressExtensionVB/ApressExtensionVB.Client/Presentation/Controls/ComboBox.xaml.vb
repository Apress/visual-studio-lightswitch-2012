'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

'Listing 12-10. ComboBox Code File 

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
Imports System.Windows.Data

Imports Microsoft.LightSwitch.Model

Namespace Presentation.Controls

    Partial Public Class ComboBox
        Inherits UserControl

        Public Sub New()
            InitializeComponent()

            MyBase.SetBinding(ComboBox.ComboDisplayItemProperty,
              New Binding("Properties[ApressExtensionVB:ComboBox/ComboDisplayItemProperty]"))

            MyBase.SetBinding(ComboBox.ComboBoxQueryProperty,
                              New Binding("Properties[ApressExtensionVB:ComboBox/ComboQueryProperty]"))

            MyBase.SetBinding(ComboBox.ContentItemProperty, New Binding())
        End Sub

#Region "2. DEFINE DEPENDENCY PROPERTIES"

        Public Property ComboDisplayItem As String
            Get
                Return MyBase.GetValue(ComboBox.ComboDisplayItemProperty)
            End Get
            Set(value As String)
                MyBase.SetValue(ComboBox.ComboDisplayItemProperty, value)
            End Set
        End Property

        Public Shared ReadOnly ComboDisplayItemProperty As DependencyProperty =
            DependencyProperty.Register(
               "ComboDisplayItem", GetType(String), GetType(ComboBox),
               New PropertyMetadata(AddressOf ComboBox.ComboDisplayItemChanged))

        Public Property ComboBoxQuery As String
            Get
                Return MyBase.GetValue(ComboBox.ComboBoxQueryProperty)
            End Get
            Set(value As String)
                MyBase.SetValue(ComboBox.ComboBoxQueryProperty, value)
            End Set
        End Property

        Public Shared ReadOnly ComboBoxQueryProperty As DependencyProperty =
            DependencyProperty.Register(
               "ComboBoxQuery", GetType(String), GetType(ComboBox),
               New PropertyMetadata(AddressOf ComboBox.ComboBoxQueryChanged))

#End Region

#Region "3. HANDLE PROPERTY SHEET CHANGES"
        Private Shared Sub ComboBoxQueryChanged(d As DependencyObject,
           e As DependencyPropertyChangedEventArgs)
            CType(d, ComboBox).SetComboContentDataBinding()
        End Sub

        Private Shared Sub ComboDisplayItemChanged(d As DependencyObject,
           e As DependencyPropertyChangedEventArgs)
            CType(d, ComboBox).SetContentDataBinding()
        End Sub

        Public Property ContentItem As IContentItem
            Get
                Return MyBase.GetValue(ComboBox.ContentItemProperty)
            End Get
            Set(value As IContentItem)
                MyBase.SetValue(ComboBox.ContentItemProperty, value)
            End Set
        End Property

        Public Shared ReadOnly ContentItemProperty As DependencyProperty =
            DependencyProperty.Register("ContentItem",
                GetType(IContentItem), GetType(ComboBox),
                New PropertyMetadata(AddressOf ComboBox.ComboDisplayItemChanged))


        ' Original SetContentDataBinding Code
        'Private Sub SetContentDataBinding()

        '    If Not String.IsNullOrEmpty(Me.ComboDisplayItem) Then
        '        Dim str = "<DataTemplate xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""> <TextBlock Text=""{Binding " & Me.ComboDisplayItem & "}"" /> </DataTemplate>"

        '        Combo.ItemTemplate =
        '            CType(XamlReader.Load(str), DataTemplate)

        '        Dim selectedBinding As New Data.Binding("Value")
        '        selectedBinding.Mode = BindingMode.TwoWay
        '        Combo.SetBinding(
        '           System.Windows.Controls.ComboBox.SelectedValueProperty,
        '           selectedBinding)

        '    End If

        'End Sub

        ' Listing 12-12. ComboBox Control Code  
        Private Sub SetContentDataBinding()
            If ContentItem IsNot Nothing Then

                Dim entityType As IEntityType = ContentItem.ResultingDataType

                If entityType IsNot Nothing Then

                    Dim displayProperty As String = Me.ComboDisplayItem

                    If String.IsNullOrEmpty(displayProperty) Then
                        displayProperty =
                           CustomEditorHelper.GetSummaryProperty(entityType).Name
                    End If

                    If Not String.IsNullOrEmpty(displayProperty) Then
                        Dim str = "<DataTemplate  xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""> <TextBlock Text=""{Binding " & displayProperty & "}"" /> </DataTemplate>"

                        Combo.ItemTemplate =
                            CType(XamlReader.Load(str), DataTemplate)

                        Dim selectedBinding As New Data.Binding("Value")
                        selectedBinding.Mode = BindingMode.TwoWay
                        Combo.SetBinding(
                          System.Windows.Controls.ComboBox.SelectedValueProperty,
                          selectedBinding)

                    End If
                End If

            End If
        End Sub

        Private Sub SetComboContentDataBinding()
            If Not String.IsNullOrEmpty(Me.ComboBoxQuery) Then
                Dim dataSourceBinding As New Data.Binding(Me.ComboBoxQuery)
                dataSourceBinding.Mode = BindingMode.OneTime
                Combo.SetBinding(
                    System.Windows.Controls.ComboBox.ItemsSourceProperty,
                    dataSourceBinding)
            End If
        End Sub

#End Region

    End Class

    <Export(GetType(IControlFactory))>
    <ControlFactory("ApressExtensionVB:ComboBox")>
    Friend Class ComboBoxFactory
        Implements IControlFactory

#Region "IControlFactory Members"

        Public ReadOnly Property DataTemplate As DataTemplate Implements IControlFactory.DataTemplate
            Get
                If Me.cachedDataTemplate Is Nothing Then
                    Me.cachedDataTemplate = TryCast(XamlReader.Load(ComboBoxFactory.ControlTemplate), DataTemplate)
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
            "<ctl:ComboBox/>" & _
            "</DataTemplate>"

#End Region

    End Class

End Namespace