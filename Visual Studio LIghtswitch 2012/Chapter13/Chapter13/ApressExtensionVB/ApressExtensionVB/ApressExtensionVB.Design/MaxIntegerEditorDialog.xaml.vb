Imports System.Windows

Public Class MaxIntegerEditorDialog
    Inherits Window

    Public Property Value As Nullable(Of Integer)
        Get
            Return MyBase.GetValue(MaxIntegerEditorDialog.ValueProperty)
        End Get
        Set(value As Nullable(Of Integer))
            MyBase.SetValue(MaxIntegerEditorDialog.ValueProperty, value)
        End Set
    End Property

    Public Shared ReadOnly ValueProperty As DependencyProperty =
        DependencyProperty.Register(
            "Value",
            GetType(Nullable(Of Integer)),
            GetType(MaxIntegerEditorDialog),
            New UIPropertyMetadata(0))

    Public Sub New()
        InitializeComponent()
    End Sub

End Class
