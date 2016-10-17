//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

//Listing 13-9. Creating a Custom Property Editor
using System;
using System.ComponentModel.Composition;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using Microsoft.LightSwitch.Designers.PropertyPages;
using Microsoft.LightSwitch.Designers.PropertyPages.UI;

namespace ApressExtensionCS
{
    internal class MaxIntegerEditor : IPropertyValueEditor
    {
        public MaxIntegerEditor(IPropertyEntry entry)
        {
            _editCommand = new EditCommand(entry);
        }
        private ICommand _editCommand;

        public object Context
        {
            get { return _editCommand; }
        }

        public DataTemplate GetEditorTemplate(IPropertyEntry entry)
        {
            ResourceDictionary dict = new ResourceDictionary()
            {
                Source = new
                Uri("ApressExtensionCS.Design;component/EditorTemplates.xaml",
                UriKind.Relative)
            };
            return (DataTemplate)dict["MaxIntegerEditorTemplate"];
        }

        private class EditCommand : ICommand
        {
            public EditCommand(IPropertyEntry entry)
            {
                _entry = entry;
            }

            private IPropertyEntry _entry;

            #region ICommand Members

            bool ICommand.CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged { add { } remove { } }

            void ICommand.Execute(object parameter)
            {
                MaxIntegerEditorDialog dialog = new MaxIntegerEditorDialog()
                {
                    Value = (int?)_entry.PropertyValue.Value
                };

                //Set the parent window of your dialog box to the IDE window; 
                //this ensures the win32 window stack works correctly.
                WindowInteropHelper wih = new WindowInteropHelper(dialog);
                wih.Owner = GetActiveWindow();
                dialog.ShowDialog();
                _entry.PropertyValue.Value = dialog.Value;
            }

            #endregion
            //GetActiveWindow is a Win32 method; import the method to get the 
            //IDE window

            [DllImport("user32")]
            public static extern IntPtr GetActiveWindow();
        }
    }

    [Export(typeof(IPropertyValueEditorProvider))]
    [PropertyValueEditorName(
        "ApressExtension:@MaxDurationWindow")]
    [PropertyValueEditorType("System.String")]
    internal class MaxIntegerEditorProvider : IPropertyValueEditorProvider
    {
        public IPropertyValueEditor GetEditor(IPropertyEntry entry)
        {
            return new MaxIntegerEditor(entry);
        }
    }
}
