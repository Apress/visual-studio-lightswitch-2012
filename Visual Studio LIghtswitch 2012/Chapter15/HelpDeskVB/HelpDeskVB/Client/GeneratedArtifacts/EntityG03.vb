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

Imports __IssueStatus = LightSwitchApplication.IssueStatus

Namespace LightSwitchApplication

    #Region "Entities"
    
    ''' <summary>
    ''' No Modeled Description Available
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")> _
    Public NotInheritable Partial Class IssueStatus
        Inherits Global.Microsoft.LightSwitch.Framework.Base.EntityObject(Of __IssueStatus, __IssueStatus.DetailsClass)
    
        #Region "Constructors"
    
        ''' <summary>
        ''' Initializes a new instance of the IssueStatus entity.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New()
            Me.New(Nothing)
        End Sub
    
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New(entitySet As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __IssueStatus))
            MyBase.New(entitySet)
            
            __IssueStatus.DetailsClass.Initialize(Me)
        End Sub
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub IssueStatus_Created()
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub IssueStatus_AllowSaveWithErrors(ByRef result As Boolean)
        End Sub
    
        #End Region
    
        #Region "Private Properties"
        
        ''' <summary>
        ''' Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Private ReadOnly Property Application As Global.Microsoft.LightSwitch.IApplication(Of Global.LightSwitchApplication.DataWorkspace)
            Get
                Return TryCast(Global.LightSwitchApplication.Application.Current, Global.Microsoft.LightSwitch.IApplication(Of Global.LightSwitchApplication.DataWorkspace))
            End Get
        End Property
        
        ''' <summary>
        ''' Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")> _
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
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Id As Integer
            Get
                Return __IssueStatus.DetailsClass.GetValue(Me, __IssueStatus.DetailsClass.PropertySetProperties.Id)
            End Get
            Set
                __IssueStatus.DetailsClass.SetValue(Me, __IssueStatus.DetailsClass.PropertySetProperties.Id, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Id_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Id_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Id_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property RowVersion As Byte()
            Get
                Return __IssueStatus.DetailsClass.GetValue(Me, __IssueStatus.DetailsClass.PropertySetProperties.RowVersion)
            End Get
            Set
                __IssueStatus.DetailsClass.SetValue(Me, __IssueStatus.DetailsClass.PropertySetProperties.RowVersion, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RowVersion_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RowVersion_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RowVersion_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property StatusDescription As String
            Get
                Return __IssueStatus.DetailsClass.GetValue(Me, __IssueStatus.DetailsClass.PropertySetProperties.StatusDescription)
            End Get
            Set
                __IssueStatus.DetailsClass.SetValue(Me, __IssueStatus.DetailsClass.PropertySetProperties.StatusDescription, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub StatusDescription_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub StatusDescription_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub StatusDescription_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public ReadOnly Property Issues As Global.Microsoft.LightSwitch.Framework.EntityCollection(Of Global.LightSwitchApplication.Issue)
            Get
                Return __IssueStatus.DetailsClass.GetValue(Me, __IssueStatus.DetailsClass.PropertySetProperties.Issues)
            End Get
        End Property
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public ReadOnly Property IssuesQuery As Microsoft.LightSwitch.IDataServiceQueryable(Of Global.LightSwitchApplication.Issue)
            Get
                Return __IssueStatus.DetailsClass.GetQuery(Me, __IssueStatus.DetailsClass.PropertySetProperties.Issues)
            End Get
        End Property

        #End Region
    
        #Region "Details Class"
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public NotInheritable Class DetailsClass
            Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of _
                __IssueStatus, _
                __IssueStatus.DetailsClass, _
                __IssueStatus.DetailsClass.IImplementation, _
                __IssueStatus.DetailsClass.PropertySet, _
                Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __IssueStatus, __IssueStatus.DetailsClass), _
                Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __IssueStatus, __IssueStatus.DetailsClass))
    
            Shared Sub New()
                Dim initializeEntry = __IssueStatus.DetailsClass.PropertySetProperties.Id
            End Sub
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private Shared ReadOnly __IssueStatusEntry As Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __IssueStatus, __IssueStatus.DetailsClass).Entry = _
                New Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __IssueStatus, __IssueStatus.DetailsClass).Entry( _
                    AddressOf __IssueStatus.DetailsClass.__IssueStatus_CreateNew, _
                    AddressOf __IssueStatus.DetailsClass.__IssueStatus_Created, _
                    AddressOf __IssueStatus.DetailsClass.__IssueStatus_AllowSaveWithErrors)
            Private Shared Function __IssueStatus_CreateNew(es As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __IssueStatus)) As __IssueStatus
                Return New __IssueStatus(es)
            End Function
            Private Shared Sub __IssueStatus_Created(e As __IssueStatus)
                e.IssueStatus_Created()
            End Sub
            Private Shared Function __IssueStatus_AllowSaveWithErrors(e As __IssueStatus) As Boolean
                Dim result As Boolean = False
                e.IssueStatus_AllowSaveWithErrors(result)
                Return result
            End Function
    
            Public Sub New()
                MyBase.New()
            End Sub
    
            Public ReadOnly Shadows Property Commands As Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __IssueStatus, __IssueStatus.DetailsClass)
                Get
                    Return MyBase.Commands
                End Get
            End Property
    
            Public ReadOnly Shadows Property Methods As Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __IssueStatus, __IssueStatus.DetailsClass)
                Get
                    Return MyBase.Methods
                End Get
            End Property
    
            Public ReadOnly Shadows Property Properties As __IssueStatus.DetailsClass.PropertySet
                Get
                    Return MyBase.Properties
                End Get
            End Property
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class PropertySet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet(Of __IssueStatus, __IssueStatus.DetailsClass)
    
                Public Sub New()
                    MyBase.New()
                End Sub
    
                Public ReadOnly Property Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueStatus, __IssueStatus.DetailsClass, Integer)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__IssueStatus.DetailsClass.PropertySetProperties.Id),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueStatus, __IssueStatus.DetailsClass, Integer))
                    End Get
                End Property
                
                Public ReadOnly Property RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueStatus, __IssueStatus.DetailsClass, Byte())
                    Get
                        Return TryCast(
                            MyBase.GetItem(__IssueStatus.DetailsClass.PropertySetProperties.RowVersion),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueStatus, __IssueStatus.DetailsClass, Byte()))
                    End Get
                End Property
                
                Public ReadOnly Property StatusDescription As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueStatus, __IssueStatus.DetailsClass, String)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__IssueStatus.DetailsClass.PropertySetProperties.StatusDescription),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueStatus, __IssueStatus.DetailsClass, String))
                    End Get
                End Property
                
                Public ReadOnly Property Issues As Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __IssueStatus, __IssueStatus.DetailsClass, Global.LightSwitchApplication.Issue)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__IssueStatus.DetailsClass.PropertySetProperties.Issues),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __IssueStatus, __IssueStatus.DetailsClass, Global.LightSwitchApplication.Issue))
                    End Get
                End Property
                
            End Class
    
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            Public Interface IImplementation
                Inherits Global.Microsoft.LightSwitch.Internal.IEntityImplementation
    
                Shadows Property Id As Integer
                Shadows Property RowVersion As Byte()
                Shadows Property StatusDescription As String
                Shadows ReadOnly Property Issues As Global.System.Collections.IEnumerable
    
            End Interface
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend Class PropertySetProperties
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueStatus, __IssueStatus.DetailsClass, Integer).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueStatus, __IssueStatus.DetailsClass, Integer).Entry( _
                        "Id", _
                        AddressOf __IssueStatus.DetailsClass.PropertySetProperties._Id_Stub, _
                        AddressOf __IssueStatus.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly, _
                        AddressOf __IssueStatus.DetailsClass.PropertySetProperties._Id_Validate, _
                        AddressOf __IssueStatus.DetailsClass.PropertySetProperties._Id_GetImplementationValue, _
                        AddressOf __IssueStatus.DetailsClass.PropertySetProperties._Id_SetImplementationValue, _
                        AddressOf __IssueStatus.DetailsClass.PropertySetProperties._Id_OnValueChanged)
                Private Shared Sub _Id_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __IssueStatus.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueStatus, __IssueStatus.DetailsClass, Integer).Data), d As __IssueStatus.DetailsClass, sf As Object)
                    c(d, d._Id, sf)
                End Sub
                Private Shared Function _Id_ComputeIsReadOnly(e As __IssueStatus) As Boolean
                    Dim result As Boolean = False
                    e.Id_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Id_Validate(e As __IssueStatus, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Id_Validate(r)
                End Sub
                Private Shared Function _Id_GetImplementationValue(d As __IssueStatus.DetailsClass) As Integer
                    Return d.ImplementationEntity.Id
                End Function
                Private Shared Sub _Id_SetImplementationValue(d As __IssueStatus.DetailsClass, v As Integer)
                    d.ImplementationEntity.Id = v
                End Sub
                Private Shared Sub _Id_OnValueChanged(e As __IssueStatus)
                    e.Id_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueStatus, __IssueStatus.DetailsClass, Byte()).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueStatus, __IssueStatus.DetailsClass, Byte()).Entry( _
                        "RowVersion", _
                        AddressOf __IssueStatus.DetailsClass.PropertySetProperties._RowVersion_Stub, _
                        AddressOf __IssueStatus.DetailsClass.PropertySetProperties._RowVersion_ComputeIsReadOnly, _
                        AddressOf __IssueStatus.DetailsClass.PropertySetProperties._RowVersion_Validate, _
                        AddressOf __IssueStatus.DetailsClass.PropertySetProperties._RowVersion_GetImplementationValue, _
                        AddressOf __IssueStatus.DetailsClass.PropertySetProperties._RowVersion_SetImplementationValue, _
                        AddressOf __IssueStatus.DetailsClass.PropertySetProperties._RowVersion_OnValueChanged)
                Private Shared Sub _RowVersion_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __IssueStatus.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueStatus, __IssueStatus.DetailsClass, Byte()).Data), d As __IssueStatus.DetailsClass, sf As Object)
                    c(d, d._RowVersion, sf)
                End Sub
                Private Shared Function _RowVersion_ComputeIsReadOnly(e As __IssueStatus) As Boolean
                    Dim result As Boolean = False
                    e.RowVersion_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _RowVersion_Validate(e As __IssueStatus, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.RowVersion_Validate(r)
                End Sub
                Private Shared Function _RowVersion_GetImplementationValue(d As __IssueStatus.DetailsClass) As Byte()
                    Return d.ImplementationEntity.RowVersion
                End Function
                Private Shared Sub _RowVersion_SetImplementationValue(d As __IssueStatus.DetailsClass, v As Byte())
                    d.ImplementationEntity.RowVersion = v
                End Sub
                Private Shared Sub _RowVersion_OnValueChanged(e As __IssueStatus)
                    e.RowVersion_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly StatusDescription As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueStatus, __IssueStatus.DetailsClass, String).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueStatus, __IssueStatus.DetailsClass, String).Entry( _
                        "StatusDescription", _
                        AddressOf __IssueStatus.DetailsClass.PropertySetProperties._StatusDescription_Stub, _
                        AddressOf __IssueStatus.DetailsClass.PropertySetProperties._StatusDescription_ComputeIsReadOnly, _
                        AddressOf __IssueStatus.DetailsClass.PropertySetProperties._StatusDescription_Validate, _
                        AddressOf __IssueStatus.DetailsClass.PropertySetProperties._StatusDescription_GetImplementationValue, _
                        AddressOf __IssueStatus.DetailsClass.PropertySetProperties._StatusDescription_SetImplementationValue, _
                        AddressOf __IssueStatus.DetailsClass.PropertySetProperties._StatusDescription_OnValueChanged)
                Private Shared Sub _StatusDescription_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __IssueStatus.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueStatus, __IssueStatus.DetailsClass, String).Data), d As __IssueStatus.DetailsClass, sf As Object)
                    c(d, d._StatusDescription, sf)
                End Sub
                Private Shared Function _StatusDescription_ComputeIsReadOnly(e As __IssueStatus) As Boolean
                    Dim result As Boolean = False
                    e.StatusDescription_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _StatusDescription_Validate(e As __IssueStatus, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.StatusDescription_Validate(r)
                End Sub
                Private Shared Function _StatusDescription_GetImplementationValue(d As __IssueStatus.DetailsClass) As String
                    Return d.ImplementationEntity.StatusDescription
                End Function
                Private Shared Sub _StatusDescription_SetImplementationValue(d As __IssueStatus.DetailsClass, v As String)
                    d.ImplementationEntity.StatusDescription = v
                End Sub
                Private Shared Sub _StatusDescription_OnValueChanged(e As __IssueStatus)
                    e.StatusDescription_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Issues As Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __IssueStatus, __IssueStatus.DetailsClass, Global.LightSwitchApplication.Issue).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __IssueStatus, __IssueStatus.DetailsClass, Global.LightSwitchApplication.Issue).Entry( _
                        "Issues", _
                        AddressOf __IssueStatus.DetailsClass.PropertySetProperties._Issues_Stub, _
                        AddressOf __IssueStatus.DetailsClass.PropertySetProperties._Issues_GetReferencedEntities, _
                        AddressOf __IssueStatus.DetailsClass.PropertySetProperties._Issues_GetEntityCollection)
                Private Shared Sub _Issues_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __IssueStatus.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __IssueStatus, __IssueStatus.DetailsClass, Global.LightSwitchApplication.Issue).Data), d As __IssueStatus.DetailsClass, sf As Object)
                    c(d, d._Issues, sf)
                End Sub
                Private Shared Function _Issues_GetReferencedEntities(d As __IssueStatus.DetailsClass) As Global.System.Collections.Generic.IEnumerable(Of Global.LightSwitchApplication.Issue)
                    Return d.GetReferencedEntities(Of Global.LightSwitchApplication.Issue, Global.LightSwitchApplication.Issue.DetailsClass)(__IssueStatus.DetailsClass.PropertySetProperties.Issues, d._Issues)
                End Function
                Private Shared Function _Issues_GetEntityCollection(d As __IssueStatus.DetailsClass) As Global.System.Collections.IEnumerable
                    Return d.ImplementationEntity.Issues
                End Function
    
            End Class
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueStatus, __IssueStatus.DetailsClass, Integer).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueStatus, __IssueStatus.DetailsClass, Byte()).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _StatusDescription As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueStatus, __IssueStatus.DetailsClass, String).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Issues As Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __IssueStatus, __IssueStatus.DetailsClass, Global.LightSwitchApplication.Issue).Data
            
        End Class
    
        #End Region
    
    End Class
    
    #End Region
End Namespace
