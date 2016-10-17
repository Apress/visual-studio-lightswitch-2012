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
    public partial class OfficeAddEditScreen
    {

        partial void OfficePropertyLoaded(bool succeeded)
        {
            if (!this.OfficeId.HasValue){
               this.OfficeProperty = new Office();
            }else{
               this.OfficeProperty = this.Office;
            }
            this.SetDisplayNameFromEntity(this.OfficeProperty);
        }

    }
}