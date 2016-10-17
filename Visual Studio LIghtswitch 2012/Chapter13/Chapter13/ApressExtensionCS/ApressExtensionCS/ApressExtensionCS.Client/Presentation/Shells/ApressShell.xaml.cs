//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".
using Microsoft.VisualStudio.ExtensibilityHosting;
using Microsoft.LightSwitch.Sdk.Proxy;
using Microsoft.LightSwitch.Runtime.Shell;
using Microsoft.LightSwitch.Runtime.Shell.View;
using Microsoft.LightSwitch.Runtime.Shell.ViewModels.Commands;
using Microsoft.LightSwitch.Runtime.Shell.ViewModels.Navigation;
using Microsoft.LightSwitch.BaseServices.Notifications;
using Microsoft.LightSwitch.Client;
using Microsoft.LightSwitch.Threading;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Windows;
using System;

namespace ApressExtensionCS.Presentation.Shells
{
    public partial class ApressShell : UserControl
    {

        private IServiceProxy serviceProxy;
        private List<object> weakHelperObjects = new List<object>();

        // Declare the Proxy Object
        private IServiceProxy ServiceProxy
        {
            get
            {
                if (null == this.serviceProxy)
                    this.serviceProxy =
                  VsExportProviderService.GetExportedValue<IServiceProxy>();
                return this.serviceProxy;
            }
        }

        // SECTION 1 - Screen Handling Code
        public ApressShell()
        {
            InitializeComponent();
            // Subscribe to ScreenOpened,ScreenClosed, ScreenReloaded notifications       
            this.ServiceProxy.NotificationService.Subscribe(
               typeof(ScreenOpenedNotification), this.OnScreenOpened);
            this.ServiceProxy.NotificationService.Subscribe(
               typeof(ScreenClosedNotification), this.OnScreenClosed);
            this.ServiceProxy.NotificationService.Subscribe(
               typeof(ScreenReloadedNotification), this.OnScreenRefreshed);
        }

        public void OnScreenOpened(Notification n)
        {
            ScreenOpenedNotification screenOpenedNotification =
               (ScreenOpenedNotification)n;
            IScreenObject screenObject = screenOpenedNotification.Screen;
            IScreenView view =
                this.ServiceProxy.ScreenViewService.GetScreenView(screenObject);

            // Create a tab item from the template
            TabItem ti = new TabItem();
            DataTemplate template =
               (DataTemplate)this.Resources["TabItemHeaderTemplate"];
            UIElement element = (UIElement)template.LoadContent();

            // Wrap the underlying screen object in a ScreenWrapper object
            ti.DataContext = new ScreenWrapper(screenObject);
            ti.Header = element;
            ti.HeaderTemplate = template;
            ti.Content = view.RootUI;

            // Add the tab item to the tab control.
            this.ScreenArea.Items.Add(ti);
            this.ScreenArea.SelectedItem = ti;

            // Set the currently active screen in the active screens view model.
            this.ServiceProxy.ActiveScreensViewModel.Current = screenObject;
        }

        public void OnScreenClosed(Notification n)
        {
            ScreenClosedNotification screenClosedNotification =
               (ScreenClosedNotification)n;
            IScreenObject screenObject = screenClosedNotification.Screen;

            foreach (TabItem ti in this.ScreenArea.Items)
            {
                // Get the real IScreenObject from the instance of the ScreenWrapper
                IScreenObject realScreenObject =
                    ((ScreenWrapper)ti.DataContext).RealScreenObject;
                // Remove the screen from the tab control
                if (realScreenObject == screenObject)
                {
                    this.ScreenArea.Items.Remove(ti);
                    break;
                }
            }

            // Switch the current tab and current screen    
            int count = this.ScreenArea.Items.Count;
            if (count > 0)
            {
                TabItem ti = (TabItem)this.ScreenArea.Items[count - 1];

                this.ScreenArea.SelectedItem = ti;
                this.ServiceProxy.ActiveScreensViewModel.Current =
                   ((ScreenWrapper)(ti.DataContext)).RealScreenObject;
            }
        }

        public void OnScreenRefreshed(Notification n)
        {
            ScreenReloadedNotification srn = (ScreenReloadedNotification)n;
            foreach (TabItem ti in this.ScreenArea.Items)
            {
                IScreenObject realScreenObject =
                   ((ScreenWrapper)ti.DataContext).RealScreenObject;

                if (realScreenObject == srn.OriginalScreen)
                {
                    IScreenView view =
                        this.ServiceProxy.ScreenViewService.GetScreenView(
                           srn.NewScreen);
                    ti.Content = view.RootUI;
                    ti.DataContext = new ScreenWrapper(srn.NewScreen);
                    break;
                }
            }
        }

        private void OnTabItemSelectionChanged(object sender,
            SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                TabItem selectedItem = (TabItem)e.AddedItems[0];
                if (null != selectedItem)
                {
                    IScreenObject screenObject =
                        ((ScreenWrapper)selectedItem.DataContext).RealScreenObject;
                    this.ServiceProxy.ActiveScreensViewModel.Current = screenObject;
                }
            }
        }

        private void OnClickTabItemClose(object sender, RoutedEventArgs e)
        {
            IScreenObject screenObject =
               ((Button)sender).DataContext as IScreenObject;
            if (null != screenObject)
            {
                screenObject.Details.Dispatcher.EnsureInvoke(() =>
                {
                    screenObject.Close(true);
                });
            }
        }

        //SECTION 2 - Command Button Handling Code
        private void GeneralCommandHandler(object sender, RoutedEventArgs e)
        {
            IShellCommand command = (IShellCommand)((Button)sender).DataContext;
            command.ExecutableObject.ExecuteAsync();
        }

        // SECTION 3 - Screen Navigation Code
        private void navigationGroup_SelectionChanged(object sender,
            SelectionChangedEventArgs e)
        {
            navigationItems.ItemsSource =
                        ((INavigationGroup)(navigationGroup.SelectedItem)).Children;
        }

        private void navigationItems_SelectionChanged(object sender,
            SelectionChangedEventArgs e)
        {
            INavigationScreen screen =
                (INavigationScreen)navigationItems.SelectedItem;
            if (screen != null)
            {
                screen.ExecutableObject.ExecuteAsync();
            }
        }

    }
}
