//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Resources;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch;

namespace ApressExtensionCS.Presentation.Controls
{
    public partial class HighlightButton : UserControl
    {
        public HighlightButton()
        {
            InitializeComponent();
        }

        private void CustomButton_Click(object sender, RoutedEventArgs e)
        {
            IExecutable cmd = (IExecutable)((IContentItem)this.DataContext).Details;
            if (cmd != null && cmd.CanExecuteAsync)
            {
                cmd.ExecuteAsync();
            }
        }
    }

    [Export(typeof(IControlFactory))]
    [ControlFactory("ApressExtensionCS:HighlightButton")]
    internal class HighlightButtonFactory : IControlFactory
    {
        #region IControlFactory Members

        public DataTemplate DataTemplate
        {
            get
            {
                if (null == this.dataTemplate)
                {
                    this.dataTemplate = XamlReader.Load(HighlightButtonFactory.ControlTemplate) as DataTemplate;
                }
                return this.dataTemplate;
            }
        }

        public DataTemplate GetDisplayModeDataTemplate(IContentItem contentItem)
        {
            return null;
        }

        #endregion

        #region Private Fields

        private DataTemplate dataTemplate;

        #endregion

        #region Constants

        private const string ControlTemplate =
            "<DataTemplate" +
            " xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"" +
            " xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\"" +
            " xmlns:ctl=\"clr-namespace:ApressExtensionCS.Presentation.Controls;assembly=ApressExtensionCS.Client\">" +
            "<ctl:HighlightButton/>" +
            "</DataTemplate>";

        #endregion
    }
}
