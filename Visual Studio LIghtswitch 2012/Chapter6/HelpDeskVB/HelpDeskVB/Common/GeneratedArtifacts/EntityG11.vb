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

Imports __IssueDocument = LightSwitchApplication.IssueDocument

Namespace LightSwitchApplication

    #Region "Entities"
    
    ''' <summary>
    ''' No Modeled Description Available
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
    Public NotInheritable Partial Class IssueDocument
        Inherits Global.Microsoft.LightSwitch.Framework.Base.EntityObject(Of __IssueDocument, __IssueDocument.DetailsClass)
    
        #Region "Constructors"
    
        ''' <summary>
        ''' Initializes a new instance of the IssueDocument entity.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New()
            Me.New(Nothing)
        End Sub
    
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New(entitySet As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __IssueDocument))
            MyBase.New(entitySet)
            
            __IssueDocument.DetailsClass.Initialize(Me)
        End Sub
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub IssueDocument_Created()
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub IssueDocument_AllowSaveWithErrors(ByRef result As Boolean)
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
                Return __IssueDocument.DetailsClass.GetValue(Me, __IssueDocument.DetailsClass.PropertySetProperties.Id)
            End Get
            Set
                __IssueDocument.DetailsClass.SetValue(Me, __IssueDocument.DetailsClass.PropertySetProperties.Id, Value)
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
                Return __IssueDocument.DetailsClass.GetValue(Me, __IssueDocument.DetailsClass.PropertySetProperties.RowVersion)
            End Get
            Set
                __IssueDocument.DetailsClass.SetValue(Me, __IssueDocument.DetailsClass.PropertySetProperties.RowVersion, Value)
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
        Public Property DocumentName As String
            Get
                Return __IssueDocument.DetailsClass.GetValue(Me, __IssueDocument.DetailsClass.PropertySetProperties.DocumentName)
            End Get
            Set
                __IssueDocument.DetailsClass.SetValue(Me, __IssueDocument.DetailsClass.PropertySetProperties.DocumentName, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub DocumentName_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub DocumentName_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub DocumentName_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property FileExtension As String
            Get
                Return __IssueDocument.DetailsClass.GetValue(Me, __IssueDocument.DetailsClass.PropertySetProperties.FileExtension)
            End Get
            Set
                __IssueDocument.DetailsClass.SetValue(Me, __IssueDocument.DetailsClass.PropertySetProperties.FileExtension, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub FileExtension_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub FileExtension_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub FileExtension_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property IssueFile As Byte()
            Get
                Return __IssueDocument.DetailsClass.GetValue(Me, __IssueDocument.DetailsClass.PropertySetProperties.IssueFile)
            End Get
            Set
                __IssueDocument.DetailsClass.SetValue(Me, __IssueDocument.DetailsClass.PropertySetProperties.IssueFile, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub IssueFile_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub IssueFile_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub IssueFile_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Issue As Global.LightSwitchApplication.Issue
            Get
                Return __IssueDocument.DetailsClass.GetValue(Me, __IssueDocument.DetailsClass.PropertySetProperties.Issue)
            End Get
            Set
                __IssueDocument.DetailsClass.SetValue(Me, __IssueDocument.DetailsClass.PropertySetProperties.Issue, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Issue_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Issue_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Issue_Changed()
        End Sub

        #End Region
    
        #Region "Details Class"
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public NotInheritable Class DetailsClass
            Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of _
                __IssueDocument, _
                __IssueDocument.DetailsClass, _
                __IssueDocument.DetailsClass.IImplementation, _
                __IssueDocument.DetailsClass.PropertySet, _
                Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __IssueDocument, __IssueDocument.DetailsClass), _
                Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __IssueDocument, __IssueDocument.DetailsClass))
    
            Shared Sub New()
                Dim initializeEntry = __IssueDocument.DetailsClass.PropertySetProperties.Id
            End Sub
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private Shared ReadOnly __IssueDocumentEntry As Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __IssueDocument, __IssueDocument.DetailsClass).Entry = _
                New Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __IssueDocument, __IssueDocument.DetailsClass).Entry( _
                    AddressOf __IssueDocument.DetailsClass.__IssueDocument_CreateNew, _
                    AddressOf __IssueDocument.DetailsClass.__IssueDocument_Created, _
                    AddressOf __IssueDocument.DetailsClass.__IssueDocument_AllowSaveWithErrors)
            Private Shared Function __IssueDocument_CreateNew(es As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __IssueDocument)) As __IssueDocument
                Return New __IssueDocument(es)
            End Function
            Private Shared Sub __IssueDocument_Created(e As __IssueDocument)
                e.IssueDocument_Created()
            End Sub
            Private Shared Function __IssueDocument_AllowSaveWithErrors(e As __IssueDocument) As Boolean
                Dim result As Boolean = False
                e.IssueDocument_AllowSaveWithErrors(result)
                Return result
            End Function
    
            Public Sub New()
                MyBase.New()
            End Sub
    
            Public ReadOnly Shadows Property Commands As Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __IssueDocument, __IssueDocument.DetailsClass)
                Get
                    Return MyBase.Commands
                End Get
            End Property
    
            Public ReadOnly Shadows Property Methods As Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __IssueDocument, __IssueDocument.DetailsClass)
                Get
                    Return MyBase.Methods
                End Get
            End Property
    
            Public ReadOnly Shadows Property Properties As __IssueDocument.DetailsClass.PropertySet
                Get
                    Return MyBase.Properties
                End Get
            End Property
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class PropertySet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet(Of __IssueDocument, __IssueDocument.DetailsClass)
    
                Public Sub New()
                    MyBase.New()
                End Sub
    
                Public ReadOnly Property Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Integer)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__IssueDocument.DetailsClass.PropertySetProperties.Id),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Integer))
                    End Get
                End Property
                
                Public ReadOnly Property RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Byte())
                    Get
                        Return TryCast(
                            MyBase.GetItem(__IssueDocument.DetailsClass.PropertySetProperties.RowVersion),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Byte()))
                    End Get
                End Property
                
                Public ReadOnly Property DocumentName As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, String)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__IssueDocument.DetailsClass.PropertySetProperties.DocumentName),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, String))
                    End Get
                End Property
                
                Public ReadOnly Property FileExtension As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, String)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__IssueDocument.DetailsClass.PropertySetProperties.FileExtension),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, String))
                    End Get
                End Property
                
                Public ReadOnly Property IssueFile As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Byte())
                    Get
                        Return TryCast(
                            MyBase.GetItem(__IssueDocument.DetailsClass.PropertySetProperties.IssueFile),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Byte()))
                    End Get
                End Property
                
                Public ReadOnly Property Issue As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Global.LightSwitchApplication.Issue)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__IssueDocument.DetailsClass.PropertySetProperties.Issue),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Global.LightSwitchApplication.Issue))
                    End Get
                End Property
                
            End Class
    
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            Public Interface IImplementation
                Inherits Global.Microsoft.LightSwitch.Internal.IEntityImplementation
    
                Shadows Property Id As Integer
                Shadows Property RowVersion As Byte()
                Shadows Property DocumentName As String
                Shadows Property FileExtension As String
                Shadows Property IssueFile As Byte()
                Shadows Property Issue As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
    
            End Interface
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend Class PropertySetProperties
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Integer).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Integer).Entry( _
                        "Id", _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._Id_Stub, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._Id_Validate, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._Id_GetImplementationValue, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._Id_SetImplementationValue, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._Id_OnValueChanged)
                Private Shared Sub _Id_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __IssueDocument.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Integer).Data), d As __IssueDocument.DetailsClass, sf As Object)
                    c(d, d._Id, sf)
                End Sub
                Private Shared Function _Id_ComputeIsReadOnly(e As __IssueDocument) As Boolean
                    Dim result As Boolean = False
                    e.Id_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Id_Validate(e As __IssueDocument, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Id_Validate(r)
                End Sub
                Private Shared Function _Id_GetImplementationValue(d As __IssueDocument.DetailsClass) As Integer
                    Return d.ImplementationEntity.Id
                End Function
                Private Shared Sub _Id_SetImplementationValue(d As __IssueDocument.DetailsClass, v As Integer)
                    d.ImplementationEntity.Id = v
                End Sub
                Private Shared Sub _Id_OnValueChanged(e As __IssueDocument)
                    e.Id_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Byte()).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Byte()).Entry( _
                        "RowVersion", _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._RowVersion_Stub, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._RowVersion_ComputeIsReadOnly, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._RowVersion_Validate, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._RowVersion_GetImplementationValue, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._RowVersion_SetImplementationValue, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._RowVersion_OnValueChanged)
                Private Shared Sub _RowVersion_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __IssueDocument.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Byte()).Data), d As __IssueDocument.DetailsClass, sf As Object)
                    c(d, d._RowVersion, sf)
                End Sub
                Private Shared Function _RowVersion_ComputeIsReadOnly(e As __IssueDocument) As Boolean
                    Dim result As Boolean = False
                    e.RowVersion_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _RowVersion_Validate(e As __IssueDocument, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.RowVersion_Validate(r)
                End Sub
                Private Shared Function _RowVersion_GetImplementationValue(d As __IssueDocument.DetailsClass) As Byte()
                    Return d.ImplementationEntity.RowVersion
                End Function
                Private Shared Sub _RowVersion_SetImplementationValue(d As __IssueDocument.DetailsClass, v As Byte())
                    d.ImplementationEntity.RowVersion = v
                End Sub
                Private Shared Sub _RowVersion_OnValueChanged(e As __IssueDocument)
                    e.RowVersion_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly DocumentName As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, String).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, String).Entry( _
                        "DocumentName", _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._DocumentName_Stub, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._DocumentName_ComputeIsReadOnly, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._DocumentName_Validate, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._DocumentName_GetImplementationValue, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._DocumentName_SetImplementationValue, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._DocumentName_OnValueChanged)
                Private Shared Sub _DocumentName_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __IssueDocument.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, String).Data), d As __IssueDocument.DetailsClass, sf As Object)
                    c(d, d._DocumentName, sf)
                End Sub
                Private Shared Function _DocumentName_ComputeIsReadOnly(e As __IssueDocument) As Boolean
                    Dim result As Boolean = False
                    e.DocumentName_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _DocumentName_Validate(e As __IssueDocument, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.DocumentName_Validate(r)
                End Sub
                Private Shared Function _DocumentName_GetImplementationValue(d As __IssueDocument.DetailsClass) As String
                    Return d.ImplementationEntity.DocumentName
                End Function
                Private Shared Sub _DocumentName_SetImplementationValue(d As __IssueDocument.DetailsClass, v As String)
                    d.ImplementationEntity.DocumentName = v
                End Sub
                Private Shared Sub _DocumentName_OnValueChanged(e As __IssueDocument)
                    e.DocumentName_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly FileExtension As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, String).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, String).Entry( _
                        "FileExtension", _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._FileExtension_Stub, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._FileExtension_ComputeIsReadOnly, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._FileExtension_Validate, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._FileExtension_GetImplementationValue, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._FileExtension_SetImplementationValue, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._FileExtension_OnValueChanged)
                Private Shared Sub _FileExtension_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __IssueDocument.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, String).Data), d As __IssueDocument.DetailsClass, sf As Object)
                    c(d, d._FileExtension, sf)
                End Sub
                Private Shared Function _FileExtension_ComputeIsReadOnly(e As __IssueDocument) As Boolean
                    Dim result As Boolean = False
                    e.FileExtension_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _FileExtension_Validate(e As __IssueDocument, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.FileExtension_Validate(r)
                End Sub
                Private Shared Function _FileExtension_GetImplementationValue(d As __IssueDocument.DetailsClass) As String
                    Return d.ImplementationEntity.FileExtension
                End Function
                Private Shared Sub _FileExtension_SetImplementationValue(d As __IssueDocument.DetailsClass, v As String)
                    d.ImplementationEntity.FileExtension = v
                End Sub
                Private Shared Sub _FileExtension_OnValueChanged(e As __IssueDocument)
                    e.FileExtension_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly IssueFile As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Byte()).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Byte()).Entry( _
                        "IssueFile", _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._IssueFile_Stub, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._IssueFile_ComputeIsReadOnly, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._IssueFile_Validate, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._IssueFile_GetImplementationValue, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._IssueFile_SetImplementationValue, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._IssueFile_OnValueChanged)
                Private Shared Sub _IssueFile_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __IssueDocument.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Byte()).Data), d As __IssueDocument.DetailsClass, sf As Object)
                    c(d, d._IssueFile, sf)
                End Sub
                Private Shared Function _IssueFile_ComputeIsReadOnly(e As __IssueDocument) As Boolean
                    Dim result As Boolean = False
                    e.IssueFile_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _IssueFile_Validate(e As __IssueDocument, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.IssueFile_Validate(r)
                End Sub
                Private Shared Function _IssueFile_GetImplementationValue(d As __IssueDocument.DetailsClass) As Byte()
                    Return d.ImplementationEntity.IssueFile
                End Function
                Private Shared Sub _IssueFile_SetImplementationValue(d As __IssueDocument.DetailsClass, v As Byte())
                    d.ImplementationEntity.IssueFile = v
                End Sub
                Private Shared Sub _IssueFile_OnValueChanged(e As __IssueDocument)
                    e.IssueFile_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Issue As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Global.LightSwitchApplication.Issue).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Global.LightSwitchApplication.Issue).Entry( _
                        "Issue", _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._Issue_Stub, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._Issue_ComputeIsReadOnly, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._Issue_Validate, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._Issue_GetCoreImplementationValue, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._Issue_GetImplementationValue, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._Issue_SetImplementationValue, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._Issue_Refresh, _
                        AddressOf __IssueDocument.DetailsClass.PropertySetProperties._Issue_OnValueChanged)
                Private Shared Sub _Issue_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __IssueDocument.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Global.LightSwitchApplication.Issue).Data), d As __IssueDocument.DetailsClass, sf As Object)
                    c(d, d._Issue, sf)
                End Sub
                Private Shared Function _Issue_ComputeIsReadOnly(e As __IssueDocument) As Boolean
                    Dim result As Boolean = False
                    e.Issue_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Issue_Validate(e As __IssueDocument, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Issue_Validate(r)
                End Sub
                Private Shared Function _Issue_GetCoreImplementationValue(d as __IssueDocument.DetailsClass) As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
                    Return d.ImplementationEntity.Issue
                End Function
                Private Shared Function _Issue_GetImplementationValue(d as __IssueDocument.DetailsClass) As Global.LightSwitchApplication.Issue
                    Return d.GetImplementationValue(Of Global.LightSwitchApplication.Issue, Global.LightSwitchApplication.Issue.DetailsClass)(__IssueDocument.DetailsClass.PropertySetProperties.Issue, d._Issue)
                End Function
                Private Shared Sub _Issue_SetImplementationValue(d As __IssueDocument.DetailsClass, v As Global.LightSwitchApplication.Issue)
                    d.SetImplementationValue(__IssueDocument.DetailsClass.PropertySetProperties.Issue, d._Issue, Sub(i, ev) i.Issue = ev, v)
                End Sub
                Private Shared Sub _Issue_Refresh(d As __IssueDocument.DetailsClass)
                    d.RefreshNavigationProperty(__IssueDocument.DetailsClass.PropertySetProperties.Issue, d._Issue)
                End Sub
                Private Shared Sub _Issue_OnValueChanged(e As __IssueDocument)
                    e.Issue_Changed()
                End Sub
    
            End Class
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Integer).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Byte()).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _DocumentName As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, String).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _FileExtension As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, String).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _IssueFile As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Byte()).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Issue As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __IssueDocument, __IssueDocument.DetailsClass, Global.LightSwitchApplication.Issue).Data
            
        End Class
    
        #End Region
    
    End Class
    
    #End Region
End Namespace
