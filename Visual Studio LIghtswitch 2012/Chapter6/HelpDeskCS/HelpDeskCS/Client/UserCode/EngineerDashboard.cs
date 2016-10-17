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

namespace LightSwitchApplication
{
    public partial class EngineerDashboard
    {
        partial void Engineer_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Engineer);

            this.ScreenTitle = "The details beneath are relevant to the engineer '" + this.Engineer.FullName  + "'.";

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

                     //Set labels
            OpenIssuesLabel = String.Format("{0} open issues", outstandingIssues.Count().ToString());
            if(highPriorityExists){
                HighPriorityIssuesLabel = "There are high priority open issues";}
            else{
                HighPriorityIssuesLabel = "There are NO high priority open issues";
            }
            
            if(oldIssueExists){
                OldIssuesLabel = "All issues that are 7 days or older are closed";
            }else{
                OldIssuesLabel = "NOT all issues that are 7 days or older are closed";
            }

            Top5Label = sb.ToString();

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
    }
}