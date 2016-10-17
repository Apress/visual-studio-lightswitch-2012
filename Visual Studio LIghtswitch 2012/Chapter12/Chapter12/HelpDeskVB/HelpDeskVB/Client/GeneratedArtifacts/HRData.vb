﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18033
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On


'Original file name:
'Generation date: 31/05/2013 15:30:14
Namespace LightSwitchApplication.Implementation
    '''<summary>
    '''There are no comments for HRDataObjectContext in the schema.
    '''</summary>
    Partial Public Class HRDataObjectContext
        Inherits Global.Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceContext
        '''<summary>
        '''Initialize a new HRDataObjectContext object.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Sub New(ByVal serviceRoot As Global.System.Uri)
            MyBase.New(serviceRoot)
            Me.ResolveName = AddressOf Me.ResolveNameFromType
            Me.ResolveType = AddressOf Me.ResolveTypeFromName
            Me.OnContextCreated
        End Sub
        Partial Private Sub OnContextCreated()
        End Sub
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private Shared ROOTNAMESPACE As String = GetType(LightSwitchApplication.Implementation.HRDataObjectContext).Namespace.Remove(GetType(LightSwitchApplication.Implementation.HRDataObjectContext).Namespace.LastIndexOf("LightSwitchApplication.Implementation"))
        '''<summary>
        '''Since the namespace configured for this service reference
        '''in Visual Studio is different from the one indicated in the
        '''server schema, use type-mappers to map between the two.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Protected Function ResolveTypeFromName(ByVal typeName As String) As Global.System.Type
            If typeName.StartsWith("LightSwitchApplication", Global.System.StringComparison.OrdinalIgnoreCase) Then
                Return Me.GetType.Assembly.GetType(String.Concat(String.Concat(ROOTNAMESPACE, "LightSwitchApplication.Implementation"), typeName.Substring(22)), false)
            End If
            Return Nothing
        End Function
        '''<summary>
        '''Since the namespace configured for this service reference
        '''in Visual Studio is different from the one indicated in the
        '''server schema, use type-mappers to map between the two.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Protected Function ResolveNameFromType(ByVal clientType As Global.System.Type) As String
            If clientType.Namespace.Equals(String.Concat(ROOTNAMESPACE, "LightSwitchApplication.Implementation"), Global.System.StringComparison.OrdinalIgnoreCase) Then
                Return String.Concat("LightSwitchApplication.", clientType.Name)
            End If
            Return Nothing
        End Function
        '''<summary>
        '''There are no comments for Employees in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public ReadOnly Property Employees() As Global.System.Data.Services.Client.DataServiceQuery(Of Employee)
            Get
                If (Me._Employees Is Nothing) Then
                    Me._Employees = MyBase.CreateQuery(Of Employee)("Employees")
                End If
                Return Me._Employees
            End Get
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _Employees As Global.System.Data.Services.Client.DataServiceQuery(Of Employee)
        '''<summary>
        '''There are no comments for Employees in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Sub AddToEmployees(ByVal employee As Employee)
            MyBase.AddObject("Employees", employee)
        End Sub
    End Class
    '''<summary>
    '''There are no comments for LightSwitchApplication.Employee in the schema.
    '''</summary>
    '''<KeyProperties>
    '''UserId
    '''</KeyProperties>
    <Global.System.Data.Services.Common.EntitySetAttribute("Employees"),  _
     Global.System.Data.Services.Common.DataServiceKeyAttribute("UserId")>  _
    Partial Public Class Employee
        Inherits Global.Microsoft.LightSwitch.ClientGenerated.Implementation.EntityBase
        Implements Global.System.ComponentModel.INotifyPropertyChanged
        '''<summary>
        '''Create a new Employee object.
        '''</summary>
        '''<param name="userId">Initial value of UserId.</param>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Shared Function CreateEmployee(ByVal userId As Integer) As Employee
            Dim employee As Employee = New Employee()
            employee.UserId = userId
            Return employee
        End Function
        '''<summary>
        '''There are no comments for Property UserId in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property UserId() As Integer
            Get
                Return Me._UserId
            End Get
            Set
                Me.OnUserIdChanging(value)
                If Object.Equals(Me.UserId, value) Then
                    Return
                End If
                Me._UserId = value
                Me.OnUserIdChanged
                Me.OnPropertyChanged("UserId")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _UserId As Integer
        Partial Private Sub OnUserIdChanging(ByVal value As Integer)
        End Sub
        Partial Private Sub OnUserIdChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Firstname in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property Firstname() As String
            Get
                Return Me._Firstname
            End Get
            Set
                Me.OnFirstnameChanging(value)
                If Object.Equals(Me.Firstname, value) Then
                    Return
                End If
                Me._Firstname = value
                Me.OnFirstnameChanged
                Me.OnPropertyChanged("Firstname")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _Firstname As String
        Partial Private Sub OnFirstnameChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnFirstnameChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Surname in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property Surname() As String
            Get
                Return Me._Surname
            End Get
            Set
                Me.OnSurnameChanging(value)
                If Object.Equals(Me.Surname, value) Then
                    Return
                End If
                Me._Surname = value
                Me.OnSurnameChanged
                Me.OnPropertyChanged("Surname")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _Surname As String
        Partial Private Sub OnSurnameChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnSurnameChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Address1 in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property Address1() As String
            Get
                Return Me._Address1
            End Get
            Set
                Me.OnAddress1Changing(value)
                If Object.Equals(Me.Address1, value) Then
                    Return
                End If
                Me._Address1 = value
                Me.OnAddress1Changed
                Me.OnPropertyChanged("Address1")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _Address1 As String
        Partial Private Sub OnAddress1Changing(ByVal value As String)
        End Sub
        Partial Private Sub OnAddress1Changed()
        End Sub
        '''<summary>
        '''There are no comments for Property Address2 in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property Address2() As String
            Get
                Return Me._Address2
            End Get
            Set
                Me.OnAddress2Changing(value)
                If Object.Equals(Me.Address2, value) Then
                    Return
                End If
                Me._Address2 = value
                Me.OnAddress2Changed
                Me.OnPropertyChanged("Address2")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _Address2 As String
        Partial Private Sub OnAddress2Changing(ByVal value As String)
        End Sub
        Partial Private Sub OnAddress2Changed()
        End Sub
        '''<summary>
        '''There are no comments for Property Town in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property Town() As String
            Get
                Return Me._Town
            End Get
            Set
                Me.OnTownChanging(value)
                If Object.Equals(Me.Town, value) Then
                    Return
                End If
                Me._Town = value
                Me.OnTownChanged
                Me.OnPropertyChanged("Town")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _Town As String
        Partial Private Sub OnTownChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnTownChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property County in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property County() As String
            Get
                Return Me._County
            End Get
            Set
                Me.OnCountyChanging(value)
                If Object.Equals(Me.County, value) Then
                    Return
                End If
                Me._County = value
                Me.OnCountyChanged
                Me.OnPropertyChanged("County")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _County As String
        Partial Private Sub OnCountyChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnCountyChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Postcode in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property Postcode() As String
            Get
                Return Me._Postcode
            End Get
            Set
                Me.OnPostcodeChanging(value)
                If Object.Equals(Me.Postcode, value) Then
                    Return
                End If
                Me._Postcode = value
                Me.OnPostcodeChanged
                Me.OnPropertyChanged("Postcode")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _Postcode As String
        Partial Private Sub OnPostcodeChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnPostcodeChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Country in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property Country() As String
            Get
                Return Me._Country
            End Get
            Set
                Me.OnCountryChanging(value)
                If Object.Equals(Me.Country, value) Then
                    Return
                End If
                Me._Country = value
                Me.OnCountryChanged
                Me.OnPropertyChanged("Country")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _Country As String
        Partial Private Sub OnCountryChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnCountryChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property EmployeePhoto in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property EmployeePhoto() As Byte()
            Get
                If (Not (Me._EmployeePhoto) Is Nothing) Then
                    Return CType(Me._EmployeePhoto.Clone,Byte())
                Else
                    Return Nothing
                End If
            End Get
            Set
                Me.OnEmployeePhotoChanging(value)
                If Object.Equals(Me.EmployeePhoto, value) Then
                    Return
                End If
                Me._EmployeePhoto = value
                Me.OnEmployeePhotoChanged
                Me.OnPropertyChanged("EmployeePhoto")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _EmployeePhoto() As Byte
        Partial Private Sub OnEmployeePhotoChanging(ByVal value() As Byte)
        End Sub
        Partial Private Sub OnEmployeePhotoChanged()
        End Sub
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Event PropertyChanged As Global.System.ComponentModel.PropertyChangedEventHandler Implements Global.System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Protected Overridable Sub OnPropertyChanged(ByVal [property] As String)
            If (Not (Me.PropertyChangedEvent) Is Nothing) Then
                RaiseEvent PropertyChanged(Me, New Global.System.ComponentModel.PropertyChangedEventArgs([property]))
            End If
        End Sub
    End Class
End Namespace
