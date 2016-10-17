'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

'Listing 11-6. Code-Behind for the DurationEditorInternal Control
Partial Public Class DurationEditorInternal
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    '1 Code that registers the Dependency Property                               
    Public Shared ReadOnly DurationProperty As DependencyProperty =
        DependencyProperty.Register(
            "Duration",
            GetType(Integer),
            GetType(DurationEditorInternal),
            New PropertyMetadata(0, AddressOf OnDurationPropertyChanged))

    Public Property Duration As Integer
        Get
            Return MyBase.GetValue(DurationEditorInternal.DurationProperty)
        End Get
        Set(value As Integer)
            MyBase.SetValue(DurationEditorInternal.DurationProperty, value)
        End Set
    End Property

    '2 Code that runs when the underlying data value changes                     
    Public Shared Sub OnDurationPropertyChanged(
        re As DependencyObject, e As DependencyPropertyChangedEventArgs)

        Dim de As DurationEditorInternal = DirectCast(re, DurationEditorInternal)
        Dim ts As TimeSpan = TimeSpan.FromMinutes(CInt(e.NewValue.ToString))

        de.HourTextbox.Text = Math.Floor(ts.TotalHours).ToString
        de.MinuteTextbox.Text = ts.Minutes.ToString

    End Sub

    '3 Code that runs when the user changes the value                            
    Private Sub HourTextbox_TextChanged(
        sender As Object, e As TextChangedEventArgs)
        Duration = CalculateDuration()
    End Sub

    Private Sub MinuteTextbox_TextChanged(
        sender As Object, e As TextChangedEventArgs)
        Duration = CalculateDuration()
    End Sub

    Private Function CalculateDuration() As Integer
        Dim dur As Integer
        Try
            dur = (CInt(HourTextbox.Text) * 60) + CInt(MinuteTextbox.Text)

        Catch ex As Exception
        End Try
        Return dur
    End Function

End Class