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

namespace LightSwitchApplication
{
    public partial class CreateNewEngineer
    {
        partial void CreateNewEngineer_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.EngineerProperty = new Engineer();
        }

        partial void CreateNewEngineer_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.EngineerProperty);
        }


        //Listing 7-21. Using PropertyChanged on a new Ddata Sscreen 
        partial void CreateNewEngineer_Created()
        {
            Microsoft.LightSwitch.Threading.Dispatchers.Main.BeginInvoke(() =>
            {
                ((INotifyPropertyChanged)this.EngineerProperty).PropertyChanged +=
                    EngineerFieldChanged;                                             
            });

            //Set the initial visibility here
            this.FindControl("SecurityGroup").IsVisible = EngineerProperty.SecurityVetted;
        }

        private void EngineerFieldChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "SecurityVetted")                                   
            {
                this.FindControl("SecurityGroup").IsVisible =
                    EngineerProperty.SecurityVetted;
            }
        }

    }
}