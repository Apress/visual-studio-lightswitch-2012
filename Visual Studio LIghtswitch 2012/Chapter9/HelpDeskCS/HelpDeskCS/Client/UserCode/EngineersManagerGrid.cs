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
    public partial class EngineersManagerGrid
    {

        partial void EngineersManagerGrid_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {

            //Listing 7-11. Making Check Boxes Read-Only 
            foreach (Engineer eng in Engineers)
            {
                this.FindControlInCollection(
                    "SecurityCleared", eng).IsEnabled = false;
            }


        }
    }
}