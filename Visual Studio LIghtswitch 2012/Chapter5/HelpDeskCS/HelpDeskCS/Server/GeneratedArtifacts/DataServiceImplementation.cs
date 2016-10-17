﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using global::System.Linq;

namespace LightSwitchApplication.Implementation
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataDataService
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataService<global::ApplicationData.Implementation.ApplicationDataObjectContext>
    {
    
        public ApplicationDataDataService() : base()
        {
        }
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService()
        {
            return new global::LightSwitchApplication.DataWorkspace().ApplicationData;
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataServiceImplementation
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceImplementation<global::ApplicationData.Implementation.ApplicationDataObjectContext>
    {
        public ApplicationDataServiceImplementation(global::Microsoft.LightSwitch.IDataService dataService) : base(dataService)
        {
        }
    
    #region Queries
    #endregion

    #region Protected Methods
        protected override object CreateObject(global::System.Type type)
        {
            if (type == typeof(global::ApplicationData.Implementation.Engineer))
            {
                return new global::ApplicationData.Implementation.Engineer();
            }
            if (type == typeof(global::ApplicationData.Implementation.Issue))
            {
                return new global::ApplicationData.Implementation.Issue();
            }
            if (type == typeof(global::ApplicationData.Implementation.IssueStatus))
            {
                return new global::ApplicationData.Implementation.IssueStatus();
            }
            if (type == typeof(global::ApplicationData.Implementation.Skill))
            {
                return new global::ApplicationData.Implementation.Skill();
            }
            if (type == typeof(global::ApplicationData.Implementation.EngineerSkill))
            {
                return new global::ApplicationData.Implementation.EngineerSkill();
            }
            if (type == typeof(global::ApplicationData.Implementation.TimeTracking))
            {
                return new global::ApplicationData.Implementation.TimeTracking();
            }
            if (type == typeof(global::ApplicationData.Implementation.Priority))
            {
                return new global::ApplicationData.Implementation.Priority();
            }
            if (type == typeof(global::ApplicationData.Implementation.Department))
            {
                return new global::ApplicationData.Implementation.Department();
            }
            if (type == typeof(global::ApplicationData.Implementation.User))
            {
                return new global::ApplicationData.Implementation.User();
            }
            if (type == typeof(global::ApplicationData.Implementation.IssueResponse))
            {
                return new global::ApplicationData.Implementation.IssueResponse();
            }
            if (type == typeof(global::ApplicationData.Implementation.IssueDocument))
            {
                return new global::ApplicationData.Implementation.IssueDocument();
            }
    
            return base.CreateObject(type);
        }
    
        protected override global::ApplicationData.Implementation.ApplicationDataObjectContext CreateObjectContext()
        {
            string assemblyName = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            return new global::ApplicationData.Implementation.ApplicationDataObjectContext(base.GetEntityConnectionString(
                "_IntrinsicData", 
                "res://" + assemblyName + "/ApplicationData.csdl|res://" + assemblyName + "/ApplicationData.ssdl|res://" + assemblyName + "/ApplicationData.msl", 
                "System.Data.SqlClient"));
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Engineer))
            {
                return new global::ApplicationData.Implementation.Engineer();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Issue))
            {
                return new global::ApplicationData.Implementation.Issue();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.IssueStatus))
            {
                return new global::ApplicationData.Implementation.IssueStatus();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Skill))
            {
                return new global::ApplicationData.Implementation.Skill();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.EngineerSkill))
            {
                return new global::ApplicationData.Implementation.EngineerSkill();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.TimeTracking))
            {
                return new global::ApplicationData.Implementation.TimeTracking();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Priority))
            {
                return new global::ApplicationData.Implementation.Priority();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Department))
            {
                return new global::ApplicationData.Implementation.Department();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.User))
            {
                return new global::ApplicationData.Implementation.User();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.IssueResponse))
            {
                return new global::ApplicationData.Implementation.IssueResponse();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.IssueDocument))
            {
                return new global::ApplicationData.Implementation.IssueDocument();
            }
            return null;
        }
    
    #endregion
    
    }
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class DataServiceFactory :
        global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.ApplicationDataService();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.Implementation.ApplicationDataServiceImplementation(dataService);
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.Engineer) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.Engineer);
            }
            if (typeof(global::LightSwitchApplication.Issue) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.Issue);
            }
            if (typeof(global::LightSwitchApplication.IssueStatus) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.IssueStatus);
            }
            if (typeof(global::LightSwitchApplication.Skill) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.Skill);
            }
            if (typeof(global::LightSwitchApplication.EngineerSkill) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.EngineerSkill);
            }
            if (typeof(global::LightSwitchApplication.TimeTracking) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.TimeTracking);
            }
            if (typeof(global::LightSwitchApplication.Priority) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.Priority);
            }
            if (typeof(global::LightSwitchApplication.Department) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.Department);
            }
            if (typeof(global::LightSwitchApplication.User) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.User);
            }
            if (typeof(global::LightSwitchApplication.IssueResponse) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.IssueResponse);
            }
            if (typeof(global::LightSwitchApplication.IssueDocument) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.IssueDocument);
            }
            return null;
        }
    }
}

namespace ApplicationData.Implementation
{

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Engineer :
        global::LightSwitchApplication.Engineer.DetailsClass.IImplementation
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.Engineer.DetailsClass.IImplementation.Issues
        {
            get
            {
                return this.Issues;
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Engineer.DetailsClass.IImplementation.IssuesClosed
        {
            get
            {
                return this.IssuesClosed;
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Engineer.DetailsClass.IImplementation.EngineerSkills
        {
            get
            {
                return this.EngineerSkills;
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Engineer.DetailsClass.IImplementation.Manager
        {
            get
            {
                return this.Manager;
            }
            set
            {
                this.Manager = (global::ApplicationData.Implementation.Engineer)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Manager");
                }
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Engineer.DetailsClass.IImplementation.Subordinates
        {
            get
            {
                return this.Subordinates;
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Engineer.DetailsClass.IImplementation.TimeTracking
        {
            get
            {
                return this.TimeTracking;
            }
        }
        
        partial void OnEngineer_EngineerChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Manager");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Issue :
        global::LightSwitchApplication.Issue.DetailsClass.IImplementation
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Issue.DetailsClass.IImplementation.IssueStatus
        {
            get
            {
                return this.IssueStatus;
            }
            set
            {
                this.IssueStatus = (global::ApplicationData.Implementation.IssueStatus)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("IssueStatus");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Issue.DetailsClass.IImplementation.AssignedTo
        {
            get
            {
                return this.AssignedTo;
            }
            set
            {
                this.AssignedTo = (global::ApplicationData.Implementation.Engineer)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("AssignedTo");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Issue.DetailsClass.IImplementation.ClosedByEngineer
        {
            get
            {
                return this.ClosedByEngineer;
            }
            set
            {
                this.ClosedByEngineer = (global::ApplicationData.Implementation.Engineer)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("ClosedByEngineer");
                }
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Issue.DetailsClass.IImplementation.TimeTrackings
        {
            get
            {
                return this.TimeTrackings;
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Issue.DetailsClass.IImplementation.Priority
        {
            get
            {
                return this.Priority;
            }
            set
            {
                this.Priority = (global::ApplicationData.Implementation.Priority)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Priority");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Issue.DetailsClass.IImplementation.User
        {
            get
            {
                return this.User;
            }
            set
            {
                this.User = (global::ApplicationData.Implementation.User)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("User");
                }
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Issue.DetailsClass.IImplementation.IssueResponses
        {
            get
            {
                return this.IssueResponses;
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Issue.DetailsClass.IImplementation.IssueDocuments
        {
            get
            {
                return this.IssueDocuments;
            }
        }
        
        partial void OnIssue_IssueStatusChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("IssueStatus");
            }
        }
        
        partial void OnEngineer_IssueChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("AssignedTo");
            }
        }
        
        partial void OnIssue_EngineerChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("ClosedByEngineer");
            }
        }
        
        partial void OnPriority_IssueChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Priority");
            }
        }
        
        partial void OnUser_IssueChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("User");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class IssueStatus :
        global::LightSwitchApplication.IssueStatus.DetailsClass.IImplementation
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.IssueStatus.DetailsClass.IImplementation.Issues
        {
            get
            {
                return this.Issues;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Skill :
        global::LightSwitchApplication.Skill.DetailsClass.IImplementation
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.Skill.DetailsClass.IImplementation.EngineerSkills
        {
            get
            {
                return this.EngineerSkills;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class EngineerSkill :
        global::LightSwitchApplication.EngineerSkill.DetailsClass.IImplementation
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.EngineerSkill.DetailsClass.IImplementation.Engineer
        {
            get
            {
                return this.Engineer;
            }
            set
            {
                this.Engineer = (global::ApplicationData.Implementation.Engineer)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Engineer");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.EngineerSkill.DetailsClass.IImplementation.Skill
        {
            get
            {
                return this.Skill;
            }
            set
            {
                this.Skill = (global::ApplicationData.Implementation.Skill)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Skill");
                }
            }
        }
        
        partial void OnEngineerSkill_EngineerChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Engineer");
            }
        }
        
        partial void OnEngineerSkill_SkillChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Skill");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class TimeTracking :
        global::LightSwitchApplication.TimeTracking.DetailsClass.IImplementation
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.TimeTracking.DetailsClass.IImplementation.Engineers
        {
            get
            {
                return this.Engineers;
            }
            set
            {
                this.Engineers = (global::ApplicationData.Implementation.Engineer)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Engineers");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.TimeTracking.DetailsClass.IImplementation.Issue
        {
            get
            {
                return this.Issue;
            }
            set
            {
                this.Issue = (global::ApplicationData.Implementation.Issue)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Issue");
                }
            }
        }
        
        partial void OnTimeTracking_EngineerChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Engineers");
            }
        }
        
        partial void OnTimeTracking_IssueChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Issue");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Priority :
        global::LightSwitchApplication.Priority.DetailsClass.IImplementation
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.Priority.DetailsClass.IImplementation.Issues
        {
            get
            {
                return this.Issues;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Department :
        global::LightSwitchApplication.Department.DetailsClass.IImplementation
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.Department.DetailsClass.IImplementation.Users
        {
            get
            {
                return this.Users;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class User :
        global::LightSwitchApplication.User.DetailsClass.IImplementation
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.User.DetailsClass.IImplementation.Issues
        {
            get
            {
                return this.Issues;
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.User.DetailsClass.IImplementation.Department
        {
            get
            {
                return this.Department;
            }
            set
            {
                this.Department = (global::ApplicationData.Implementation.Department)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Department");
                }
            }
        }
        
        partial void OnDepartment_UserChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Department");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class IssueResponse :
        global::LightSwitchApplication.IssueResponse.DetailsClass.IImplementation
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.IssueResponse.DetailsClass.IImplementation.Issue
        {
            get
            {
                return this.Issue;
            }
            set
            {
                this.Issue = (global::ApplicationData.Implementation.Issue)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Issue");
                }
            }
        }
        
        partial void OnIssueResponse_IssueChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Issue");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class IssueDocument :
        global::LightSwitchApplication.IssueDocument.DetailsClass.IImplementation
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.IssueDocument.DetailsClass.IImplementation.Issue
        {
            get
            {
                return this.Issue;
            }
            set
            {
                this.Issue = (global::ApplicationData.Implementation.Issue)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Issue");
                }
            }
        }
        
        partial void OnIssueDocument_IssueChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Issue");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
}

