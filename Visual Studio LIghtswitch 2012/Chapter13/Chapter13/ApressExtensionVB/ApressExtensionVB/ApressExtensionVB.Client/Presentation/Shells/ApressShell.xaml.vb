'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports Microsoft.VisualStudio.ExtensibilityHosting
Imports Microsoft.LightSwitch.Sdk.Proxy
Imports Microsoft.LightSwitch.Runtime.Shell
Imports Microsoft.LightSwitch.BaseServices.Notifications
Imports Microsoft.LightSwitch.Client
Imports Microsoft.LightSwitch.Runtime.Shell.View
Imports Microsoft.LightSwitch.Runtime.Shell.ViewModels.Commands
Imports Microsoft.LightSwitch.Runtime.Shell.ViewModels.Navigation
Imports Microsoft.LightSwitch.Threading

Namespace Presentation.Shells

    Partial Public Class ApressShell
        Inherits UserControl

        Private weakHelperObjects As List(Of Object) =
           New List(Of Object)()

        'Declare the Proxy Object
        Private serviceProxyCache As IServiceProxy
        Private ReadOnly Property ServiceProxy As IServiceProxy
            Get
                If Me.serviceProxyCache Is Nothing Then
                    Me.serviceProxyCache =
                        VsExportProviderService.GetExportedValue(Of IServiceProxy)()
                End If
                Return Me.serviceProxyCache
            End Get
        End Property

        ' SECTION 1 - Screen Handling Code
        Public Sub New()
            InitializeComponent()
            ' Subscribe to ScreenOpened,ScreenClosed, ScreenReloaded notifications
            Me.ServiceProxy.NotificationService.Subscribe(
                GetType(ScreenOpenedNotification), AddressOf Me.OnScreenOpened)
            Me.ServiceProxy.NotificationService.Subscribe(
                GetType(ScreenClosedNotification), AddressOf Me.OnScreenClosed)
            Me.ServiceProxy.NotificationService.Subscribe(
                GetType(ScreenReloadedNotification), AddressOf Me.OnScreenRefreshed)
        End Sub

        Public Sub OnScreenOpened(n As Notification)
            Dim screenOpenedNotification As ScreenOpenedNotification = n

            Dim screenObject As IScreenObject =
                screenOpenedNotification.Screen

            Dim view As IScreenView =
                Me.ServiceProxy.ScreenViewService.GetScreenView(
                    screenObject)

            ' Create a tab item from the template
            Dim ti As TabItem = New TabItem()
            Dim template As DataTemplate = Me.Resources("TabItemHeaderTemplate")
            Dim element As UIElement = template.LoadContent()

            'Wrap the underlying screen object in a ScreenWrapper object
            ti.DataContext = New ScreenWrapper(screenObject)
            ti.Header = element
            ti.HeaderTemplate = template
            ti.Content = view.RootUI

            ' Add the tab item to the tab control.
            Me.ScreenArea.Items.Add(ti)
            Me.ScreenArea.SelectedItem = ti

            ' Set the currently active screen in the active screens view model.
            Me.ServiceProxy.ActiveScreensViewModel.Current = screenObject

        End Sub

        Public Sub OnScreenClosed(n As Notification)
            Dim screenClosedNotification As ScreenClosedNotification = n
            Dim screenObject As IScreenObject =
                screenClosedNotification.Screen

            For Each ti As TabItem In Me.ScreenArea.Items
                ' Get the real IScreenObject from the instance of the ScreenWrapper.
                Dim realScreenObject As IScreenObject =
                    CType(ti.DataContext, ScreenWrapper).RealScreenObject
                ' Remove the screen from the tab control
                If realScreenObject Is screenObject Then
                    Me.ScreenArea.Items.Remove(ti)
                    Exit For
                End If
            Next

            ' Switch the current tab and current screen    
            Dim count As Integer = Me.ScreenArea.Items.Count
            If count > 0 Then
                Dim ti As TabItem = Me.ScreenArea.Items(count - 1)
                Me.ScreenArea.SelectedItem = ti
                Me.ServiceProxy.ActiveScreensViewModel.Current =
                    CType(ti.DataContext, ScreenWrapper).RealScreenObject
            End If
        End Sub

        Public Sub OnScreenRefreshed(n As Notification)

            Dim srn As ScreenReloadedNotification = n
            For Each ti As TabItem In Me.ScreenArea.Items
                Dim realScreenObject As IScreenObject =
                    CType(ti.DataContext, ScreenWrapper).RealScreenObject
                If realScreenObject Is srn.OriginalScreen Then
                    Dim view As IScreenView =
                        Me.ServiceProxy.ScreenViewService.GetScreenView(
                            srn.NewScreen)

                    ti.Content = view.RootUI
                    ti.DataContext = New ScreenWrapper(srn.NewScreen)
                    Exit For
                End If
            Next
        End Sub

        Private Sub OnTabItemSelectionChanged(sender As Object,
            e As SelectionChangedEventArgs)
            If e.AddedItems.Count > 0 Then
                Dim selectedItem As TabItem = e.AddedItems(0)

                If selectedItem IsNot Nothing Then
                    Dim screenObject As IScreenObject =
                        CType(selectedItem.DataContext, 
                           ScreenWrapper).RealScreenObject

                    Me.ServiceProxy.ActiveScreensViewModel.Current =
                        screenObject
                End If
            End If
        End Sub

        Private Sub OnClickTabItemClose(sender As Object, e As RoutedEventArgs)
            Dim screenObject As IScreenObject =
                TryCast(CType(sender, Button).DataContext, IScreenObject)

            If screenObject IsNot Nothing Then
                screenObject.Details.Dispatcher.EnsureInvoke(
                    Sub()
                    screenObject.Close(True)
                End Sub)
            End If
        End Sub

        ' SECTION 2 - Command Button Handling Code
        Private Sub GeneralCommandHandler(sender As Object, e As RoutedEventArgs)
            Dim command As IShellCommand = CType(sender, Button).DataContext
            command.ExecutableObject.ExecuteAsync()
        End Sub

        ' SECTION 3 - Screen Navigation Code
        Private Sub navigationGroup_SelectionChanged(sender As Object,
           e As SelectionChangedEventArgs) Handles navigationGroup.SelectionChanged
            navigationItems.ItemsSource =
                (navigationGroup.SelectedItem).Children
        End Sub

        Private Sub navigationItems_SelectionChanged(sender As Object,
           e As SelectionChangedEventArgs) Handles navigationItems.SelectionChanged
            Dim screen As INavigationScreen =
                TryCast((navigationItems.SelectedItem), INavigationScreen)
            If screen IsNot Nothing Then

                Try
                    screen.ExecutableObject.ExecuteAsync()
                Catch ex As Exception

                End Try
            End If
        End Sub

    End Class

End Namespace
