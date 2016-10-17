//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

//Listing 11-3. Value Converter Code
namespace LightSwitchApplication.UserCode
{
    public class IntToDoubleConverter : IValueConverter                       
    {
        public object Convert(object value, Type targetType,                  
            object parameter, System.Globalization.CultureInfo culture)
        {
            return Double.Parse(value.ToString());
        }

        public object ConvertBack(object value, Type targetType,              
            object parameter, System.Globalization.CultureInfo culture)
        {
            return int.Parse(value.ToString());
        }
    }
}
