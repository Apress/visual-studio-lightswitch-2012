//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System;
using System.ComponentModel.Composition;

using Microsoft.LightSwitch.Runtime.Shell;

namespace ApressExtensionCS.Presentation.Shells.Components
{
    [Export(typeof(IShell))]
    [Shell(ApressShell.ShellId)]
    internal class ApressShell : IShell
    {
        #region IShell Members

        public string Name
        {
            get { return ApressShell.ShellId; }
        }

        public Uri ShellUri
        {
            get { return new Uri(@"/ApressExtensionCS.Client;component/Presentation/Shells/ApressShell.xaml", UriKind.Relative); }
        }

        #endregion

        #region Constants

        private const string ShellId = "ApressExtensionCS:ApressShell";

        #endregion
    }
}
