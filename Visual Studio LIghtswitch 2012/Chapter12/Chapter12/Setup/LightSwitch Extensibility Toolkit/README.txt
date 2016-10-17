Visual Studio 11 Beta SDK is required to use the LightSwitch Extensibility Toolkit for Visual Studio 11.
You can download the Visual Studio 11 Beta SDK from - http://www.microsoft.com/download/en/details.aspx?displaylang=en&id=28990

To install the LightSwitch Extensibility Toolkit:
1. Double click on Microsoft.LightSwitch.Toolkit.vsix present in this zip file.
2. Copy the Microsoft.LightSwitch.Toolkit.targets file from this zip into:
   - For 32-bit systems: %ProgramFiles%\MSBuild\Microsoft\VisualStudio\LightSwitch\v2.0
   - For 64-bit systems: %ProgramFiles(x86)%\MSBuild\Microsoft\VisualStudio\LightSwitch\v2.0

Launch Visual Studio and project templates for LightSwitch Extension Library will be available under the LightSwitch/Extensibility node in the New Project Dialog.

For information on upgrading projects created with an earlier version of the Toolkit, see the “Upgrading Extensiblity Projects” in the installation folder.