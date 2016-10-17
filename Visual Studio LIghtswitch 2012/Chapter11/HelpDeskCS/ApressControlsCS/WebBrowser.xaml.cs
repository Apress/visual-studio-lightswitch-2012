//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

//Listing 11-9. WebBrowser Control .NET Code

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace ApressControlsCS
{
    public partial class WebBrowser : UserControl
    {
        public WebBrowser()
        {
            InitializeComponent();
        }

        // 1 Code that registers the Dependency Property
        public static readonly DependencyProperty URIProperty =
            DependencyProperty.Register(
                "uri",
                typeof(Uri),
                typeof(WebBrowser),
                new PropertyMetadata(null, OnUriPropertyChanged));

        public Uri uri
        {
            get { return (Uri)GetValue(URIProperty); }
            set { SetValue(URIProperty, value); }
        }

        // 2 Code that runs when the underlying URL changes
        private static void OnUriPropertyChanged(
            DependencyObject re, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != null)
            {
                WebBrowser web = (WebBrowser)re;
                web.wb.Navigate((Uri)e.NewValue);
            }
        }
    }
}
