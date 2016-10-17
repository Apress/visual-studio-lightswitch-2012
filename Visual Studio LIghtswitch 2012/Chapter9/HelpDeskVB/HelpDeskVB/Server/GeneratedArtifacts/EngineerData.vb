﻿
'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.ComponentModel
Imports System.Data.EntityClient
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Xml.Serialization


<Assembly: EdmSchemaAttribute("8ed592e5-4a5a-4eba-9188-1a63cc4dcbdd")>
Namespace EngineerData.Implementation

    #Region "Contexts"
    
    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Public Partial Class EngineerDataObjectContext
        Inherits ObjectContext
    
        #Region "Constructors"
    
        ''' <summary>
        ''' Initializes a new EngineerDataObjectContext object using the connection string found in the 'EngineerDataObjectContext' section of the application configuration file.
        ''' </summary>
        Public Sub New()
            MyBase.New("name=EngineerDataObjectContext", "EngineerDataObjectContext")
            OnContextCreated()
        End Sub
    
        ''' <summary>
        ''' Initialize a new EngineerDataObjectContext object.
        ''' </summary>
        Public Sub New(ByVal connectionString As String)
            MyBase.New(connectionString, "EngineerDataObjectContext")
            OnContextCreated()
        End Sub
    
        ''' <summary>
        ''' Initialize a new EngineerDataObjectContext object.
        ''' </summary>
        Public Sub New(ByVal connection As EntityConnection)
            MyBase.New(connection, "EngineerDataObjectContext")
            OnContextCreated()
        End Sub
    
        #End Region
    
        #Region "Partial Methods"
    
        Partial Private Sub OnContextCreated()
        End Sub
    
        #End Region
    
        #Region "ObjectSet Properties"
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        Public ReadOnly Property EngineerRecords() As ObjectSet(Of EngineerRecord)
            Get
                If (_EngineerRecords Is Nothing) Then
                    _EngineerRecords = MyBase.CreateObjectSet(Of EngineerRecord)("EngineerRecords")
                End If
                Return _EngineerRecords
            End Get
        End Property
    
        Private _EngineerRecords As ObjectSet(Of EngineerRecord)

        #End Region

        #Region "AddTo Methods"
    
        ''' <summary>
        ''' Deprecated Method for adding a new object to the EngineerRecords EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
        ''' </summary>
        Public Sub AddToEngineerRecords(ByVal engineerRecord As EngineerRecord)
            MyBase.AddObject("EngineerRecords", engineerRecord)
        End Sub

        #End Region

    End Class

    #End Region

    #Region "Entities"
    
    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmEntityTypeAttribute(NamespaceName:="LightSwitchApplication", Name:="EngineerRecord")>
    <Serializable()>
    <DataContractAttribute(IsReference:=True)>
    Public Partial Class EngineerRecord
        Inherits EntityObject
        #Region "Factory Method"
    
        ''' <summary>
        ''' Create a new EngineerRecord object.
        ''' </summary>
        ''' <param name="id">Initial value of the Id property.</param>
        ''' <param name="surname">Initial value of the Surname property.</param>
        ''' <param name="firstname">Initial value of the Firstname property.</param>
        ''' <param name="dateOfBirth">Initial value of the DateOfBirth property.</param>
        ''' <param name="securityVetted">Initial value of the SecurityVetted property.</param>
        ''' <param name="issueCount">Initial value of the IssueCount property.</param>
        Public Shared Function CreateEngineerRecord(id As Global.System.Int32, surname As Global.System.String, firstname As Global.System.String, dateOfBirth As Global.System.DateTime, securityVetted As Global.System.Boolean, issueCount As Global.System.Int32) As EngineerRecord
            Dim engineerRecord as EngineerRecord = New EngineerRecord
            engineerRecord.Id = id
            engineerRecord.Surname = surname
            engineerRecord.Firstname = firstname
            engineerRecord.DateOfBirth = dateOfBirth
            engineerRecord.SecurityVetted = securityVetted
            engineerRecord.IssueCount = issueCount
            Return engineerRecord
        End Function

        #End Region

        #Region "Primitive Properties"
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property Id() As Global.System.Int32
            Get
                Return _Id
            End Get
            Set
                If (_Id <> Value) Then
                    OnIdChanging(value)
                    ReportPropertyChanging("Id")
                    _Id = value
                    ReportPropertyChanged("Id")
                    OnIdChanged()
                End If
            End Set
        End Property
    
        Private _Id As Global.System.Int32
        Private Partial Sub OnIdChanging(value As Global.System.Int32)
        End Sub
    
        Private Partial Sub OnIdChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property Surname() As Global.System.String
            Get
                Return _Surname
            End Get
            Set
                OnSurnameChanging(value)
                ReportPropertyChanging("Surname")
                _Surname = value
                ReportPropertyChanged("Surname")
                OnSurnameChanged()
            End Set
        End Property
    
        Private _Surname As Global.System.String
        Private Partial Sub OnSurnameChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnSurnameChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property Firstname() As Global.System.String
            Get
                Return _Firstname
            End Get
            Set
                OnFirstnameChanging(value)
                ReportPropertyChanging("Firstname")
                _Firstname = value
                ReportPropertyChanged("Firstname")
                OnFirstnameChanged()
            End Set
        End Property
    
        Private _Firstname As Global.System.String
        Private Partial Sub OnFirstnameChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnFirstnameChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property DateOfBirth() As Global.System.DateTime
            Get
                Return _DateOfBirth
            End Get
            Set
                OnDateOfBirthChanging(value)
                ReportPropertyChanging("DateOfBirth")
                _DateOfBirth = value
                ReportPropertyChanged("DateOfBirth")
                OnDateOfBirthChanged()
            End Set
        End Property
    
        Private _DateOfBirth As Global.System.DateTime
        Private Partial Sub OnDateOfBirthChanging(value As Global.System.DateTime)
        End Sub
    
        Private Partial Sub OnDateOfBirthChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property SecurityVetted() As Global.System.Boolean
            Get
                Return _SecurityVetted
            End Get
            Set
                OnSecurityVettedChanging(value)
                ReportPropertyChanging("SecurityVetted")
                _SecurityVetted = value
                ReportPropertyChanged("SecurityVetted")
                OnSecurityVettedChanged()
            End Set
        End Property
    
        Private _SecurityVetted As Global.System.Boolean
        Private Partial Sub OnSecurityVettedChanging(value As Global.System.Boolean)
        End Sub
    
        Private Partial Sub OnSecurityVettedChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property IssueCount() As Global.System.Int32
            Get
                Return _IssueCount
            End Get
            Set
                OnIssueCountChanging(value)
                ReportPropertyChanging("IssueCount")
                _IssueCount = value
                ReportPropertyChanged("IssueCount")
                OnIssueCountChanged()
            End Set
        End Property
    
        Private _IssueCount As Global.System.Int32
        Private Partial Sub OnIssueCountChanging(value As Global.System.Int32)
        End Sub
    
        Private Partial Sub OnIssueCountChanged()
        End Sub

        #End Region

    End Class

    #End Region

    
End Namespace
