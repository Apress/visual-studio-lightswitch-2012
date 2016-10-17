//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System;
using System.ComponentModel.Composition;
using System.Globalization;
using System.Windows.Media.Imaging;

using Microsoft.LightSwitch.BaseServices.ResourceService;

namespace ApressExtensionCS.Resources
{
    [Export(typeof(IResourceProvider))]
    [ResourceProvider("ApressExtensionCS.DurationEditor")]
    internal class DurationEditorImageProvider : IResourceProvider
    {
        #region IResourceProvider Members

        public object GetResource(string resourceId, CultureInfo cultureInfo)
        {
            return new BitmapImage(new Uri("/ApressExtensionCS.Design;component/Resources/ControlImages/DurationEditor.png", UriKind.Relative));
        }

        #endregion
    }
}