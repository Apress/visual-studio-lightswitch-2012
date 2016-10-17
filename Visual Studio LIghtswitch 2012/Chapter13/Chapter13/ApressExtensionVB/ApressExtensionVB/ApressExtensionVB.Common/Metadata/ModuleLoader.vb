'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.Collections.Generic
Imports System.ComponentModel.Composition
Imports System.IO
Imports System.Resources
Imports System.Reflection

Imports Microsoft.LightSwitch.Model

<Export(GetType(IModuleDefinitionLoader))>
<ModuleDefinitionLoader("ApressExtensionVB")>
Friend Class ModuleLoader
    Implements IModuleDefinitionLoader

    Public Function GetModelResourceManager() As ResourceManager Implements IModuleDefinitionLoader.GetModelResourceManager
        Return My.Resources.ModuleResources.ResourceManager
    End Function

    Public Function LoadModelFragments() As IEnumerable(Of Stream) Implements IModuleDefinitionLoader.LoadModelFragments
        Dim assembly As Assembly = assembly.GetExecutingAssembly()
        Dim fragmentStreams As IList(Of Stream) = New List(Of Stream)

        For Each resourceName In assembly.GetManifestResourceNames()
            If resourceName.EndsWith(".lsml", StringComparison.Ordinal) Then
                fragmentStreams.Add(assembly.GetManifestResourceStream(resourceName))
            End If
        Next

        Return fragmentStreams
    End Function

End Class