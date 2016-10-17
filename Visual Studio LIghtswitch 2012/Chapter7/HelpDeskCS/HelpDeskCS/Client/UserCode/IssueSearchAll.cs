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
    public partial class IssueSearchAll
    {
        //Listing 7-10. Hiding and Showing Controls 
        partial void ToggleVisibility_Execute()
        {
            var rowLayout = this.FindControl("AdvancedGroup");
            rowLayout.IsVisible = !(rowLayout.IsVisible);

            if (rowLayout.IsVisible)
            {
                this.FindControl("ToggleVisibility").DisplayName =
                   "Show Simple Filters";
            }
            else
            {
                this.FindControl("ToggleVisibility").DisplayName =
                   "Show Advanced Filters";
            }
        }

        //Listing 7-16. Controlling the Custom Modal Window
        partial void AddItem_Execute()
        {
            Issues.AddNew();
            this.OpenModalWindow("IssueWindow");
        }

        partial void EditItem_Execute()
        {
            this.OpenModalWindow("IssueWindow");
        }

        partial void SaveItem_Execute()
        {
            this.CloseModalWindow("IssueWindow");
        }

        partial void CancelItem_Execute()
        {
            ((Issue)Issues.SelectedItem).Details.DiscardChanges();
            this.CloseModalWindow("IssueWindow");
        }

        partial void IssueSearchAll_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            if (IssueEngineerId.HasValue)
            {
                EngineerSelector = this.DataWorkspace.ApplicationData.Engineers_SingleOrDefault(IssueEngineerId);
            }

        }

    }
}
