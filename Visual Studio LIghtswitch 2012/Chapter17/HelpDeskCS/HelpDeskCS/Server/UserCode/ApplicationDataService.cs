//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System.Text;
using System.Transactions;
using Microsoft.LightSwitch;
using System.Linq;
using System;
using System.Linq.Expressions;

namespace LightSwitchApplication
{
    partial class ApplicationDataService
    {

        // Listing 17-1. Setting Access-Control Permissions
        partial void Engineers_CanDelete(ref bool result)
        {
            result = Application.User.HasPermission(
                Permissions.CanEditEngineers);
        }

        partial void Engineers_CanInsert(ref bool result)
        {
            result = Application.User.HasPermission(
                Permissions.CanEditEngineers);
        }

        partial void Engineers_CanUpdate(ref bool result)
        {
            result = Application.User.HasPermission(
                Permissions.CanEditEngineers);
        }

        // Listing 17-2. Preventing Users from Saving Data
        partial void SaveChanges_CanExecute(ref bool result)
        {
            //System is down for daily maintenance from midnight to 3am
            if (DateTime.Now.TimeOfDay.Hours >= 0 &&
               DateTime.Now.TimeOfDay.Hours <= 3)
            {
                result = false;
            }
            else
            {
                result = true;
            }
        }

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

        //Listing 6-7. Filtering by Child Items   
        partial void EngineersWithOutstandingIssues_PreprocessQuery(ref IQueryable<Engineer> query)
        {
            query = query.Where
                (engItem => engItem.Issues.Where(
                    issueItem => issueItem.IssueStatus.StatusDescription == "Open").
                    Any());
        }

        //Listing 6-9. Returning All Issues with Related Issue Document Records
        partial void IssuesWithAttachments_PreprocessQuery(ref IQueryable<Issue> query)
        {
            query = query.Where(issueItem => issueItem.IssueDocuments.Any());
        }

        //Listing 6-11. Returning Issue Records Without Any Issue Responses   
        partial void IssuesWithNoResponse_PreprocessQuery(ref IQueryable<Issue> query)
        {
            query = query.Where(issueItem => !issueItem.IssueResponses.Any());
        }

        //Listing 6-12. Filtering by Month and Year Parameter Values
        partial void IssuesByMonthAndYear_PreprocessQuery(int? IssueMonth, int? IssueYear, ref IQueryable<Issue> query)
        {
            if (IssueMonth.HasValue && IssueYear.HasValue)
            {
                query = query.Where(
                    item => item.CreateDateTime.Month == IssueMonth.Value &&
                    item.CreateDateTime.Year == IssueYear.Value);
            }
        }

        //Listing 6-13. Query to Return Issues with the Highest Feedback
        partial void IssuesWithHighestFeedback_PreprocessQuery(ref IQueryable<Issue> query)
        {
            query = query.OrderByDescending(
              issueItem => issueItem.IssueFeedbacks.Average(
                  feedback => feedback.OverallRating)).Take(5);
        }

        //Listing 17-6. Editing a Query’s CanExecute Method
        partial void IssuesWithHighestFeedback_CanExecute(ref bool result)
        {
            result =
                Application.User.HasPermission(Permissions.CanViewReport);
        }

        //Listing 17-9. Restricting Row-Level Access to Data
        partial void Issues_Filter(ref Expression<Func<Issue, bool>> filter)
        {
            // filter = e => e.IntegerProperty == 0;
            if (!Application.User.HasPermission(Permissions.CanViewAllIssues))
            {

                //This is the code that filters the records by the actual user
                //string currentUser = Application.User.Name;
                //Engineer currentEng =
                //    DataWorkspace.ApplicationData.Engineers.Where(
                //        eng => eng.LoginName == currentUser).FirstOrDefault();

                //if (currentEng != null)
                //{
                //    filter = e => e.AssignedTo.Id == currentEng.Id;
                //}

                var firstEngId = DataWorkspace.ApplicationData.Engineers.FirstOrDefault().Id;
                filter = e => e.AssignedTo.Id == firstEngId;
            }
        }


    }
}

