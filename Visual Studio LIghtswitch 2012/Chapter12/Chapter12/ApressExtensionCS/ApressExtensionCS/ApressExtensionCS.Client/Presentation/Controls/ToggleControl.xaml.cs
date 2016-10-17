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

namespace ApressExtensionCS.Presentation.Controls
{
    public partial class ToggleControl : UserControl
    {
        public ToggleControl()
        {
            InitializeComponent();
        }


        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (ContentPanel.Visibility == Visibility.Visible)
            {
                ContentPanel.Visibility = Visibility.Collapsed;
                ToggleButton.Content = "Show";
            }
            else
            {
                ContentPanel.Visibility = Visibility.Visible;
                ToggleButton.Content = "Hide";
            }
        }
    }

    [Export(typeof(IControlFactory))]
    [ControlFactory("ApressExtensionCS:ToggleControl")]
    internal class ToggleControlFactory : IControlFactory
    {
        #region IControlFactory Members

        public DataTemplate DataTemplate
        {
            get
            {
                if (null == this.dataTemplate)
                {
                    this.dataTemplate = XamlReader.Load(ToggleControlFactory.ControlTemplate) as DataTemplate;
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
            "<ctl:ToggleControl/>" +
            "</DataTemplate>";

        #endregion
    }
}
