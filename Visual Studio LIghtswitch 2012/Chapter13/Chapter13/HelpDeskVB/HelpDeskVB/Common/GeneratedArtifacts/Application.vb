﻿


'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Namespace LightSwitchApplication

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Friend Module Application

        Public ReadOnly Property Current As Global.Microsoft.LightSwitch.IApplication(Of Global.LightSwitchApplication.DataWorkspace)
            Get
                Return TryCast(Global.Microsoft.LightSwitch.Framework.Base.ApplicationProvider.Current,
                    Global.Microsoft.LightSwitch.IApplication(Of Global.LightSwitchApplication.DataWorkspace))
            End Get
        End Property

    End Module

End Namespace
Namespace LightSwitchApplication
    <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> 
    <Global.System.Diagnostics.DebuggerNonUserCode> 
    <Global.System.CodeDom.Compiler.GeneratedCode("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")>
    <Global.System.ComponentModel.Composition.Export(GetType(Global.Microsoft.LightSwitch.Model.IModuleDefinitionLoader))> 
    <Global.Microsoft.LightSwitch.Model.ModuleDefinitionLoader("LightSwitchCommonModule")>
    Public Class CommonModuleLoader
        Implements Global.Microsoft.LightSwitch.Model.IModuleDefinitionLoader

        Public Function GetModelResourceManager() As Global.System.Resources.ResourceManager Implements Global.Microsoft.LightSwitch.Model.IModuleDefinitionLoader.GetModelResourceManager
            Return Nothing
        End Function

        Public Function LoadModelFragments() As Global.System.Collections.Generic.IEnumerable(Of Global.System.IO.Stream) Implements Global.Microsoft.LightSwitch.Model.IModuleDefinitionLoader.LoadModelFragments
            Dim assembly As Global.System.Reflection.Assembly = Global.System.Reflection.Assembly.GetExecutingAssembly
            Dim streams As New Global.System.Collections.Generic.List(Of Global.System.IO.Stream)

            For Each resourceName as Global.System.String In assembly.GetManifestResourceNames
                If resourceName.EndsWith(".lsml", Global.System.StringComparison.OrdinalIgnoreCase) Then
                    streams.Add(assembly.GetManifestResourceStream(resourceName))
                End If
            Next

            Return streams
        End Function
    End Class
End Namespace
