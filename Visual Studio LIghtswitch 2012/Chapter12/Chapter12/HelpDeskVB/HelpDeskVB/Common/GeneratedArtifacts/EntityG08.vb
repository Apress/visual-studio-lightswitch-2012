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

Imports __Priority = LightSwitchApplication.Priority

Namespace LightSwitchApplication

    #Region "Entities"
    
    ''' <summary>
    ''' No Modeled Description Available
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
    Public NotInheritable Partial Class Priority
        Inherits Global.Microsoft.LightSwitch.Framework.Base.EntityObject(Of __Priority, __Priority.DetailsClass)
    
        #Region "Constructors"
    
        ''' <summary>
        ''' Initializes a new instance of the Priority entity.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New()
            Me.New(Nothing)
        End Sub
    
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New(entitySet As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __Priority))
            MyBase.New(entitySet)
            
            __Priority.DetailsClass.Initialize(Me)
        End Sub
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Priority_Created()
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Priority_AllowSaveWithErrors(ByRef result As Boolean)
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
        Public Property Id As Integer
            Get
                Return __Priority.DetailsClass.GetValue(Me, __Priority.DetailsClass.PropertySetProperties.Id)
            End Get
            Set
                __Priority.DetailsClass.SetValue(Me, __Priority.DetailsClass.PropertySetProperties.Id, Value)
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
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property RowVersion As Byte()
            Get
                Return __Priority.DetailsClass.GetValue(Me, __Priority.DetailsClass.PropertySetProperties.RowVersion)
            End Get
            Set
                __Priority.DetailsClass.SetValue(Me, __Priority.DetailsClass.PropertySetProperties.RowVersion, Value)
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
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property PriorityDesc As String
            Get
                Return __Priority.DetailsClass.GetValue(Me, __Priority.DetailsClass.PropertySetProperties.PriorityDesc)
            End Get
            Set
                __Priority.DetailsClass.SetValue(Me, __Priority.DetailsClass.PropertySetProperties.PriorityDesc, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub PriorityDesc_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub PriorityDesc_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub PriorityDesc_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public ReadOnly Property Issues As Global.Microsoft.LightSwitch.Framework.EntityCollection(Of Global.LightSwitchApplication.Issue)
            Get
                Return __Priority.DetailsClass.GetValue(Me, __Priority.DetailsClass.PropertySetProperties.Issues)
            End Get
        End Property
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public ReadOnly Property IssuesQuery As Microsoft.LightSwitch.IDataServiceQueryable(Of Global.LightSwitchApplication.Issue)
            Get
                Return __Priority.DetailsClass.GetQuery(Me, __Priority.DetailsClass.PropertySetProperties.Issues)
            End Get
        End Property

        #End Region
    
        #Region "Details Class"
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public NotInheritable Class DetailsClass
            Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of _
                __Priority, _
                __Priority.DetailsClass, _
                __Priority.DetailsClass.IImplementation, _
                __Priority.DetailsClass.PropertySet, _
                Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __Priority, __Priority.DetailsClass), _
                Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __Priority, __Priority.DetailsClass))
    
            Shared Sub New()
                Dim initializeEntry = __Priority.DetailsClass.PropertySetProperties.Id
            End Sub
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private Shared ReadOnly __PriorityEntry As Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __Priority, __Priority.DetailsClass).Entry = _
                New Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __Priority, __Priority.DetailsClass).Entry( _
                    AddressOf __Priority.DetailsClass.__Priority_CreateNew, _
                    AddressOf __Priority.DetailsClass.__Priority_Created, _
                    AddressOf __Priority.DetailsClass.__Priority_AllowSaveWithErrors)
            Private Shared Function __Priority_CreateNew(es As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __Priority)) As __Priority
                Return New __Priority(es)
            End Function
            Private Shared Sub __Priority_Created(e As __Priority)
                e.Priority_Created()
            End Sub
            Private Shared Function __Priority_AllowSaveWithErrors(e As __Priority) As Boolean
                Dim result As Boolean = False
                e.Priority_AllowSaveWithErrors(result)
                Return result
            End Function
    
            Public Sub New()
                MyBase.New()
            End Sub
    
            Public ReadOnly Shadows Property Commands As Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __Priority, __Priority.DetailsClass)
                Get
                    Return MyBase.Commands
                End Get
            End Property
    
            Public ReadOnly Shadows Property Methods As Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __Priority, __Priority.DetailsClass)
                Get
                    Return MyBase.Methods
                End Get
            End Property
    
            Public ReadOnly Shadows Property Properties As __Priority.DetailsClass.PropertySet
                Get
                    Return MyBase.Properties
                End Get
            End Property
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class PropertySet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet(Of __Priority, __Priority.DetailsClass)
    
                Public Sub New()
                    MyBase.New()
                End Sub
    
                Public ReadOnly Property Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Priority, __Priority.DetailsClass, Integer)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Priority.DetailsClass.PropertySetProperties.Id),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Priority, __Priority.DetailsClass, Integer))
                    End Get
                End Property
                
                Public ReadOnly Property RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Priority, __Priority.DetailsClass, Byte())
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Priority.DetailsClass.PropertySetProperties.RowVersion),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Priority, __Priority.DetailsClass, Byte()))
                    End Get
                End Property
                
                Public ReadOnly Property PriorityDesc As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Priority, __Priority.DetailsClass, String)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Priority.DetailsClass.PropertySetProperties.PriorityDesc),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Priority, __Priority.DetailsClass, String))
                    End Get
                End Property
                
                Public ReadOnly Property Issues As Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __Priority, __Priority.DetailsClass, Global.LightSwitchApplication.Issue)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Priority.DetailsClass.PropertySetProperties.Issues),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __Priority, __Priority.DetailsClass, Global.LightSwitchApplication.Issue))
                    End Get
                End Property
                
            End Class
    
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            Public Interface IImplementation
                Inherits Global.Microsoft.LightSwitch.Internal.IEntityImplementation
    
                Shadows Property Id As Integer
                Shadows Property RowVersion As Byte()
                Shadows Property PriorityDesc As String
                Shadows ReadOnly Property Issues As Global.System.Collections.IEnumerable
    
            End Interface
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend Class PropertySetProperties
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Priority, __Priority.DetailsClass, Integer).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Priority, __Priority.DetailsClass, Integer).Entry( _
                        "Id", _
                        AddressOf __Priority.DetailsClass.PropertySetProperties._Id_Stub, _
                        AddressOf __Priority.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly, _
                        AddressOf __Priority.DetailsClass.PropertySetProperties._Id_Validate, _
                        AddressOf __Priority.DetailsClass.PropertySetProperties._Id_GetImplementationValue, _
                        AddressOf __Priority.DetailsClass.PropertySetProperties._Id_SetImplementationValue, _
                        AddressOf __Priority.DetailsClass.PropertySetProperties._Id_OnValueChanged)
                Private Shared Sub _Id_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Priority.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Priority, __Priority.DetailsClass, Integer).Data), d As __Priority.DetailsClass, sf As Object)
                    c(d, d._Id, sf)
                End Sub
                Private Shared Function _Id_ComputeIsReadOnly(e As __Priority) As Boolean
                    Dim result As Boolean = False
                    e.Id_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Id_Validate(e As __Priority, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Id_Validate(r)
                End Sub
                Private Shared Function _Id_GetImplementationValue(d As __Priority.DetailsClass) As Integer
                    Return d.ImplementationEntity.Id
                End Function
                Private Shared Sub _Id_SetImplementationValue(d As __Priority.DetailsClass, v As Integer)
                    d.ImplementationEntity.Id = v
                End Sub
                Private Shared Sub _Id_OnValueChanged(e As __Priority)
                    e.Id_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Priority, __Priority.DetailsClass, Byte()).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Priority, __Priority.DetailsClass, Byte()).Entry( _
                        "RowVersion", _
                        AddressOf __Priority.DetailsClass.PropertySetProperties._RowVersion_Stub, _
                        AddressOf __Priority.DetailsClass.PropertySetProperties._RowVersion_ComputeIsReadOnly, _
                        AddressOf __Priority.DetailsClass.PropertySetProperties._RowVersion_Validate, _
                        AddressOf __Priority.DetailsClass.PropertySetProperties._RowVersion_GetImplementationValue, _
                        AddressOf __Priority.DetailsClass.PropertySetProperties._RowVersion_SetImplementationValue, _
                        AddressOf __Priority.DetailsClass.PropertySetProperties._RowVersion_OnValueChanged)
                Private Shared Sub _RowVersion_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Priority.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Priority, __Priority.DetailsClass, Byte()).Data), d As __Priority.DetailsClass, sf As Object)
                    c(d, d._RowVersion, sf)
                End Sub
                Private Shared Function _RowVersion_ComputeIsReadOnly(e As __Priority) As Boolean
                    Dim result As Boolean = False
                    e.RowVersion_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _RowVersion_Validate(e As __Priority, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.RowVersion_Validate(r)
                End Sub
                Private Shared Function _RowVersion_GetImplementationValue(d As __Priority.DetailsClass) As Byte()
                    Return d.ImplementationEntity.RowVersion
                End Function
                Private Shared Sub _RowVersion_SetImplementationValue(d As __Priority.DetailsClass, v As Byte())
                    d.ImplementationEntity.RowVersion = v
                End Sub
                Private Shared Sub _RowVersion_OnValueChanged(e As __Priority)
                    e.RowVersion_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly PriorityDesc As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Priority, __Priority.DetailsClass, String).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Priority, __Priority.DetailsClass, String).Entry( _
                        "PriorityDesc", _
                        AddressOf __Priority.DetailsClass.PropertySetProperties._PriorityDesc_Stub, _
                        AddressOf __Priority.DetailsClass.PropertySetProperties._PriorityDesc_ComputeIsReadOnly, _
                        AddressOf __Priority.DetailsClass.PropertySetProperties._PriorityDesc_Validate, _
                        AddressOf __Priority.DetailsClass.PropertySetProperties._PriorityDesc_GetImplementationValue, _
                        AddressOf __Priority.DetailsClass.PropertySetProperties._PriorityDesc_SetImplementationValue, _
                        AddressOf __Priority.DetailsClass.PropertySetProperties._PriorityDesc_OnValueChanged)
                Private Shared Sub _PriorityDesc_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Priority.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Priority, __Priority.DetailsClass, String).Data), d As __Priority.DetailsClass, sf As Object)
                    c(d, d._PriorityDesc, sf)
                End Sub
                Private Shared Function _PriorityDesc_ComputeIsReadOnly(e As __Priority) As Boolean
                    Dim result As Boolean = False
                    e.PriorityDesc_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _PriorityDesc_Validate(e As __Priority, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.PriorityDesc_Validate(r)
                End Sub
                Private Shared Function _PriorityDesc_GetImplementationValue(d As __Priority.DetailsClass) As String
                    Return d.ImplementationEntity.PriorityDesc
                End Function
                Private Shared Sub _PriorityDesc_SetImplementationValue(d As __Priority.DetailsClass, v As String)
                    d.ImplementationEntity.PriorityDesc = v
                End Sub
                Private Shared Sub _PriorityDesc_OnValueChanged(e As __Priority)
                    e.PriorityDesc_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Issues As Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __Priority, __Priority.DetailsClass, Global.LightSwitchApplication.Issue).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __Priority, __Priority.DetailsClass, Global.LightSwitchApplication.Issue).Entry( _
                        "Issues", _
                        AddressOf __Priority.DetailsClass.PropertySetProperties._Issues_Stub, _
                        AddressOf __Priority.DetailsClass.PropertySetProperties._Issues_GetReferencedEntities, _
                        AddressOf __Priority.DetailsClass.PropertySetProperties._Issues_GetEntityCollection)
                Private Shared Sub _Issues_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Priority.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __Priority, __Priority.DetailsClass, Global.LightSwitchApplication.Issue).Data), d As __Priority.DetailsClass, sf As Object)
                    c(d, d._Issues, sf)
                End Sub
                Private Shared Function _Issues_GetReferencedEntities(d As __Priority.DetailsClass) As Global.System.Collections.Generic.IEnumerable(Of Global.LightSwitchApplication.Issue)
                    Return d.GetReferencedEntities(Of Global.LightSwitchApplication.Issue, Global.LightSwitchApplication.Issue.DetailsClass)(__Priority.DetailsClass.PropertySetProperties.Issues, d._Issues)
                End Function
                Private Shared Function _Issues_GetEntityCollection(d As __Priority.DetailsClass) As Global.System.Collections.IEnumerable
                    Return d.ImplementationEntity.Issues
                End Function
    
            End Class
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Priority, __Priority.DetailsClass, Integer).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Priority, __Priority.DetailsClass, Byte()).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _PriorityDesc As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Priority, __Priority.DetailsClass, String).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Issues As Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __Priority, __Priority.DetailsClass, Global.LightSwitchApplication.Issue).Data
            
        End Class
    
        #End Region
    
    End Class
    
    #End Region
End Namespace
