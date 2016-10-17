//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Markup;
using Microsoft.LightSwitch.Designers.PropertyPages;
using Microsoft.LightSwitch.Designers.PropertyPages.UI;

namespace ApressExtensionCS.Editors
{

    [Export(typeof(IPropertyValueEditorProvider))]
    [PropertyValueEditorName("EntityPropertyDropdown")]
    [PropertyValueEditorType("System.String")]
    public class EntityPropertyDropdownEditorProvider
        : IPropertyValueEditorProvider
    {
        public IPropertyValueEditor GetEditor(IPropertyEntry entry)
        {
            return new Editor();
        }

        private class Editor : IPropertyValueEditor
        {
            // The screen designer calls this method to create the UI control on
            //  the property sheet.

            public DataTemplate GetEditorTemplate(IPropertyEntry entry)
            {
                return XamlReader.Parse(ControlTemplate) as DataTemplate;
            }

            public object Context
            {
                get
                {
                    return null;
                }
            }
        }

        #region Constants

        private const string ControlTemplate =
            "<DataTemplate" +
            " xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"" +
            " xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\"" +
            " xmlns:editors=\"clr-namespace:Editors;assembly=ApressExtensionCS.Design\">" +
            "   <editors:EntityPropertyDropdown/>" +
            "</DataTemplate>";

        #endregion
    }
}
