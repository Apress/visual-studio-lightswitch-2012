//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HelpDeskPortalCS.HelpDeskServiceReference;

namespace HelpDeskPortalCS
{
    public partial class CreateIssue : System.Web.UI.Page
    {
        //Listing 10-2. Web Form Code That Adds a New Issue 
        protected void AddIssue_Click(object sender, EventArgs e)
        {
            //ApplicationData srvRef =
            //        new ApplicationData(new Uri("http://localhost/HelpDesk/ApplicationData.svc/"));

            ApplicationData srvRef =
                    new ApplicationData(new Uri(ServiceEndPointURL.Text));

            HelpDeskServiceReference.Issue issue = new HelpDeskServiceReference.Issue();
            issue.Subject = IssueSubject.Text;
            issue.CreateDateTime = DateTime.Now;
            issue.TargetEndDateTime = DateTime.Now.AddDays(3);
            issue.ProblemDescription = IssueDescription.Text;

            try
            {
                srvRef.AddToIssues(issue);
                srvRef.SaveChanges();
                ConfirmLabel.Text = "Issue Created";
                IssueSubject.Text = "";
                IssueDescription.Text = "";
            }
            catch (Exception ex)
            {
                ConfirmLabel.Text = ex.Message;
            }
        }
    }
}