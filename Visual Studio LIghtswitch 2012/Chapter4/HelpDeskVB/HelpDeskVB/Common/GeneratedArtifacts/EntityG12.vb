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

Imports __AuditDetail = LightSwitchApplication.AuditDetail

Namespace LightSwitchApplication

    #Region "Entities"
    
    ''' <summary>
    ''' No Modeled Description Available
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
    Public NotInheritable Partial Class AuditDetail
        Inherits Global.Microsoft.LightSwitch.Framework.Base.EntityObject(Of __AuditDetail, __AuditDetail.DetailsClass)
    
        #Region "Constructors"
    
        ''' <summary>
        ''' Initializes a new instance of the AuditDetail entity.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New()
            Me.New(Nothing)
        End Sub
    
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New(entitySet As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __AuditDetail))
            MyBase.New(entitySet)
            
            __AuditDetail.DetailsClass.Initialize(Me)
        End Sub
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub AuditDetail_Created()
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub AuditDetail_AllowSaveWithErrors(ByRef result As Boolean)
        End Sub
    
        #End Region
    
        #Region "Private Properties"
        
        ''' <summary>
        ''' Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Private ReadOnly Property Application As Global.Microsoft.LightSwitch.IApplication(Of Global.LightSwitchApplication.DataWorkspace)
            Get
                Return Global.LightSwitchApplication.Application.Current
            End Get
        End Property
        
        ''' <summary>
        ''' Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Private ReadOnly Property DataWorkspace As Global.LightSwitchApplication.DataWorkspace
            Get
                Return DirectCast(Me.Details.EntitySet.Details.DataService.Details.DataWorkspace, Global.LightSwitchApplication.DataWorkspace)
            End Get
        End Property
        
        #End Region
    
        #Region "Public Properties"
    
        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property AuditID As Integer
            Get
                Return __AuditDetail.DetailsClass.GetValue(Me, __AuditDetail.DetailsClass.PropertySetProperties.AuditID)
            End Get
            Set
                __AuditDetail.DetailsClass.SetValue(Me, __AuditDetail.DetailsClass.PropertySetProperties.AuditID, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub AuditID_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub AuditID_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub AuditID_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property AuditDesc As String
            Get
                Return __AuditDetail.DetailsClass.GetValue(Me, __AuditDetail.DetailsClass.PropertySetProperties.AuditDesc)
            End Get
            Set
                __AuditDetail.DetailsClass.SetValue(Me, __AuditDetail.DetailsClass.PropertySetProperties.AuditDesc, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub AuditDesc_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub AuditDesc_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub AuditDesc_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property LoginName As String
            Get
                Return __AuditDetail.DetailsClass.GetValue(Me, __AuditDetail.DetailsClass.PropertySetProperties.LoginName)
            End Get
            Set
                __AuditDetail.DetailsClass.SetValue(Me, __AuditDetail.DetailsClass.PropertySetProperties.LoginName, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub LoginName_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub LoginName_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub LoginName_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property AuditDate As Global.System.Nullable(Of Date)
            Get
                Return __AuditDetail.DetailsClass.GetValue(Me, __AuditDetail.DetailsClass.PropertySetProperties.AuditDate)
            End Get
            Set
                __AuditDetail.DetailsClass.SetValue(Me, __AuditDetail.DetailsClass.PropertySetProperties.AuditDate, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub AuditDate_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub AuditDate_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub AuditDate_Changed()
        End Sub

        #End Region
    
        #Region "Details Class"
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public NotInheritable Class DetailsClass
            Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of _
                __AuditDetail, _
                __AuditDetail.DetailsClass, _
                __AuditDetail.DetailsClass.IImplementation, _
                __AuditDetail.DetailsClass.PropertySet, _
                Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __AuditDetail, __AuditDetail.DetailsClass), _
                Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __AuditDetail, __AuditDetail.DetailsClass))
    
            Shared Sub New()
                Dim initializeEntry = __AuditDetail.DetailsClass.PropertySetProperties.AuditID
            End Sub
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private Shared ReadOnly __AuditDetailEntry As Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __AuditDetail, __AuditDetail.DetailsClass).Entry = _
                New Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __AuditDetail, __AuditDetail.DetailsClass).Entry( _
                    AddressOf __AuditDetail.DetailsClass.__AuditDetail_CreateNew, _
                    AddressOf __AuditDetail.DetailsClass.__AuditDetail_Created, _
                    AddressOf __AuditDetail.DetailsClass.__AuditDetail_AllowSaveWithErrors)
            Private Shared Function __AuditDetail_CreateNew(es As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __AuditDetail)) As __AuditDetail
                Return New __AuditDetail(es)
            End Function
            Private Shared Sub __AuditDetail_Created(e As __AuditDetail)
                e.AuditDetail_Created()
            End Sub
            Private Shared Function __AuditDetail_AllowSaveWithErrors(e As __AuditDetail) As Boolean
                Dim result As Boolean = False
                e.AuditDetail_AllowSaveWithErrors(result)
                Return result
            End Function
    
            Public Sub New()
                MyBase.New()
            End Sub
    
            Public ReadOnly Shadows Property Commands As Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __AuditDetail, __AuditDetail.DetailsClass)
                Get
                    Return MyBase.Commands
                End Get
            End Property
    
            Public ReadOnly Shadows Property Methods As Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __AuditDetail, __AuditDetail.DetailsClass)
                Get
                    Return MyBase.Methods
                End Get
            End Property
    
            Public ReadOnly Shadows Property Properties As __AuditDetail.DetailsClass.PropertySet
                Get
                    Return MyBase.Properties
                End Get
            End Property
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class PropertySet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet(Of __AuditDetail, __AuditDetail.DetailsClass)
    
                Public Sub New()
                    MyBase.New()
                End Sub
    
                Public ReadOnly Property AuditID As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, Integer)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__AuditDetail.DetailsClass.PropertySetProperties.AuditID),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, Integer))
                    End Get
                End Property
                
                Public ReadOnly Property AuditDesc As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, String)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__AuditDetail.DetailsClass.PropertySetProperties.AuditDesc),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, String))
                    End Get
                End Property
                
                Public ReadOnly Property LoginName As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, String)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__AuditDetail.DetailsClass.PropertySetProperties.LoginName),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, String))
                    End Get
                End Property
                
                Public ReadOnly Property AuditDate As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, Global.System.Nullable(Of Date))
                    Get
                        Return TryCast(
                            MyBase.GetItem(__AuditDetail.DetailsClass.PropertySetProperties.AuditDate),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, Global.System.Nullable(Of Date)))
                    End Get
                End Property
                
            End Class
    
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            Public Interface IImplementation
                Inherits Global.Microsoft.LightSwitch.Internal.IEntityImplementation
    
                Shadows Property AuditID As Integer
                Shadows Property AuditDesc As String
                Shadows Property LoginName As String
                Shadows Property AuditDate As Global.System.Nullable(Of Date)
    
            End Interface
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend Class PropertySetProperties
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly AuditID As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, Integer).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, Integer).Entry( _
                        "AuditID", _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._AuditID_Stub, _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._AuditID_ComputeIsReadOnly, _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._AuditID_Validate, _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._AuditID_GetImplementationValue, _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._AuditID_SetImplementationValue, _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._AuditID_OnValueChanged)
                Private Shared Sub _AuditID_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __AuditDetail.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, Integer).Data), d As __AuditDetail.DetailsClass, sf As Object)
                    c(d, d._AuditID, sf)
                End Sub
                Private Shared Function _AuditID_ComputeIsReadOnly(e As __AuditDetail) As Boolean
                    Dim result As Boolean = False
                    e.AuditID_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _AuditID_Validate(e As __AuditDetail, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.AuditID_Validate(r)
                End Sub
                Private Shared Function _AuditID_GetImplementationValue(d As __AuditDetail.DetailsClass) As Integer
                    Return d.ImplementationEntity.AuditID
                End Function
                Private Shared Sub _AuditID_SetImplementationValue(d As __AuditDetail.DetailsClass, v As Integer)
                    d.ImplementationEntity.AuditID = v
                End Sub
                Private Shared Sub _AuditID_OnValueChanged(e As __AuditDetail)
                    e.AuditID_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly AuditDesc As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, String).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, String).Entry( _
                        "AuditDesc", _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._AuditDesc_Stub, _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._AuditDesc_ComputeIsReadOnly, _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._AuditDesc_Validate, _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._AuditDesc_GetImplementationValue, _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._AuditDesc_SetImplementationValue, _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._AuditDesc_OnValueChanged)
                Private Shared Sub _AuditDesc_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __AuditDetail.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, String).Data), d As __AuditDetail.DetailsClass, sf As Object)
                    c(d, d._AuditDesc, sf)
                End Sub
                Private Shared Function _AuditDesc_ComputeIsReadOnly(e As __AuditDetail) As Boolean
                    Dim result As Boolean = False
                    e.AuditDesc_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _AuditDesc_Validate(e As __AuditDetail, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.AuditDesc_Validate(r)
                End Sub
                Private Shared Function _AuditDesc_GetImplementationValue(d As __AuditDetail.DetailsClass) As String
                    Return d.ImplementationEntity.AuditDesc
                End Function
                Private Shared Sub _AuditDesc_SetImplementationValue(d As __AuditDetail.DetailsClass, v As String)
                    d.ImplementationEntity.AuditDesc = v
                End Sub
                Private Shared Sub _AuditDesc_OnValueChanged(e As __AuditDetail)
                    e.AuditDesc_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly LoginName As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, String).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, String).Entry( _
                        "LoginName", _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._LoginName_Stub, _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._LoginName_ComputeIsReadOnly, _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._LoginName_Validate, _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._LoginName_GetImplementationValue, _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._LoginName_SetImplementationValue, _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._LoginName_OnValueChanged)
                Private Shared Sub _LoginName_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __AuditDetail.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, String).Data), d As __AuditDetail.DetailsClass, sf As Object)
                    c(d, d._LoginName, sf)
                End Sub
                Private Shared Function _LoginName_ComputeIsReadOnly(e As __AuditDetail) As Boolean
                    Dim result As Boolean = False
                    e.LoginName_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _LoginName_Validate(e As __AuditDetail, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.LoginName_Validate(r)
                End Sub
                Private Shared Function _LoginName_GetImplementationValue(d As __AuditDetail.DetailsClass) As String
                    Return d.ImplementationEntity.LoginName
                End Function
                Private Shared Sub _LoginName_SetImplementationValue(d As __AuditDetail.DetailsClass, v As String)
                    d.ImplementationEntity.LoginName = v
                End Sub
                Private Shared Sub _LoginName_OnValueChanged(e As __AuditDetail)
                    e.LoginName_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly AuditDate As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, Global.System.Nullable(Of Date)).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, Global.System.Nullable(Of Date)).Entry( _
                        "AuditDate", _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._AuditDate_Stub, _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._AuditDate_ComputeIsReadOnly, _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._AuditDate_Validate, _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._AuditDate_GetImplementationValue, _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._AuditDate_SetImplementationValue, _
                        AddressOf __AuditDetail.DetailsClass.PropertySetProperties._AuditDate_OnValueChanged)
                Private Shared Sub _AuditDate_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __AuditDetail.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, Global.System.Nullable(Of Date)).Data), d As __AuditDetail.DetailsClass, sf As Object)
                    c(d, d._AuditDate, sf)
                End Sub
                Private Shared Function _AuditDate_ComputeIsReadOnly(e As __AuditDetail) As Boolean
                    Dim result As Boolean = False
                    e.AuditDate_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _AuditDate_Validate(e As __AuditDetail, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.AuditDate_Validate(r)
                End Sub
                Private Shared Function _AuditDate_GetImplementationValue(d As __AuditDetail.DetailsClass) As Global.System.Nullable(Of Date)
                    Return d.ImplementationEntity.AuditDate
                End Function
                Private Shared Sub _AuditDate_SetImplementationValue(d As __AuditDetail.DetailsClass, v As Global.System.Nullable(Of Date))
                    d.ImplementationEntity.AuditDate = __AuditDetail.DetailsClass.ClearDateTimeKind(v)
                End Sub
                Private Shared Sub _AuditDate_OnValueChanged(e As __AuditDetail)
                    e.AuditDate_Changed()
                End Sub
    
            End Class
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _AuditID As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, Integer).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _AuditDesc As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, String).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _LoginName As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, String).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _AuditDate As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __AuditDetail, __AuditDetail.DetailsClass, Global.System.Nullable(Of Date)).Data
            
        End Class
    
        #End Region
    
    End Class
    
    #End Region
End Namespace
