'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Windows
Imports Microsoft.LightSwitch
Imports Microsoft.LightSwitch.Client
Imports Microsoft.LightSwitch.Details
Imports Microsoft.LightSwitch.Details.Client
Imports Microsoft.LightSwitch.Utilities

Namespace Presentation.Shells

    Public Class ScreenWrapper
        Implements IScreenObject
        Implements INotifyPropertyChanged

        Private screenObject As IScreenObject
        Private dirty As Boolean
        Private dataServicePropertyChangedListeners As List(
           Of IWeakEventListener)

        Public Event PropertyChanged(sender As Object,
           e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

        ' 1.  REGISTER FOR CHANGE NOTIFICATIONS
        Friend Sub New(screenObject As IScreenObject)
            Me.screenObject = screenObject
            Me.dataServicePropertyChangedListeners =
               New List(Of IWeakEventListener)

            ' Register for property changed events on the details object.
            AddHandler CType(screenObject.Details, 
              INotifyPropertyChanged).PropertyChanged,
              AddressOf Me.OnDetailsPropertyChanged

            ' Register for changed events on each of the data services.
            Dim dataServices As IEnumerable(Of IDataService) =
                screenObject.Details.DataWorkspace.Details.Properties.All().OfType(
                   Of IDataWorkspaceDataServiceProperty)().Select(
                      Function(p) p.Value)

            For Each dataService As IDataService In dataServices
                Me.dataServicePropertyChangedListeners.Add(
                  CType(dataService.Details, INotifyPropertyChanged).CreateWeakPropertyChangedListener(
                    Me, AddressOf Me.OnDataServicePropertyChanged))
            Next
        End Sub

        Private Sub OnDetailsPropertyChanged(sender As Object,
           e As PropertyChangedEventArgs)
            If String.Equals(e.PropertyName,
              "ValidationResults", StringComparison.OrdinalIgnoreCase) Then
                RaiseEvent PropertyChanged(
                   Me, New PropertyChangedEventArgs("ValidationResults"))
            End If
        End Sub

        Private Sub OnDataServicePropertyChanged(sender As Object,
          e As PropertyChangedEventArgs)
            Dim dataService As IDataService =
           CType(sender, IDataServiceDetails).DataService
            Me.IsDirty = dataService.Details.HasChanges
        End Sub

        ' 2.  EXPOSE AN ISDIRTY PROPERTY
        Public Property IsDirty As Boolean
            Get
                Return Me.dirty
            End Get
            Set(value As Boolean)
                Me.dirty = value
                RaiseEvent PropertyChanged(
                      Me, New PropertyChangedEventArgs("IsDirty"))
            End Set
        End Property

        ' 3.  EXPOSE A VALIDATION RESULTS PROPERTY
        Public ReadOnly Property ValidationResults As ValidationResults
            Get
                Return Me.screenObject.Details.ValidationResults
            End Get
        End Property

        ' 4.  EXPOSE UNDERLYING SCREEN PROPERTIES
        Public ReadOnly Property CanSave As Boolean Implements IScreenObject.CanSave
            Get
                Return Me.screenObject.CanSave
            End Get
        End Property

        Public Sub Close(promptUserToSave As Boolean) Implements IScreenObject.Close
            Me.screenObject.Close(promptUserToSave)
        End Sub

        Friend ReadOnly Property RealScreenObject As IScreenObject
            Get
                Return Me.screenObject
            End Get
        End Property

        Public Property Description As String Implements IScreenObject.Description
            Get
                Return Me.screenObject.Description
            End Get
            Set(value As String)
                Me.screenObject.Description = value
            End Set
        End Property

        Public ReadOnly Property Details As IScreenDetails Implements IScreenObject.Details
            Get
                Return Me.screenObject.Details
            End Get
        End Property

        Public Property DisplayName As String Implements IScreenObject.DisplayName
            Get
                Return Me.screenObject.DisplayName
            End Get
            Set(value As String)
                Me.screenObject.DisplayName = value
            End Set
        End Property

        Public ReadOnly Property Name As String Implements IScreenObject.Name
            Get
                Return Me.screenObject.Name
            End Get
        End Property

        Public Sub Refresh() Implements IScreenObject.Refresh
            Me.screenObject.Refresh()
        End Sub

        Public Sub Save() Implements IScreenObject.Save
            Me.screenObject.Save()
        End Sub

        Public ReadOnly Property Details1 As IBusinessDetails Implements IBusinessObject.Details
            Get
                Return CType(Me.screenObject, IBusinessObject).Details
            End Get
        End Property

        Public ReadOnly Property Details2 As IDetails Implements IObjectWithDetails.Details
            Get
                Return CType(Me.screenObject, IObjectWithDetails).Details
            End Get
        End Property

        Public ReadOnly Property Details3 As IStructuralDetails Implements IStructuralObject.Details
            Get
                Return CType(Me.screenObject, IStructuralObject).Details
            End Get
        End Property
    End Class

End Namespace

