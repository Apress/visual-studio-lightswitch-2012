//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
using Microsoft.LightSwitch.Threading;
using System.Windows.Browser;
using Microsoft.LightSwitch.Security;

namespace LightSwitchApplication
{
    public partial class Info
    {

        //Listing 16-2. Execution Code for the Logout Button
        partial void Logout_Execute()
        {
            Dispatchers.Main.Invoke(() =>
            {
                HtmlPage.Window.Navigate(
                    new Uri("LogOff.aspx", UriKind.Relative));
            });
        }

        partial void Logout_CanExecute(ref bool result)
        {
            bool logoutCanExecute = false;
            Dispatchers.Main.Invoke(() =>
            {
                logoutCanExecute =
                   (System.Windows.Application.Current.IsRunningOutOfBrowser == false)
                      && (Application.Current.User.AuthenticationType ==
                          AuthenticationType.Forms);
            });
            result = logoutCanExecute;
        }

    }
}
