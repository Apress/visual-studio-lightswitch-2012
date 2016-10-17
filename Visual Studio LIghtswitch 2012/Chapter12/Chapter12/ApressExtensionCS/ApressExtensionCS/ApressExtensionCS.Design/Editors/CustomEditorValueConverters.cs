//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System;
using System.Globalization;
using System.Windows.Data;
using Microsoft.LightSwitch.Model;
using System.Collections.Generic;

namespace ApressExtensionCS.Editors
{
    //This appends ':' to the end of the property name label
    public class AppendSemiColonConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType,
           object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                return string.Format(CultureInfo.CurrentCulture, "{0}:", value);
            }
            return string.Empty;
        }

        public object ConvertBack(object value, System.Type targetType,
           object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }

    // This gets a collection of property names for an entity type and the result
    // inclues an entry that contains an empty string. 
    // The return value fills the values in the ComboBox.
    public class GetAllEntityPropertiesConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType,
          object parameter, System.Globalization.CultureInfo culture)
        {
            List<string> textProperties = new List<string>();

            textProperties.Add(string.Empty);

            IContentItemDefinition contentItemDefinition =
                value as IContentItemDefinition;
            if (contentItemDefinition != null)
            {
                IEntityType entityType =
                   contentItemDefinition.DataType as IEntityType;
                if (entityType != null)
                {
                    foreach (IPropertyDefinition p in
                       CustomEditorHelper.GetTextPropertiesForEntity(entityType))
                    {
                        textProperties.Add(p.Name);
                    }
                }
            }
            return textProperties;
        }

        public object ConvertBack(object value, System.Type targetType,
           object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }

    // If the developer hasn't entered a display name, this converts the dislay 
    // text of the empty value to '<Summmary>' 
    public class EmptyStringToSummaryConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType,
           object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is string && string.IsNullOrEmpty((string)value))
            {
                return "<Summary>";
            }
            return value;
        }
        public object ConvertBack(object value, System.Type targetType,
            object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
