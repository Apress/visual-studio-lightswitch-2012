//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System;
using System.ComponentModel.Composition;

using Microsoft.LightSwitch.Theming;

namespace ApressExtensionCS.Presentation.Themes
{
    [Export(typeof(ITheme))]
    [Theme(ApressTheme.ThemeId, ApressTheme.ThemeVersion)]
    internal class ApressTheme : ITheme
    {
        #region ITheme Members

        public string Id
        {
            get { return ApressTheme.ThemeId; }
        }

        public string Version
        {
            get { return ApressTheme.ThemeVersion; }
        }

        public Uri ColorAndFontScheme
        {
            get { return new Uri(@"/ApressExtensionCS.Client;component/Presentation/Themes/ApressTheme.xaml", UriKind.Relative); }
        }

        #endregion

        #region Constants

        internal const string ThemeId = "ApressExtensionCS:ApressTheme";
        internal const string ThemeVersion = "1.0";

        #endregion
    }
}
