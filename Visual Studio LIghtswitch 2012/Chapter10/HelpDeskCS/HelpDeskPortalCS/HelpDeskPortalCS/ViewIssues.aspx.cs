//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using HelpDeskPortalCS.HelpDeskServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelpDeskPortalCS
{
    public partial class ViewIssues : System.Web.UI.Page
    {

        //Listing 10-4. Web Form Code That Populates a Grid View 
        protected void Page_Load(object sender, EventArgs e)
        {
            //ApplicationData srvRef =
            //    new ApplicationData(new Uri("http://localhost/HelpDesk/ApplicationData.svc/"));
            ////srvRef.Credentials = new System.Net.NetworkCredential("username", "password");
            //var issues = srvRef.Issues.Select(i => i.User.Username == "timl");
            //IssuesGrid.DataSource = issues;
            //IssuesGrid.DataBind();
        }

        protected void GetIssues_Click(object sender, EventArgs e)
        {
            ApplicationData srvRef =
                new ApplicationData(new Uri(ServiceEndPointURL.Text));
            var issues = srvRef.Issues.OrderByDescending (item=> item.Id ).Take (100);
            IssuesGrid.DataSource = issues;
            IssuesGrid.DataBind();
        }
    }
}