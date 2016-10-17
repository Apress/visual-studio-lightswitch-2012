/// <reference path="data.js" />

(function (lightSwitchApplication) {

    var $Screen = msls.Screen,
        $defineScreen = msls._defineScreen,
        $DataServiceQuery = msls.DataServiceQuery,
        $toODataString = msls._toODataString,
        $defineShowScreen = msls._defineShowScreen;

    function BrowseIssues(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the BrowseIssues screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="Issues" type="msls.VisualCollection" elementType="msls.application.Issue">
        /// Gets the issues for this screen.
        /// </field>
        /// <field name="details" type="msls.application.BrowseIssues.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "BrowseIssues", parameters);
    }

    function Startup(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the Startup screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="Engineers" type="msls.VisualCollection" elementType="msls.application.Engineer">
        /// Gets the engineers for this screen.
        /// </field>
        /// <field name="details" type="msls.application.Startup.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "Startup", parameters);
    }

    function AddEditIssue(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the AddEditIssue screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="Issue" type="msls.application.Issue">
        /// Gets or sets the issue for this screen.
        /// </field>
        /// <field name="IssueResponses" type="msls.VisualCollection" elementType="msls.application.IssueResponse">
        /// Gets the issueResponses for this screen.
        /// </field>
        /// <field name="EngineerName" type="String">
        /// Gets or sets the engineerName for this screen.
        /// </field>
        /// <field name="EngineersByName" type="msls.VisualCollection" elementType="msls.application.Engineer">
        /// Gets the engineersByName for this screen.
        /// </field>
        /// <field name="IssueDocuments" type="msls.VisualCollection" elementType="msls.application.IssueDocument">
        /// Gets the issueDocuments for this screen.
        /// </field>
        /// <field name="details" type="msls.application.AddEditIssue.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "AddEditIssue", parameters);
    }

    function ViewIssue(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the ViewIssue screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="Issue" type="msls.application.Issue">
        /// Gets or sets the issue for this screen.
        /// </field>
        /// <field name="details" type="msls.application.ViewIssue.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "ViewIssue", parameters);
    }

    function AddEditIssueResponse(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the AddEditIssueResponse screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="IssueResponse" type="msls.application.IssueResponse">
        /// Gets or sets the issueResponse for this screen.
        /// </field>
        /// <field name="PopupText" type="String">
        /// Gets or sets the popupText for this screen.
        /// </field>
        /// <field name="PopupTitle" type="String">
        /// Gets or sets the popupTitle for this screen.
        /// </field>
        /// <field name="details" type="msls.application.AddEditIssueResponse.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "AddEditIssueResponse", parameters);
    }

    function BrowseIssueSearchAll(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the BrowseIssueSearchAll screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="IssueSearchAll" type="msls.VisualCollection" elementType="msls.application.Issue">
        /// Gets the issueSearchAll for this screen.
        /// </field>
        /// <field name="IssueClosedDateTime" type="Date">
        /// Gets or sets the issueClosedDateTime for this screen.
        /// </field>
        /// <field name="IssueClosedByEngineerId" type="msls.application.Engineer">
        /// Gets or sets the issueClosedByEngineerId for this screen.
        /// </field>
        /// <field name="IssueProblemDescription" type="String">
        /// Gets or sets the issueProblemDescription for this screen.
        /// </field>
        /// <field name="IssueTargetEndDateTime" type="Date">
        /// Gets or sets the issueTargetEndDateTime for this screen.
        /// </field>
        /// <field name="IssueIssueFeedbackId" type="Number">
        /// Gets or sets the issueIssueFeedbackId for this screen.
        /// </field>
        /// <field name="IssueIssueStatusId" type="Number">
        /// Gets or sets the issueIssueStatusId for this screen.
        /// </field>
        /// <field name="IssuePriorityStatusId" type="msls.application.Priority">
        /// Gets or sets the issuePriorityStatusId for this screen.
        /// </field>
        /// <field name="IssueEngineerId" type="msls.application.Engineer">
        /// Gets or sets the issueEngineerId for this screen.
        /// </field>
        /// <field name="EngineerSelectionProperty" type="msls.application.Engineer">
        /// Gets or sets the engineerSelectionProperty for this screen.
        /// </field>
        /// <field name="details" type="msls.application.BrowseIssueSearchAll.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "BrowseIssueSearchAll", parameters);
    }

    function EngineerPicker(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the EngineerPicker screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="Issue" type="msls.application.Issue">
        /// Gets or sets the issue for this screen.
        /// </field>
        /// <field name="EngineerName" type="String">
        /// Gets or sets the engineerName for this screen.
        /// </field>
        /// <field name="EngineersByName" type="msls.VisualCollection" elementType="msls.application.Engineer">
        /// Gets the engineersByName for this screen.
        /// </field>
        /// <field name="details" type="msls.application.EngineerPicker.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "EngineerPicker", parameters);
    }

    function AddEditIssueDocument(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the AddEditIssueDocument screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="IssueDocument" type="msls.application.IssueDocument">
        /// Gets or sets the issueDocument for this screen.
        /// </field>
        /// <field name="details" type="msls.application.AddEditIssueDocument.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "AddEditIssueDocument", parameters);
    }

    function BrowseEngineers(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the BrowseEngineers screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="Engineers" type="msls.VisualCollection" elementType="msls.application.Engineer">
        /// Gets the engineers for this screen.
        /// </field>
        /// <field name="details" type="msls.application.BrowseEngineers.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "BrowseEngineers", parameters);
    }

    function AddEditEngineer(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the AddEditEngineer screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="Engineer" type="msls.application.Engineer">
        /// Gets or sets the engineer for this screen.
        /// </field>
        /// <field name="details" type="msls.application.AddEditEngineer.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "AddEditEngineer", parameters);
    }

    function BrowsePriorities(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the BrowsePriorities screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="Priorities" type="msls.VisualCollection" elementType="msls.application.Priority">
        /// Gets the priorities for this screen.
        /// </field>
        /// <field name="details" type="msls.application.BrowsePriorities.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "BrowsePriorities", parameters);
    }

    function AddEditUser(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the AddEditUser screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="User" type="msls.application.User">
        /// Gets or sets the user for this screen.
        /// </field>
        /// <field name="SubjectProperty" type="String">
        /// Gets or sets the subjectProperty for this screen.
        /// </field>
        /// <field name="BodyProperty" type="String">
        /// Gets or sets the bodyProperty for this screen.
        /// </field>
        /// <field name="details" type="msls.application.AddEditUser.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "AddEditUser", parameters);
    }

    function About(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the About screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="details" type="msls.application.About.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "About", parameters);
    }

    function AddEditPriority(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the AddEditPriority screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="Priority" type="msls.application.Priority">
        /// Gets or sets the priority for this screen.
        /// </field>
        /// <field name="details" type="msls.application.AddEditPriority.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "AddEditPriority", parameters);
    }

    function BrowseIssueStatusSet(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the BrowseIssueStatusSet screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="IssueStatusSet" type="msls.VisualCollection" elementType="msls.application.IssueStatus">
        /// Gets the issueStatusSet for this screen.
        /// </field>
        /// <field name="details" type="msls.application.BrowseIssueStatusSet.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "BrowseIssueStatusSet", parameters);
    }

    function BrowseDepartments(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the BrowseDepartments screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="Departments" type="msls.VisualCollection" elementType="msls.application.Department">
        /// Gets the departments for this screen.
        /// </field>
        /// <field name="details" type="msls.application.BrowseDepartments.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "BrowseDepartments", parameters);
    }

    function BrowseUsers(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the BrowseUsers screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="Users" type="msls.VisualCollection" elementType="msls.application.User">
        /// Gets the users for this screen.
        /// </field>
        /// <field name="details" type="msls.application.BrowseUsers.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "BrowseUsers", parameters);
    }

    function AddEditDepartment(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the AddEditDepartment screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="Department" type="msls.application.Department">
        /// Gets or sets the department for this screen.
        /// </field>
        /// <field name="details" type="msls.application.AddEditDepartment.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "AddEditDepartment", parameters);
    }

    function AddEditIssueStatus(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the AddEditIssueStatus screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="IssueStatus" type="msls.application.IssueStatus">
        /// Gets or sets the issueStatus for this screen.
        /// </field>
        /// <field name="details" type="msls.application.AddEditIssueStatus.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "AddEditIssueStatus", parameters);
    }

    msls._addToNamespace("msls.application", {

        BrowseIssues: $defineScreen(BrowseIssues, [
            {
                name: "Issues", kind: "collection", elementType: lightSwitchApplication.Issue,
                createQuery: function () {
                    return this.dataWorkspace.ApplicationData.Issues;
                }
            }
        ], [
        ]),

        Startup: $defineScreen(Startup, [
            {
                name: "Engineers", kind: "collection", elementType: lightSwitchApplication.Engineer,
                createQuery: function () {
                    return this.dataWorkspace.ApplicationData.Engineers;
                }
            }
        ], [
            { name: "ViewMyIssues" },
            { name: "CreateNewIssue" },
            { name: "ViewIssues" },
            { name: "ManageEngineers" },
            { name: "ViewTimesheet" },
            { name: "ConfigureSystem" },
            { name: "ViewAuditRecords" },
            { name: "TestMethod" },
            { name: "TestMethod2" }
        ]),

        AddEditIssue: $defineScreen(AddEditIssue, [
            { name: "Issue", kind: "local", type: lightSwitchApplication.Issue },
            {
                name: "IssueResponses", kind: "collection", elementType: lightSwitchApplication.IssueResponse,
                getNavigationProperty: function () {
                    if (this.owner.Issue) {
                        return this.owner.Issue.details.properties.IssueResponses;
                    }
                    return null;
                },
                appendQuery: function () {
                    return this;
                }
            },
            { name: "EngineerName", kind: "local", type: String },
            {
                name: "EngineersByName", kind: "collection", elementType: lightSwitchApplication.Engineer,
                createQuery: function (Name) {
                    return this.dataWorkspace.ApplicationData.EngineersByName(Name);
                }
            },
            {
                name: "IssueDocuments", kind: "collection", elementType: lightSwitchApplication.IssueDocument,
                getNavigationProperty: function () {
                    if (this.owner.Issue) {
                        return this.owner.Issue.details.properties.IssueDocuments;
                    }
                    return null;
                },
                appendQuery: function () {
                    return this.expand("Issue");
                }
            }
        ], [
            { name: "ClearAwaitingClient" }
        ]),

        ViewIssue: $defineScreen(ViewIssue, [
            { name: "Issue", kind: "local", type: lightSwitchApplication.Issue }
        ], [
        ]),

        AddEditIssueResponse: $defineScreen(AddEditIssueResponse, [
            { name: "IssueResponse", kind: "local", type: lightSwitchApplication.IssueResponse },
            { name: "PopupText", kind: "local", type: String },
            { name: "PopupTitle", kind: "local", type: String }
        ], [
            { name: "DoDelete" },
            { name: "CancelPopup" }
        ]),

        BrowseIssueSearchAll: $defineScreen(BrowseIssueSearchAll, [
            {
                name: "IssueSearchAll", kind: "collection", elementType: lightSwitchApplication.Issue,
                createQuery: function (ClosedDateTime, ClosedByEngineerId, ProblemDescription, TargetEndDateTime, IssueFeedbackId, IssueStatusId, PriorityStatusId, EngineerId) {
                    return this.dataWorkspace.ApplicationData.IssueSearchAll(ClosedDateTime, ClosedByEngineerId, ProblemDescription, TargetEndDateTime, IssueFeedbackId, IssueStatusId, PriorityStatusId, EngineerId).expand("AssignedTo").expand("ClosedByEngineer").expand("Priority").expand("IssueStatus").expand("User");
                }
            },
            { name: "IssueClosedDateTime", kind: "local", type: Date },
            { name: "IssueClosedByEngineerId", kind: "local", type: lightSwitchApplication.Engineer },
            { name: "IssueProblemDescription", kind: "local", type: String },
            { name: "IssueTargetEndDateTime", kind: "local", type: Date },
            { name: "IssueIssueFeedbackId", kind: "local", type: Number },
            { name: "IssueIssueStatusId", kind: "local", type: Number },
            { name: "IssuePriorityStatusId", kind: "local", type: lightSwitchApplication.Priority },
            { name: "IssueEngineerId", kind: "local", type: lightSwitchApplication.Engineer },
            { name: "EngineerSelectionProperty", kind: "local", type: lightSwitchApplication.Engineer }
        ], [
        ]),

        EngineerPicker: $defineScreen(EngineerPicker, [
            { name: "Issue", kind: "local", type: lightSwitchApplication.Issue },
            { name: "EngineerName", kind: "local", type: String },
            {
                name: "EngineersByName", kind: "collection", elementType: lightSwitchApplication.Engineer,
                createQuery: function (Name) {
                    return this.dataWorkspace.ApplicationData.EngineersByName(Name);
                }
            }
        ], [
        ]),

        AddEditIssueDocument: $defineScreen(AddEditIssueDocument, [
            { name: "IssueDocument", kind: "local", type: lightSwitchApplication.IssueDocument }
        ], [
            { name: "DeleteIssueDocument" }
        ]),

        BrowseEngineers: $defineScreen(BrowseEngineers, [
            {
                name: "Engineers", kind: "collection", elementType: lightSwitchApplication.Engineer,
                createQuery: function () {
                    return this.dataWorkspace.ApplicationData.Engineers;
                }
            }
        ], [
        ]),

        AddEditEngineer: $defineScreen(AddEditEngineer, [
            { name: "Engineer", kind: "local", type: lightSwitchApplication.Engineer }
        ], [
        ]),

        BrowsePriorities: $defineScreen(BrowsePriorities, [
            {
                name: "Priorities", kind: "collection", elementType: lightSwitchApplication.Priority,
                createQuery: function () {
                    return this.dataWorkspace.ApplicationData.Priorities;
                }
            }
        ], [
        ]),

        AddEditUser: $defineScreen(AddEditUser, [
            { name: "User", kind: "local", type: lightSwitchApplication.User },
            { name: "SubjectProperty", kind: "local", type: String },
            { name: "BodyProperty", kind: "local", type: String }
        ], [
            { name: "SendEmail" },
            { name: "DeleteUser" }
        ]),

        About: $defineScreen(About, [
        ], [
            { name: "EmailAdministrator" }
        ]),

        AddEditPriority: $defineScreen(AddEditPriority, [
            { name: "Priority", kind: "local", type: lightSwitchApplication.Priority }
        ], [
            { name: "DeletePriority" }
        ]),

        BrowseIssueStatusSet: $defineScreen(BrowseIssueStatusSet, [
            {
                name: "IssueStatusSet", kind: "collection", elementType: lightSwitchApplication.IssueStatus,
                createQuery: function () {
                    return this.dataWorkspace.ApplicationData.IssueStatusSet;
                }
            }
        ], [
        ]),

        BrowseDepartments: $defineScreen(BrowseDepartments, [
            {
                name: "Departments", kind: "collection", elementType: lightSwitchApplication.Department,
                createQuery: function () {
                    return this.dataWorkspace.ApplicationData.Departments;
                }
            }
        ], [
        ]),

        BrowseUsers: $defineScreen(BrowseUsers, [
            {
                name: "Users", kind: "collection", elementType: lightSwitchApplication.User,
                createQuery: function () {
                    return this.dataWorkspace.ApplicationData.Users;
                }
            }
        ], [
        ]),

        AddEditDepartment: $defineScreen(AddEditDepartment, [
            { name: "Department", kind: "local", type: lightSwitchApplication.Department }
        ], [
            { name: "DeleteDepartment" }
        ]),

        AddEditIssueStatus: $defineScreen(AddEditIssueStatus, [
            { name: "IssueStatus", kind: "local", type: lightSwitchApplication.IssueStatus }
        ], [
            { name: "DeleteIssueStatus" }
        ]),

        showBrowseIssues: $defineShowScreen(function showBrowseIssues(options) {
            /// <summary>
            /// Asynchronously navigates forward to the BrowseIssues screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 0);
            return lightSwitchApplication.showScreen("BrowseIssues", parameters, options);
        }),

        showStartup: $defineShowScreen(function showStartup(options) {
            /// <summary>
            /// Asynchronously navigates forward to the Startup screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 0);
            return lightSwitchApplication.showScreen("Startup", parameters, options);
        }),

        showAddEditIssue: $defineShowScreen(function showAddEditIssue(Issue, options) {
            /// <summary>
            /// Asynchronously navigates forward to the AddEditIssue screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 1);
            return lightSwitchApplication.showScreen("AddEditIssue", parameters, options);
        }),

        showViewIssue: $defineShowScreen(function showViewIssue(Issue, options) {
            /// <summary>
            /// Asynchronously navigates forward to the ViewIssue screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 1);
            return lightSwitchApplication.showScreen("ViewIssue", parameters, options);
        }),

        showAddEditIssueResponse: $defineShowScreen(function showAddEditIssueResponse(IssueResponse, options) {
            /// <summary>
            /// Asynchronously navigates forward to the AddEditIssueResponse screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 1);
            return lightSwitchApplication.showScreen("AddEditIssueResponse", parameters, options);
        }),

        showBrowseIssueSearchAll: $defineShowScreen(function showBrowseIssueSearchAll(options) {
            /// <summary>
            /// Asynchronously navigates forward to the BrowseIssueSearchAll screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 0);
            return lightSwitchApplication.showScreen("BrowseIssueSearchAll", parameters, options);
        }),

        showEngineerPicker: $defineShowScreen(function showEngineerPicker(Issue, options) {
            /// <summary>
            /// Asynchronously navigates forward to the EngineerPicker screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 1);
            return lightSwitchApplication.showScreen("EngineerPicker", parameters, options);
        }),

        showAddEditIssueDocument: $defineShowScreen(function showAddEditIssueDocument(IssueDocument, options) {
            /// <summary>
            /// Asynchronously navigates forward to the AddEditIssueDocument screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 1);
            return lightSwitchApplication.showScreen("AddEditIssueDocument", parameters, options);
        }),

        showBrowseEngineers: $defineShowScreen(function showBrowseEngineers(options) {
            /// <summary>
            /// Asynchronously navigates forward to the BrowseEngineers screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 0);
            return lightSwitchApplication.showScreen("BrowseEngineers", parameters, options);
        }),

        showAddEditEngineer: $defineShowScreen(function showAddEditEngineer(Engineer, options) {
            /// <summary>
            /// Asynchronously navigates forward to the AddEditEngineer screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 1);
            return lightSwitchApplication.showScreen("AddEditEngineer", parameters, options);
        }),

        showBrowsePriorities: $defineShowScreen(function showBrowsePriorities(options) {
            /// <summary>
            /// Asynchronously navigates forward to the BrowsePriorities screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 0);
            return lightSwitchApplication.showScreen("BrowsePriorities", parameters, options);
        }),

        showAddEditUser: $defineShowScreen(function showAddEditUser(User, options) {
            /// <summary>
            /// Asynchronously navigates forward to the AddEditUser screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 1);
            return lightSwitchApplication.showScreen("AddEditUser", parameters, options);
        }),

        showAbout: $defineShowScreen(function showAbout(options) {
            /// <summary>
            /// Asynchronously navigates forward to the About screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 0);
            return lightSwitchApplication.showScreen("About", parameters, options);
        }),

        showAddEditPriority: $defineShowScreen(function showAddEditPriority(Priority, options) {
            /// <summary>
            /// Asynchronously navigates forward to the AddEditPriority screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 1);
            return lightSwitchApplication.showScreen("AddEditPriority", parameters, options);
        }),

        showBrowseIssueStatusSet: $defineShowScreen(function showBrowseIssueStatusSet(options) {
            /// <summary>
            /// Asynchronously navigates forward to the BrowseIssueStatusSet screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 0);
            return lightSwitchApplication.showScreen("BrowseIssueStatusSet", parameters, options);
        }),

        showBrowseDepartments: $defineShowScreen(function showBrowseDepartments(options) {
            /// <summary>
            /// Asynchronously navigates forward to the BrowseDepartments screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 0);
            return lightSwitchApplication.showScreen("BrowseDepartments", parameters, options);
        }),

        showBrowseUsers: $defineShowScreen(function showBrowseUsers(options) {
            /// <summary>
            /// Asynchronously navigates forward to the BrowseUsers screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 0);
            return lightSwitchApplication.showScreen("BrowseUsers", parameters, options);
        }),

        showAddEditDepartment: $defineShowScreen(function showAddEditDepartment(Department, options) {
            /// <summary>
            /// Asynchronously navigates forward to the AddEditDepartment screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 1);
            return lightSwitchApplication.showScreen("AddEditDepartment", parameters, options);
        }),

        showAddEditIssueStatus: $defineShowScreen(function showAddEditIssueStatus(IssueStatus, options) {
            /// <summary>
            /// Asynchronously navigates forward to the AddEditIssueStatus screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 1);
            return lightSwitchApplication.showScreen("AddEditIssueStatus", parameters, options);
        })

    });

}(msls.application));
