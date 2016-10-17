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
                   "Hide Simple Filters";
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

    }
}
