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

namespace LightSwitchApplication
{
    public partial class CreateNewIssue
    {
        partial void CreateNewIssue_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Write your code here.
            this.IssueProperty = new Issue();

            //Listing 7-2. Setting Control Values
            this.IssueProperty.Priority =
           DataWorkspace.ApplicationData.Priorities.Where(
              item => item.PriorityDesc == "Medium").
                FirstOrDefault();

            //Listing 7-9. Setting the Focus to a Control 
            this.FindControl("ProblemDescription").Focus();


            // Listing 7-20. Threading 
            //this.Details.Dispatcher.BeginInvoke(() =>
            //   {
            //       //This code executes on the screen logic thread
            //       this.IssueProperty.ProblemDescription = "Desc. (screen logic thread)";
            //   }
            //);

            //Microsoft.LightSwitch.Threading.Dispatchers.Main.BeginInvoke(() =>
            //   {
            //       //This code executes on the UI thread 
            //       this.IssueProperty.ProblemDescription = "Desc. (main thread)";
            //   }
            //);


        }

        //Listing 7-7. Reset the New Data Screen After a Save
        partial void CreateNewIssue_Saved()
        {
            //Delete the auto generated lines below 
            //this.Close(false);
            //Application.Current.ShowDefaultScreen(Me.IssueProperty);
            this.IssueProperty = new Issue();
        }
    }
}