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
    public partial class EngineerDetail
    {
        partial void Engineer_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Engineer);
        }

        partial void Engineer_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Engineer);
        }

        partial void EngineerDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Engineer);
        }

        //Listing 5-11. Accessing Validation Results in Screen Code  
        partial void ValidationSummary_Execute()
        {
            //// Write your code here.
            //// Examples of calling the IsValidated and HasErrors properties
            //bool firstnameValid = this.Details.Properties.Firstname.IsValidated;
            //bool firstnameHasErrors = this.Details.Properties.Firstname.ValidationResults.HasErrors;

            //// Get a count of all results with a severity of 'Error'.
            //int errorCount = this.Details.ValidationResults.Errors.Count();

            //// Concatenate the error messages into a single string.
            //string allErrors = "";
            //foreach (ValidationResult result in this.Details.ValidationResults)
            //{
            //    allErrors += result.Message + " ";
            //}

        }
    }
}