﻿//You can use and redistribute the code from this book (and sample application) for non-commercial and 
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
    public partial class IssueDetail
    {
        partial void Issue_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Issue);
        }

        partial void Issue_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Issue);
        }

        partial void IssueDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Issue);
        }

        //Listing 4-6. Discarding Screen Changes
        partial void DiscardIssueRespChanges_Execute()
        {
        }

        partial void Issue_Validate(ScreenValidationResultsBuilder results)
        {
            //Listing 5-8. Performing Screen-Level Validation 
            if (this.Issue.Priority == null)
            {
                results.AddScreenError("Priority must be entered");
            }

            //Listing 5-9. Validating Deletions
            if (Issue.Details.EntityState == EntityState.Deleted &&
                Issue.IssueStatus != null
                   && Issue.IssueStatus.StatusDescription == "Open")
            {
                Issue.Details.DiscardChanges();
                results.AddScreenError("Unable to delete open issue");
            }
        }

        //Listing 5-9. Validating Deletions
        partial void DeleteIssue_Execute()
        {
            Issue.Delete();
        }
    }
}