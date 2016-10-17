//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using Microsoft.LightSwitch;
using System;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace ApressExtensionCS.Presentation.Shells
{
    public class WorkspaceDirtyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
           object parameter, CultureInfo culture)
        {
            return (bool)value ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        { throw new NotSupportedException(); }
    }

    public class ScreenHasErrorsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
           object parameter, CultureInfo culture)
        {
            return (bool)value ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType,
           object parameter, CultureInfo culture)
        { throw new NotSupportedException(); }
    }

    public class ScreenResultsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
           object parameter, CultureInfo culture)
        {
            ValidationResults results = (ValidationResults)value;
            StringBuilder sb = new StringBuilder();

            foreach (ValidationResult result in results.Errors)
                sb.AppendLine(String.Format("Error: {0}", result.Message));

            return sb.ToString();
        }

        public object ConvertBack(object value, Type targetType,
           object parameter, CultureInfo culture)
        { throw new NotSupportedException(); }
    }

    public class CurrentUserConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
           object parameter, CultureInfo culture)
        {
            string currentUser = (string)value;

            if ((null == currentUser) || (0 == currentUser.Length))
                return "Authentication is not enabled.";

            return currentUser;
        }

        public object ConvertBack(object value, Type targetType,
           object parameter, CultureInfo culture)
        { throw new NotSupportedException(); }
    }

}
