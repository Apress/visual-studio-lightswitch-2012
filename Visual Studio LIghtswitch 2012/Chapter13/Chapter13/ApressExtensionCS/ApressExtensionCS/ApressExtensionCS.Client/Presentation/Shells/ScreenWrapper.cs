//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace ApressExtensionCS.Presentation.Shells
{
    using Microsoft.LightSwitch;
    using Microsoft.LightSwitch.Client;
    using Microsoft.LightSwitch.Details;
    using Microsoft.LightSwitch.Details.Client;
    using Microsoft.LightSwitch.Utilities;

    public class ScreenWrapper : IScreenObject, INotifyPropertyChanged
    {
        private IScreenObject screenObject;
        private bool dirty;
        private List<IWeakEventListener> dataServicePropertyChangedListeners;

        public event PropertyChangedEventHandler PropertyChanged;

        // 1.  REGISTER FOR CHANGE NOTIFICATIONS
        internal ScreenWrapper(IScreenObject screenObject)
        {
            this.screenObject = screenObject;
            this.dataServicePropertyChangedListeners =
               new List<IWeakEventListener>();

            // Register for property changed events on the details object.
            ((INotifyPropertyChanged)screenObject.Details).PropertyChanged +=
                this.OnDetailsPropertyChanged;

            // Register for changed events on each of the data services.
            IEnumerable<IDataService> dataServices =
              screenObject.Details.DataWorkspace.Details.Properties.All().OfType<
               IDataWorkspaceDataServiceProperty>().Select(p => p.Value);

            foreach (IDataService dataService in dataServices)
                this.dataServicePropertyChangedListeners.Add(
                  ((INotifyPropertyChanged)dataService.Details).CreateWeakPropertyChangedListener(
                     this, this.OnDataServicePropertyChanged));
        }

        private void OnDetailsPropertyChanged(
           object sender, PropertyChangedEventArgs e)
        {
            if (String.Equals(
               e.PropertyName, "ValidationResults", StringComparison.OrdinalIgnoreCase))
            {
                if (null != this.PropertyChanged)
                    PropertyChanged(
                       this, new PropertyChangedEventArgs("ValidationResults"));
            }
        }

        private void OnDataServicePropertyChanged(
           object sender, PropertyChangedEventArgs e)
        {
            IDataService dataService = ((IDataServiceDetails)sender).DataService;
            this.IsDirty = dataService.Details.HasChanges;
        }

        // 2.  EXPOSE AN ISDIRTY PROPERTY
        public bool IsDirty
        {
            get { return this.dirty; }
            set
            {
                this.dirty = value;
                if (null != this.PropertyChanged)
                    PropertyChanged(
                      this, new PropertyChangedEventArgs("IsDirty"));
            }
        }

        // 3.  EXPOSE A VALIDATION RESULTS PROPERTY
        public ValidationResults ValidationResults
        {
            get { return this.screenObject.Details.ValidationResults; }
        }

        // 4.  EXPOSE UNDERLYING SCREEN PROPERTIES
        public IScreenDetails Details
        {
            get { return this.screenObject.Details; }
        }
        internal IScreenObject RealScreenObject
        {
            get { return this.screenObject; }
        }

        public string Name
        {
            get { return this.screenObject.Name; }
        }

        public string DisplayName
        {
            get { return this.screenObject.DisplayName; }
            set { this.screenObject.DisplayName = value; }
        }

        public string Description
        {
            get { return this.screenObject.Description; }
            set { this.screenObject.Description = value; }
        }

        public bool CanSave
        {
            get { return this.screenObject.CanSave; }
        }

        public void Save()
        {
            this.screenObject.Save();
        }

        public void Refresh()
        {
            this.screenObject.Refresh();
        }

        public void Close(bool promptUserToSave)
        {
            this.screenObject.Close(promptUserToSave);
        }

        IBusinessDetails IBusinessObject.Details
        {
            get { return ((IBusinessObject)this.screenObject).Details; }
        }

        IStructuralDetails IStructuralObject.Details
        {
            get { return ((IStructuralObject)this.screenObject).Details; }
        }

        IDetails IObjectWithDetails.Details
        {
            get { return ((IObjectWithDetails)this.screenObject).Details; }
        }
    }
}
