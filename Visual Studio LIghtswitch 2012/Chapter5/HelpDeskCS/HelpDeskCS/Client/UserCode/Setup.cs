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

using Microsoft.LightSwitch.Threading;

namespace LightSwitchApplication
{
    public partial class Setup
    {

        //Listing 4-1. Creating a New Record
        partial void SetupData_Execute()
        {
            var statusRaised =
               this.DataWorkspace.ApplicationData.IssueStatusSet.AddNew();
            statusRaised.StatusDescription = "Raised";
            this.DataWorkspace.ApplicationData.SaveChanges();

            //Bonus code for setting up other records
            AddPriorityIfNotExists("Low");
            AddPriorityIfNotExists("Medium");
            AddPriorityIfNotExists("High");
            AddStatusIfNotExists("Raised");
            AddStatusIfNotExists("Open");
            AddStatusIfNotExists("In Progress");
            AddStatusIfNotExists("Cancelled");
            AddStatusIfNotExists("Closed");
            AddDeptIfNotExists("Head Office");
        }

        //Bonus code for setting up data    
        private void AddPriorityIfNotExists(string PriorityDesc)
        {
            if (this.DataWorkspace.ApplicationData.Priorities.Where(item => item.PriorityDesc == PriorityDesc).FirstOrDefault() == null)
            {
                var newPriority = DataWorkspace.ApplicationData.Priorities.AddNew();
                newPriority.PriorityDesc = PriorityDesc;
            }
        }

        private void AddStatusIfNotExists(string StatusDesc)
        {
            if (this.DataWorkspace.ApplicationData.IssueStatusSet.Where(item => item.StatusDescription == StatusDesc).FirstOrDefault() == null)
            {
                var newStatus = DataWorkspace.ApplicationData.IssueStatusSet.AddNew();
                newStatus.StatusDescription = StatusDesc;
            }
        }

        private void AddDeptIfNotExists(string DeptDesc)
        {
            if (this.DataWorkspace.ApplicationData.Departments.Where(item => item.DepartmentName == DeptDesc).FirstOrDefault() == null)
            {
                var newDept = DataWorkspace.ApplicationData.Departments.AddNew();
                newDept.DepartmentName = DeptDesc;
            }
        }

    }
}
