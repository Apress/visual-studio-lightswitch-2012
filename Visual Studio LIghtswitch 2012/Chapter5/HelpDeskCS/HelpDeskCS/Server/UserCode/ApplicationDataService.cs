// You can use and redistribute the code from this book (and sample application) for non-commercial and 
// most commercial purposes as long as you acknowledge the source and authorship. 
// You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
// The acknowledgment should include author, title, publisher, and ISBN. 
// An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 
//9781430250715".

using System.Text;
using System.Transactions;
using Microsoft.LightSwitch;
using System.Linq;

namespace LightSwitchApplication
{
    partial class ApplicationDataService
    {

        partial void Issues_Validate(Issue entity, EntitySetValidationResultsBuilder results)
        {

            //Listing 5-6. Validating the Counts of Child Items 
            if (entity.IssueDocuments.Count() > 10)
            {
                results.AddEntityError(
                    "Issues can only contain a maximum of 10 documents");
            }

            //Listing 5-10. Validating Deletions on the Server 
            if (entity.Details.EntityState == EntityState.Deleted)
            {
                if (entity.IssueResponses.Where(s => s.AwaitingClient).Any())
                {
                    results.AddEntityError(
                        "Cannot delete issues with responses awaiting client.");
                }
            }
        }

        //Listing 5-10. Validating Deletions on the Server 
        partial void Issues_Deleting(Issue entity)
        {
            // Check for validation errors for deletions
            if (entity.Details.ValidationResults.Errors.Any())
            {
                throw new ValidationException(
                   null, null, entity.Details.ValidationResults);                       
            }

            // Cascade delete children because delete rule is Restricted
            foreach (var childResp in entity.IssueResponses)
            {
                childResp.Delete();                                                     
            }
        }

    }
}

