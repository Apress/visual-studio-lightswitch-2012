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

using System.Windows.Controls;

namespace LightSwitchApplication
{
    public partial class IssuesManagerGrid
    {

        //Listing 7-17. Bulk- Cclosing Mmultiple Rrecords
        private DataGrid _datagridControl = null;

        partial void IssuesManagerGrid_Created()
        {
            //1 Replace grid with the name of your data grid control                      
            this.FindControl("grid").ControlAvailable +=
                (object sender, ControlAvailableEventArgs e) =>
                {
                    _datagridControl = ((DataGrid)e.Control);
                    _datagridControl.SelectionMode =
                        DataGridSelectionMode.Extended;
                };
        }

        partial void CancelSelectedIssues_Execute()
        {

            var closedStatus = DataWorkspace.ApplicationData.IssueStatusSet.Where(
                i => i.StatusDescription == "Closed").FirstOrDefault();

            var closedEng = DataWorkspace.ApplicationData.Engineers.Where(
                e => e.LoginName == Application.User.Identity.Name).FirstOrDefault();

            foreach (Issue item in _datagridControl.SelectedItems)
            {
                item.IssueStatus = closedStatus;
                item.ClosedByEngineer = closedEng;
                item.ClosedDateTime = DateTime.Now;
            }
        }



    }
}
