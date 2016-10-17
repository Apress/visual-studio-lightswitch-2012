//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using System.Text.RegularExpressions;

namespace LightSwitchApplication
{
    public partial class Engineer
    {

        partial void FullName_Compute(ref string result)
        {
            if (Firstname != null && Surname != null)
            {
                result = String.Format("{0} - {1}",
                    Surname.ToString(), Firstname.ToString());
            }
        }

        partial void Age_Compute(ref int result)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - DateOfBirth.Year;
            if (DateOfBirth > now.AddYears(-age)) age--;
            result = age;
        }

        partial void IssueCount_Compute(ref int result)
        {
            result = this.Issues.Count();
        }

        //Listing 5-1. Creating a Validation Warning  
        partial void EmailAddress_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            if (System.String.IsNullOrEmpty(EmailAddress))
            {
                results.AddPropertyResult(
                   "Providing an Email Address is recommended",
                   ValidationSeverity.Informational);
            }
        }

        //Listing 5-4. Regex Validation to Check Social Security Numbers
        partial void SSN_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            string pattern =
   @"^(?!000)([0-6]\d{2}|7([0-6]\d|7[012]))([ -]?)(?!00)\d\d\3(?!0000)\d{4}$";
            if (SSN != null && !Regex.IsMatch(SSN, pattern))
            {
                results.AddPropertyError(
                    "Enter SSN in format 078-05-1120");
            }
        }

        //Listing 5-5. Validating File Sizes
        partial void EngineerPhoto_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            if (EngineerPhoto != null)
            {
                var sizeInKB = EngineerPhoto.Length / 1024;
                if (sizeInKB > 512)
                {
                    results.AddPropertyError("Image Size cannot be > 512kb");
                }
            }

        }

        // Listing 5-7. Enforcing Unique Records
        partial void ClearanceReference_Validate(EntityValidationResultsBuilder results)
        {
            if (ClearanceReference != null &&
                ClearanceReference.Length > 0)
            {
                var duplicatesOnServer = (
                    from eng in
                        this.DataWorkspace.ApplicationData.Engineers.Cast<Engineer>()
                    where (eng.Id != this.Id) &&
                    eng.ClearanceReference.Equals(this.ClearanceReference,
                        StringComparison.CurrentCultureIgnoreCase)
                    select eng
                        ).ToArray();

                var duplicatesOnClient = (
                    from eng in
                        this.DataWorkspace.ApplicationData.Details.GetChanges().
                       OfType<Engineer>()
                    where (eng != this) &&
                    eng.ClearanceReference.Equals(this.ClearanceReference,
                       StringComparison.CurrentCultureIgnoreCase)
                    select eng
                        ).ToArray();

                var deletedOnClient =
                   this.DataWorkspace.ApplicationData.Details.GetChanges().
                      DeletedEntities.OfType<Engineer>().ToArray();

                var anyDuplicates =
                   duplicatesOnServer.Union(duplicatesOnClient).
                      Distinct().Except(deletedOnClient).Any();

                if (anyDuplicates)
                {
                    results.AddPropertyError(
                        "The clearance reference already exists");
                }
            }
        }

        //Listing 17-11. Bypassing Validation
        partial void Engineer_AllowSaveWithErrors(ref bool result)
        {
            result = Application.User.HasPermission(Permissions.CanBypassValidation);
        }

    }
}
