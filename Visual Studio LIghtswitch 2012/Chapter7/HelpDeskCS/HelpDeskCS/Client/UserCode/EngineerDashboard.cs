// You can use and redistribute the code from this book (and sample application) for non-commercial and 
// most commercial purposes as long as you acknowledge the source and authorship. 
// You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
// The acknowledgment should include author, title, publisher, and ISBN. 
// An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

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

            ScreenTitle = "Engineer Dashboard for " + Engineer.FullName;

            var outstandingIssues =
                Engineer.Issues.Where(engIssue => !engIssue.ClosedDateTime.HasValue);

            //Listing 6-2. Using the Any Standard Query Operator
            bool highPriorityExists =
               outstandingIssues.Any(
                     engIssue => engIssue.Priority.PriorityDesc == "High");

            //Listing 6-3. Using the All Standard Query Operator
            bool oldIssueExists =
               Engineer.Issues.Where(engIssue =>
                  engIssue.CreateDateTime < DateTime.Now.AddDays(-7)).All(
                     engIssue => engIssue.ClosedDateTime.HasValue);


            //Listing 6-4. Using the ForEach Operator
            StringBuilder sb = new StringBuilder();
            outstandingIssues.OrderByDescending(
                engItem => engItem.CreateDateTime).Take(5).ToList().ForEach(
                   engItem => sb.AppendLine(engItem.ProblemDescription));


            //Listing 6-5. Querying Data Collections  
            DateTime startOfYear = new DateTime(DateTime.Now.Year, 1, 1);

            //Query 1
            var issuesLastMonth =
                Engineer.Issues.Where(
                    issueItem => issueItem.CreateDateTime > startOfYear).Count();

            //'Query 2
            var issuesLastMonth2 =
                Engineer.IssuesQuery.Where(
                    issueItem => issueItem.CreateDateTime > startOfYear).
                        Execute().Count();

            //Listing 7-12. Referencing a Control Using ControlAvailable 
            var control = this.FindControl("IssuesOverdueLabel");
            control.ControlAvailable +=
            (object sender, ControlAvailableEventArgs e) =>
            {
                var issueLabel =
                    (System.Windows.Controls.TextBlock)e.Control;
                issueLabel.Foreground = new SolidColorBrush(Colors.Red);
            };

            //Set labels
            IssuesOverdueLabel =
                String.Format("{0} open issues", outstandingIssues.Count().ToString());

            if (highPriorityExists)
            {
                HighPriorityIssuesLabel = "There are high priority open issues";
            }
            else
            {
                HighPriorityIssuesLabel = "There are NO high priority open issues";
            }

            if (oldIssueExists)
            {
                OldIssuesLabel = "All issues that are 7 days or older are closed";
            }
            else
            {
                OldIssuesLabel = "NOT all issues that are 7 days or older are closed";
            }

            Issues5OldestLabel = sb.ToString();

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

        partial void OpenIssue_Execute()
        {
            this.Application.ShowAddEditIssue(QuickFindIssue.Id);
        }

    }
}