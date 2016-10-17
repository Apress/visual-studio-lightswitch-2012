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
using System.Windows.Data;

namespace LightSwitchApplication
{
    public partial class EngineersListReport
    {

        partial void EngineersListReport_Created()
        {
            //Listing 14-7. Showing a Web Page on a LightSwitch List and Details Screen 
            IdToReportUrlConverter converter = new IdToReportUrlConverter();

            converter.rootURI = this.DataWorkspace.ApplicationData.AppOptions.FirstOrDefault().ReportWebServer.ToString();

            var control = this.FindControl("id");
            control.SetBinding(ApressControlsCS.WebBrowser.URIProperty,
                "Value", converter, BindingMode.OneWay);
        }
    }

    ////Listing 14-7. Showing a Web Page on a LightSwitch List and Details Screen
    // Add this code after your 'EngineerListReport' class
    public class IdToReportUrlConverter : IValueConverter
    {

        public string rootURI { get; set; }

        public object Convert(object value, Type targetType,
            object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                return new Uri(
                    rootURI + @"/IssuesByEngineer.aspx?EngineerId=" +
                       value.ToString());
            }
            else
            {
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, System.Globalization.CultureInfo culture)
        {
            return new NotImplementedException();
        }

    }
}
