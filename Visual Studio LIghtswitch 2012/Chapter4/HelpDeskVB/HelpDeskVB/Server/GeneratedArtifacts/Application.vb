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

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
    Partial Public NotInheritable Class Application
        Inherits Global.Microsoft.LightSwitch.Framework.Server.ServerApplication(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass, Global.LightSwitchApplication.DataWorkspace)

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New(ByVal applicationDefinition As Global.Microsoft.LightSwitch.Model.IServiceApplicationDefinition, ByVal logicDispatcher As Global.Microsoft.LightSwitch.Threading.IDispatcher)
            MyBase.New(applicationDefinition, logicDispatcher)

            Global.LightSwitchApplication.Application.DetailsClass.Initialize(Me)
        End Sub

        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Partial Private Sub Application_Initialize()
        End Sub
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Shared Shadows ReadOnly Property Current As Global.LightSwitchApplication.Application
            Get
                Return DirectCast(Global.Microsoft.LightSwitch.Framework.Server.ServerApplication(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Current, Global.LightSwitchApplication.Application)
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public NotInheritable Class DetailsClass
            Inherits Global.Microsoft.LightSwitch.Details.Framework.Server.ServerApplicationDetails(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass, Global.LightSwitchApplication.Application.DetailsClass.PropertySet, Global.LightSwitchApplication.Application.DetailsClass.CommandSet, Global.LightSwitchApplication.Application.DetailsClass.MethodSet)

            Shared Sub New()
            End Sub

            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private Shared ReadOnly __ApplicationEntry As Global.Microsoft.LightSwitch.Details.Framework.Base.ApplicationDetails(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Entry = _
                New Global.Microsoft.LightSwitch.Details.Framework.Server.ServerApplicationDetails(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Entry( _
                    AddressOf Global.LightSwitchApplication.Application.DetailsClass.__Application_Initialized)
            Private Shared Sub __Application_Initialized(a As Global.LightSwitchApplication.Application)
                a.Application_Initialize()
            End Sub

            Public Sub New()
                MyBase.New()
            End Sub

            Public Shadows ReadOnly Property Properties As Global.LightSwitchApplication.Application.DetailsClass.PropertySet
                Get
                    Return MyBase.Properties
                End Get
            End Property

            Public Shadows ReadOnly Property Commands As Global.LightSwitchApplication.Application.DetailsClass.CommandSet
                Get
                    Return MyBase.Commands
                End Get
            End Property

            Public Shadows ReadOnly Property Methods As Global.LightSwitchApplication.Application.DetailsClass.MethodSet
                Get
                    Return MyBase.Methods
                End Get
            End Property

            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class PropertySet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Server.ServerApplicationPropertySet(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass)

            End Class

            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class CommandSet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Server.ServerApplicationCommandSet(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass)

            End Class

            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class MethodSet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Server.ServerApplicationMethodSet(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass)

            End Class

            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend NotInheritable Class PropertySetProperties

            End Class

            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend NotInheritable Class CommandSetProperties

            End Class

            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend NotInheritable Class MethodSetProperties

            End Class

        End Class

    End Class

End Namespace
Namespace LightSwitchApplication
    <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> 
    <Global.System.Diagnostics.DebuggerNonUserCode> 
    <Global.System.CodeDom.Compiler.GeneratedCode("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")>
    <Global.System.ComponentModel.Composition.Export(GetType(Global.Microsoft.LightSwitch.Model.IModuleDefinitionLoader))> 
    <Global.Microsoft.LightSwitch.Model.ModuleDefinitionLoader("LightSwitchServiceApplication")>
    Public Class ServiceModuleLoader
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
