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
using System.Text;
using System.Windows.Media;

namespace LightSwitchApplication
{
    public partial class EngineerDashboard
    {
        partial void Engineer_Loaded(bool succeeded)
        {

            //Listing 7-3. Setting the Screen Title in Code
            this.DisplayName = "Engineer Dashboard";
            //this.SetDisplayNameFromEntity(this.Engineer);

            ScreenTitle = "Engineer Dashboard Screen for " + this.Engineer.FullName;

            var outstandingIssues =
                Engineer.Issues.Where(engIssue => !engIssue.ClosedDateTime.HasValue);


            //Listing 6-4. Using the ForEach Operator
            StringBuilder sb = new StringBuilder();
            outstandingIssues.OrderByDescending(
                engItem => engItem.CreateDateTime).Take(5).ToList().ForEach(
                   engItem => sb.AppendLine(engItem.ProblemDescription));


             Issues5OldestLabel = sb.ToString();
             IssuesOutstandingLabel =
                 String.Format("You have {0} open issue(s)", outstandingIssues.Count().ToString());


        }

        partial void Engineer_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Engineer);
        }

        partial void EngineerDashboard_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Engineer);
        }


        // Listing 7-5. Refreshing All Open Screens
        partial void RefreshAllScreens_Execute()
        {
            var screens = this.Application.ActiveScreens;
            foreach (var s in screens)
            {
                var screen = s.Screen;
                screen.Details.Dispatcher.BeginInvoke(() =>
                {
                    screen.Refresh();
                });
            }
        }

        //   Listing 7-6. Passing Screen Parameters
        partial void OpenIssueSearchScreen_Execute()
        {
            this.Application.ShowIssueSearchAll(this.Engineer.Id);
        }


        //Listing 7-15. Opening the Combination Screen to Add a New Record
        partial void OpenNewIssueScreen_Execute()
        {
            this.Application.ShowAddEditIssue(null);
        }

 

    }
}