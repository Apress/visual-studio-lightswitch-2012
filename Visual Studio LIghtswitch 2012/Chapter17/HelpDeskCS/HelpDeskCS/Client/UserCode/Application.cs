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
namespace LightSwitchApplication
{
    public partial class Application
    {
        // Listing 17-4. Setting a Screen’s CanRun Method
        partial void EngineersManagerGrid_CanRun(ref bool result)
        {
            result =
                Application.Current.User.HasPermission(
                    Permissions.CanEditEngineers);
        }

        //Listing 17-8. Opening Screens Conditionally
        partial void Startup_CanRun(ref bool result)
        {
            // Set result to the desired field value
            if (Application.Current.User.HasPermission(Permissions.CanViewAllIssues))
            {
                this.ShowEngineersManagerGrid();
            }
            else
            {
                using (DataWorkspace dw = this.CreateDataWorkspace())
                {

                    //This is the code you'd use to find the currently logged on engineer
                    //Engineer currentEng =
                    //    dw.ApplicationData.Engineers.Where(
                    //        eng => eng.LoginName ==
                    //            Application.Current.User.Name).FirstOrDefault();

                    //if (currentEng != null)
                    //{
                    //    this.ShowEngineerDashboard(currentEng.Id);
                    //}
                    this.ShowEngineerDashboard(dw.ApplicationData.Engineers.FirstOrDefault().Id);
                }
            }

            this.ShowInfo(); 
            result = false;
        }
    }
}
