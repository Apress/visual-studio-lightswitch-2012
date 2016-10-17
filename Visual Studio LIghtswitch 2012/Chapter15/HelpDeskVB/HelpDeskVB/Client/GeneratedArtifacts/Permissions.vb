﻿'------------------------------------------------------------------------------
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

    ''' <summary>
    ''' Defines the names of the application permissions.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Public Module Permissions

        ''' <summary>
        ''' Provides the ability to manage security for the application.
        ''' </summary>
        Public Const SecurityAdministration As String = Global.Microsoft.LightSwitch.Security.ApplicationPermissions.SecurityAdministration

        ''' <summary>
        ''' Gets all permissions defined for the application.  This includes system and user-defined permissions.
        ''' </summary>
        Public ReadOnly Property AllPermissions() As Global.System.Collections.ObjectModel.ReadOnlyCollection(Of String)
            Get
                Return Global.Microsoft.LightSwitch.Security.ApplicationPermissions.AllPermissions
            End Get
        End Property

    End Module

End Namespace
