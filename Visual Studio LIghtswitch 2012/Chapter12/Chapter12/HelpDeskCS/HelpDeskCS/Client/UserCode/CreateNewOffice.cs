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
using System.Windows.Controls;
using System.Windows.Data;
using LightSwitchApplication.UserCode;

namespace LightSwitchApplication
{
    public partial class CreateNewOffice
    {
        partial void CreateNewOffice_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.OfficeProperty = new Office();
        }

        partial void CreateNewOffice_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.OfficeProperty);
        }

        partial void CreateNewOffice_Activated()
        {
            //Listing 11-4. Data-Binding the Slider Control
            IContentItemProxy buildingCapacity =
                   this.FindControl("BuildingCapacity");
            IntToDoubleConverter converter = new IntToDoubleConverter();
            buildingCapacity.SetBinding(
                Slider.ValueProperty,
                "Value",
                converter,
                BindingMode.TwoWay);

        }
    }
}