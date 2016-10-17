using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace LightSwitchCommonModule
{
    public class GlobalDates
    {
        // The name of the GlobalValueDefinition
        public static DateTime SevenDaysAgo()
        {
            return DateTime.Now.AddDays(-7);
        }
    }
}
