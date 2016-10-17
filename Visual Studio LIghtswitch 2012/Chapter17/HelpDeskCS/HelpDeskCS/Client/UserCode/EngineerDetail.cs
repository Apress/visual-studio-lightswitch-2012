//You can use and redistribute the code from this book (and sample application) for non-commercial and 
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
using System.ComponentModel;
using System.Windows.Controls;

namespace LightSwitchApplication
{
    public partial class EngineerDetail
    {

        // Listing 17-7. Adding a Username ComboBox

        private ComboBox cbo;

        partial void EngineerDetail_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            Microsoft.LightSwitch.Threading.Dispatchers.Main.BeginInvoke(() =>
            {
                this.Details.Properties.Engineer.Loader.ExecuteCompleted +=
                    this.EngineerLoaderExecuted;
            });

            // Listing 17-7. Adding a Username ComboBox
            var items =
               DataWorkspace.SecurityData.UserRegistrations.Cast<
                  Microsoft.LightSwitch.Security.UserRegistration>().ToList();

            this.FindControl("LoginNameProperty").ControlAvailable +=
               (object sender, ControlAvailableEventArgs e) =>
               {

                    cbo = (ComboBox)e.Control;
                   Microsoft.LightSwitch.Threading.Dispatchers.Main.BeginInvoke(() =>
                      {
                          cbo.ItemsSource = items;
                          cbo.DisplayMemberPath = "FullName";
                      }
                   );
               };
        }

        partial void Engineer_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Engineer);
            this.FindControl("LoginPicker").IsEnabled = this.Application.User.HasPermission(Permissions.CanEditEngineers);
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

        //Listing 7-18. Assigning and de-Unassigning Ssubordinates
        partial void AssignSubordinate_Execute()
        {
            Engineer.Subordinates.Add(EngineerToAdd);
            Subordinates.Refresh();
        }

        partial void UnassignSubordinate_Execute()
        {
            Engineer.Subordinates.Remove(Subordinates.SelectedItem);
            this.Save();
            Subordinates.Refresh();
        }

        //Listing 7-22. Using PropertyChanged on a Details Screen 
        private Engineer monitoredEngineer;

        private void EngineerLoaderExecuted(
            object sender, Microsoft.LightSwitch.ExecuteCompletedEventArgs e)
        {

            if (monitoredEngineer != this.Engineer)
            {
                if (monitoredEngineer != null)
                {
                    (monitoredEngineer as INotifyPropertyChanged).PropertyChanged -=
                        this.EngineerChanged;
                }

                monitoredEngineer = this.Engineer;
                if (monitoredEngineer != null)
                {
                    (monitoredEngineer as INotifyPropertyChanged).PropertyChanged +=
                        this.EngineerChanged;

                    //set the initial visibility here
                    this.FindControl("SecurityGroup").IsVisible =
                        monitoredEngineer.SecurityVetted;
                }
            }
        }

        private void EngineerChanged(
            object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "SecurityVetted")
            {
                this.FindControl("SecurityGroup").IsVisible =
                    monitoredEngineer.SecurityVetted;
            }
        }

        partial void CloseModalWindow_Execute()
        {
            this.CloseModalWindow("LoginPicker");
        }

        partial void OkModalWindow_Execute()
        {
              Microsoft.LightSwitch.Threading.Dispatchers.Main.BeginInvoke(
               ()=>{
                   Engineer.LoginName = cbo.SelectedItem.ToString();
               });
        }
    }
}