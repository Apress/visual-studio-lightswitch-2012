//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

//Listing 11-11. Code to Call a Screen Method Called SaveData
using Microsoft.LightSwitch.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace ApressControlsCS
{
    public partial class SaveControl : UserControl
    {
        public SaveControl()
        {
            InitializeComponent();
        }

        private void CustomButton_Click(System.Object sender,
       System.Windows.RoutedEventArgs e)
        {
            // Get a reference to the LightSwitch Screen
            var objDataContext = (IContentItem)this.DataContext;

            var clientScreen =
            (Microsoft.LightSwitch.Client.IScreenObject)objDataContext.Screen;

            // Call the Method on the LightSwitch screen
            clientScreen.Details.Dispatcher.BeginInvoke(
                () =>
                {
                    try
                    {
                        this.SetEnabled(false);
                        clientScreen.Details.Commands["SaveData"].Execute();
                    }
                    finally
                    {
                        this.SetEnabled(true);
                    }
                });
        }

        private void SetEnabled(bool value)
        {
            this.Dispatcher.BeginInvoke(() =>
            {
                this.CustomButton1.IsEnabled = value;
            });
        }
    }
}