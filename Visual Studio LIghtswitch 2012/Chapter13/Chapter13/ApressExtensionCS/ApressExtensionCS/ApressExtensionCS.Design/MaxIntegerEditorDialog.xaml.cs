//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

//Listing 13-7. Creating a Custom Property Editor

using System.Windows;

public partial class MaxIntegerEditorDialog : Window
{
    public MaxIntegerEditorDialog()
    {
       InitializeComponent();
    }
    public int? Value
    {
        get { return (int?)GetValue(ValueProperty); }
        set { SetValue(ValueProperty, value); }
    }
    public static readonly DependencyProperty ValueProperty =
        DependencyProperty.Register("Value", typeof(int?),
        typeof(MaxIntegerEditorDialog), new UIPropertyMetadata(0));
}