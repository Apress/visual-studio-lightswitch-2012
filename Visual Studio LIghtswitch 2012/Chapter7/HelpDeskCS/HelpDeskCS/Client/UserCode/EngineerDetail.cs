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
using System.ComponentModel;
using Microsoft.LightSwitch.Threading;

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

        //Listing 7-18. Assigning and de-Unassigning subordinates
        partial void AssignSubordinate_Execute()
        {
            Engineer.Subordinates.Add(EngineerToAdd);
            this.Save();
            Subordinates.Refresh();
        }

        partial void UnassignSubordinate_Execute()
        {
            Engineer.Subordinates.Remove(Subordinates.SelectedItem);
            this.Save();
            Subordinates.Refresh();
        }

        ////Listing 7-22. Using PropertyChanged on a Details Screen 
        private Engineer monitoredEngineer;

        partial void EngineerDetail_InitializeDataWorkspace(
            List<IDataService> saveChangesTo)
        {
            Microsoft.LightSwitch.Threading.Dispatchers.Main.Invoke(() =>
            {
                this.Details.Properties.Engineer.Loader.ExecuteCompleted +=
                    this.EngineerLoaderExecuted;
            });
        }

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

    }
}