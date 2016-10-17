//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Reflection;
using System.Resources;

using Microsoft.LightSwitch.Model;

using ApressExtensionCS.Resources;

namespace ApressExtensionCS.Metadata
{
    [Export(typeof(IModuleDefinitionLoader))]
    [ModuleDefinitionLoader("ApressExtensionCS")]
    internal class ModuleLoader :
        IModuleDefinitionLoader
    {
        #region IModuleDefinitionLoader Members

        ResourceManager IModuleDefinitionLoader.GetModelResourceManager()
        {
            return ModuleResources.ResourceManager;
        }

        IEnumerable<Stream> IModuleDefinitionLoader.LoadModelFragments()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            IList<Stream> fragmentStreams = new List<Stream>();

            foreach (string resourceName in assembly.GetManifestResourceNames())
            {
                if (resourceName.EndsWith(".lsml", StringComparison.Ordinal))
                {
                    fragmentStreams.Add(assembly.GetManifestResourceStream(resourceName));
                }
            }

            return fragmentStreams;
        }

        #endregion
    }
}