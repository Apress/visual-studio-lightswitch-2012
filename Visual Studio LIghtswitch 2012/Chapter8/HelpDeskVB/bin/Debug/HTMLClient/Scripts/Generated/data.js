/// <reference path="../Scripts/msls-1.0.0.js" />

window.myapp = msls.application;

(function (lightSwitchApplication) {

    var $Entity = msls.Entity,
        $DataService = msls.DataService,
        $DataWorkspace = msls.DataWorkspace,
        $defineEntity = msls._defineEntity,
        $defineDataService = msls._defineDataService,
        $defineDataWorkspace = msls._defineDataWorkspace,
        $DataServiceQuery = msls.DataServiceQuery,
        $toODataString = msls._toODataString;

    function Engineer(entitySet) {
        /// <summary>
        /// Represents the Engineer entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this engineer.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this engineer.
        /// </field>
        /// <field name="RowVersion" type="Array">
        /// Gets or sets the rowVersion for this engineer.
        /// </field>
        /// <field name="Surname" type="String">
        /// Gets or sets the surname for this engineer.
        /// </field>
        /// <field name="Firstname" type="String">
        /// Gets or sets the firstname for this engineer.
        /// </field>
        /// <field name="DateOfBirth" type="Date">
        /// Gets or sets the dateOfBirth for this engineer.
        /// </field>
        /// <field name="LoginName" type="String">
        /// Gets or sets the loginName for this engineer.
        /// </field>
        /// <field name="Issues" type="msls.EntityCollection" elementType="msls.application.Issue">
        /// Gets the issues for this engineer.
        /// </field>
        /// <field name="EngineerIssues" type="msls.EntityCollection" elementType="msls.application.Issue">
        /// Gets the engineerIssues for this engineer.
        /// </field>
        /// <field name="SSN" type="String">
        /// Gets or sets the sSN for this engineer.
        /// </field>
        /// <field name="EngineerPhoto" type="Array">
        /// Gets or sets the engineerPhoto for this engineer.
        /// </field>
        /// <field name="TimeTracking" type="msls.EntityCollection" elementType="msls.application.TimeTracking">
        /// Gets the timeTracking for this engineer.
        /// </field>
        /// <field name="SecurityVetted" type="Boolean">
        /// Gets or sets the securityVetted for this engineer.
        /// </field>
        /// <field name="ClearanceReference" type="String">
        /// Gets or sets the clearanceReference for this engineer.
        /// </field>
        /// <field name="VettingExpiryDate" type="Date">
        /// Gets or sets the vettingExpiryDate for this engineer.
        /// </field>
        /// <field name="Manager" type="msls.application.Engineer">
        /// Gets or sets the manager for this engineer.
        /// </field>
        /// <field name="Subordinates" type="msls.EntityCollection" elementType="msls.application.Engineer">
        /// Gets the subordinates for this engineer.
        /// </field>
        /// <field name="details" type="msls.application.Engineer.Details">
        /// Gets the details for this engineer.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function Issue(entitySet) {
        /// <summary>
        /// Represents the Issue entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this issue.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this issue.
        /// </field>
        /// <field name="RowVersion" type="Array">
        /// Gets or sets the rowVersion for this issue.
        /// </field>
        /// <field name="TargetEndDateTime" type="Date">
        /// Gets or sets the targetEndDateTime for this issue.
        /// </field>
        /// <field name="AssignedTo" type="msls.application.Engineer">
        /// Gets or sets the assignedTo for this issue.
        /// </field>
        /// <field name="ClosedDateTime" type="Date">
        /// Gets or sets the closedDateTime for this issue.
        /// </field>
        /// <field name="ClosedByEngineer" type="msls.application.Engineer">
        /// Gets or sets the closedByEngineer for this issue.
        /// </field>
        /// <field name="IssueResponses" type="msls.EntityCollection" elementType="msls.application.IssueResponse">
        /// Gets the issueResponses for this issue.
        /// </field>
        /// <field name="Priority" type="msls.application.Priority">
        /// Gets or sets the priority for this issue.
        /// </field>
        /// <field name="CreateDateTime" type="Date">
        /// Gets or sets the createDateTime for this issue.
        /// </field>
        /// <field name="ProblemDescription" type="String">
        /// Gets or sets the problemDescription for this issue.
        /// </field>
        /// <field name="TimeTrackings" type="msls.EntityCollection" elementType="msls.application.TimeTracking">
        /// Gets the timeTrackings for this issue.
        /// </field>
        /// <field name="IssueStatus" type="msls.application.IssueStatus">
        /// Gets or sets the issueStatus for this issue.
        /// </field>
        /// <field name="IssueDocuments" type="msls.EntityCollection" elementType="msls.application.IssueDocument">
        /// Gets the issueDocuments for this issue.
        /// </field>
        /// <field name="IssueFeedback" type="msls.EntityCollection" elementType="msls.application.IssueFeedback">
        /// Gets the issueFeedback for this issue.
        /// </field>
        /// <field name="User" type="msls.application.User">
        /// Gets or sets the user for this issue.
        /// </field>
        /// <field name="IssueStatusChanges" type="msls.EntityCollection" elementType="msls.application.IssueStatusChange">
        /// Gets the issueStatusChanges for this issue.
        /// </field>
        /// <field name="Subject" type="String">
        /// Gets or sets the subject for this issue.
        /// </field>
        /// <field name="details" type="msls.application.Issue.Details">
        /// Gets the details for this issue.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function IssueStatus(entitySet) {
        /// <summary>
        /// Represents the IssueStatus entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this issueStatus.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this issueStatus.
        /// </field>
        /// <field name="RowVersion" type="Array">
        /// Gets or sets the rowVersion for this issueStatus.
        /// </field>
        /// <field name="StatusDescription" type="String">
        /// Gets or sets the statusDescription for this issueStatus.
        /// </field>
        /// <field name="Issues" type="msls.EntityCollection" elementType="msls.application.Issue">
        /// Gets the issues for this issueStatus.
        /// </field>
        /// <field name="IssueStatusChanges" type="msls.EntityCollection" elementType="msls.application.IssueStatusChange">
        /// Gets the issueStatusChanges for this issueStatus.
        /// </field>
        /// <field name="IssueStatusChanges1" type="msls.EntityCollection" elementType="msls.application.IssueStatusChange">
        /// Gets the issueStatusChanges1 for this issueStatus.
        /// </field>
        /// <field name="details" type="msls.application.IssueStatus.Details">
        /// Gets the details for this issueStatus.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function IssueDocument(entitySet) {
        /// <summary>
        /// Represents the IssueDocument entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this issueDocument.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this issueDocument.
        /// </field>
        /// <field name="RowVersion" type="Array">
        /// Gets or sets the rowVersion for this issueDocument.
        /// </field>
        /// <field name="DocumentName" type="String">
        /// Gets or sets the documentName for this issueDocument.
        /// </field>
        /// <field name="IssueFile" type="Array">
        /// Gets or sets the issueFile for this issueDocument.
        /// </field>
        /// <field name="Issue" type="msls.application.Issue">
        /// Gets or sets the issue for this issueDocument.
        /// </field>
        /// <field name="details" type="msls.application.IssueDocument.Details">
        /// Gets the details for this issueDocument.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function IssueResponse(entitySet) {
        /// <summary>
        /// Represents the IssueResponse entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this issueResponse.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this issueResponse.
        /// </field>
        /// <field name="RowVersion" type="Array">
        /// Gets or sets the rowVersion for this issueResponse.
        /// </field>
        /// <field name="ResponseDateTime" type="Date">
        /// Gets or sets the responseDateTime for this issueResponse.
        /// </field>
        /// <field name="ResponseText" type="String">
        /// Gets or sets the responseText for this issueResponse.
        /// </field>
        /// <field name="ReviewDate" type="Date">
        /// Gets or sets the reviewDate for this issueResponse.
        /// </field>
        /// <field name="AwaitingClient" type="Boolean">
        /// Gets or sets the awaitingClient for this issueResponse.
        /// </field>
        /// <field name="Issue" type="msls.application.Issue">
        /// Gets or sets the issue for this issueResponse.
        /// </field>
        /// <field name="details" type="msls.application.IssueResponse.Details">
        /// Gets the details for this issueResponse.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function Priority(entitySet) {
        /// <summary>
        /// Represents the Priority entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this priority.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this priority.
        /// </field>
        /// <field name="RowVersion" type="Array">
        /// Gets or sets the rowVersion for this priority.
        /// </field>
        /// <field name="PriorityDesc" type="String">
        /// Gets or sets the priorityDesc for this priority.
        /// </field>
        /// <field name="Issues" type="msls.EntityCollection" elementType="msls.application.Issue">
        /// Gets the issues for this priority.
        /// </field>
        /// <field name="details" type="msls.application.Priority.Details">
        /// Gets the details for this priority.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function TimeTracking(entitySet) {
        /// <summary>
        /// Represents the TimeTracking entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this timeTracking.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this timeTracking.
        /// </field>
        /// <field name="RowVersion" type="Array">
        /// Gets or sets the rowVersion for this timeTracking.
        /// </field>
        /// <field name="DurationMins" type="Number">
        /// Gets or sets the durationMins for this timeTracking.
        /// </field>
        /// <field name="Engineer" type="msls.application.Engineer">
        /// Gets or sets the engineer for this timeTracking.
        /// </field>
        /// <field name="Issue" type="msls.application.Issue">
        /// Gets or sets the issue for this timeTracking.
        /// </field>
        /// <field name="details" type="msls.application.TimeTracking.Details">
        /// Gets the details for this timeTracking.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function IssueFeedback(entitySet) {
        /// <summary>
        /// Represents the IssueFeedback entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this issueFeedback.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this issueFeedback.
        /// </field>
        /// <field name="RowVersion" type="Array">
        /// Gets or sets the rowVersion for this issueFeedback.
        /// </field>
        /// <field name="QualityRating" type="Number">
        /// Gets or sets the qualityRating for this issueFeedback.
        /// </field>
        /// <field name="ResponseRating" type="Number">
        /// Gets or sets the responseRating for this issueFeedback.
        /// </field>
        /// <field name="StaffRating" type="Number">
        /// Gets or sets the staffRating for this issueFeedback.
        /// </field>
        /// <field name="Comment" type="String">
        /// Gets or sets the comment for this issueFeedback.
        /// </field>
        /// <field name="OverallRating" type="Number">
        /// Gets or sets the overallRating for this issueFeedback.
        /// </field>
        /// <field name="Issue" type="msls.application.Issue">
        /// Gets or sets the issue for this issueFeedback.
        /// </field>
        /// <field name="details" type="msls.application.IssueFeedback.Details">
        /// Gets the details for this issueFeedback.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function User(entitySet) {
        /// <summary>
        /// Represents the User entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this user.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this user.
        /// </field>
        /// <field name="RowVersion" type="Array">
        /// Gets or sets the rowVersion for this user.
        /// </field>
        /// <field name="Firstname" type="String">
        /// Gets or sets the firstname for this user.
        /// </field>
        /// <field name="Surname" type="String">
        /// Gets or sets the surname for this user.
        /// </field>
        /// <field name="PhoneNumber" type="String">
        /// Gets or sets the phoneNumber for this user.
        /// </field>
        /// <field name="Username" type="String">
        /// Gets or sets the username for this user.
        /// </field>
        /// <field name="Password" type="String">
        /// Gets or sets the password for this user.
        /// </field>
        /// <field name="Address1" type="String">
        /// Gets or sets the address1 for this user.
        /// </field>
        /// <field name="Address2" type="String">
        /// Gets or sets the address2 for this user.
        /// </field>
        /// <field name="City" type="String">
        /// Gets or sets the city for this user.
        /// </field>
        /// <field name="Postcode" type="String">
        /// Gets or sets the postcode for this user.
        /// </field>
        /// <field name="Country" type="String">
        /// Gets or sets the country for this user.
        /// </field>
        /// <field name="Department" type="msls.application.Department">
        /// Gets or sets the department for this user.
        /// </field>
        /// <field name="Issues" type="msls.EntityCollection" elementType="msls.application.Issue">
        /// Gets the issues for this user.
        /// </field>
        /// <field name="Email" type="String">
        /// Gets or sets the email for this user.
        /// </field>
        /// <field name="details" type="msls.application.User.Details">
        /// Gets the details for this user.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function EmailOperation(entitySet) {
        /// <summary>
        /// Represents the EmailOperation entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this emailOperation.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this emailOperation.
        /// </field>
        /// <field name="RowVersion" type="Array">
        /// Gets or sets the rowVersion for this emailOperation.
        /// </field>
        /// <field name="SenderEmail" type="String">
        /// Gets or sets the senderEmail for this emailOperation.
        /// </field>
        /// <field name="RecipientEmail" type="String">
        /// Gets or sets the recipientEmail for this emailOperation.
        /// </field>
        /// <field name="Subject" type="String">
        /// Gets or sets the subject for this emailOperation.
        /// </field>
        /// <field name="Body" type="String">
        /// Gets or sets the body for this emailOperation.
        /// </field>
        /// <field name="Attachment" type="Array">
        /// Gets or sets the attachment for this emailOperation.
        /// </field>
        /// <field name="AttachmentFileName" type="String">
        /// Gets or sets the attachmentFileName for this emailOperation.
        /// </field>
        /// <field name="details" type="msls.application.EmailOperation.Details">
        /// Gets the details for this emailOperation.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function OfficeLocation(entitySet) {
        /// <summary>
        /// Represents the OfficeLocation entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this officeLocation.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this officeLocation.
        /// </field>
        /// <field name="RowVersion" type="Array">
        /// Gets or sets the rowVersion for this officeLocation.
        /// </field>
        /// <field name="OfficeName" type="String">
        /// Gets or sets the officeName for this officeLocation.
        /// </field>
        /// <field name="Country" type="String">
        /// Gets or sets the country for this officeLocation.
        /// </field>
        /// <field name="Address1" type="String">
        /// Gets or sets the address1 for this officeLocation.
        /// </field>
        /// <field name="Address2" type="String">
        /// Gets or sets the address2 for this officeLocation.
        /// </field>
        /// <field name="City" type="String">
        /// Gets or sets the city for this officeLocation.
        /// </field>
        /// <field name="details" type="msls.application.OfficeLocation.Details">
        /// Gets the details for this officeLocation.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function Department(entitySet) {
        /// <summary>
        /// Represents the Department entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this department.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this department.
        /// </field>
        /// <field name="RowVersion" type="Array">
        /// Gets or sets the rowVersion for this department.
        /// </field>
        /// <field name="DepartmentName" type="String">
        /// Gets or sets the departmentName for this department.
        /// </field>
        /// <field name="Address1" type="String">
        /// Gets or sets the address1 for this department.
        /// </field>
        /// <field name="Address2" type="String">
        /// Gets or sets the address2 for this department.
        /// </field>
        /// <field name="City" type="String">
        /// Gets or sets the city for this department.
        /// </field>
        /// <field name="Postcode" type="String">
        /// Gets or sets the postcode for this department.
        /// </field>
        /// <field name="Country" type="String">
        /// Gets or sets the country for this department.
        /// </field>
        /// <field name="Users" type="msls.EntityCollection" elementType="msls.application.User">
        /// Gets the users for this department.
        /// </field>
        /// <field name="DepartmentManager" type="String">
        /// Gets or sets the departmentManager for this department.
        /// </field>
        /// <field name="details" type="msls.application.Department.Details">
        /// Gets the details for this department.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function AppOption(entitySet) {
        /// <summary>
        /// Represents the AppOption entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this appOption.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this appOption.
        /// </field>
        /// <field name="RowVersion" type="Array">
        /// Gets or sets the rowVersion for this appOption.
        /// </field>
        /// <field name="AuditChangesOn" type="Boolean">
        /// Gets or sets the auditChangesOn for this appOption.
        /// </field>
        /// <field name="SendEmailOn" type="Boolean">
        /// Gets or sets the sendEmailOn for this appOption.
        /// </field>
        /// <field name="SMTPServer" type="String">
        /// Gets or sets the sMTPServer for this appOption.
        /// </field>
        /// <field name="SMTPPort" type="Number">
        /// Gets or sets the sMTPPort for this appOption.
        /// </field>
        /// <field name="SMTPUsername" type="String">
        /// Gets or sets the sMTPUsername for this appOption.
        /// </field>
        /// <field name="SMTPPassword" type="String">
        /// Gets or sets the sMTPPassword for this appOption.
        /// </field>
        /// <field name="ReportWebSiteRootURL" type="String">
        /// Gets or sets the reportWebSiteRootURL for this appOption.
        /// </field>
        /// <field name="details" type="msls.application.AppOption.Details">
        /// Gets the details for this appOption.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function IssueStatusChange(entitySet) {
        /// <summary>
        /// Represents the IssueStatusChange entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this issueStatusChange.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this issueStatusChange.
        /// </field>
        /// <field name="RowVersion" type="Array">
        /// Gets or sets the rowVersion for this issueStatusChange.
        /// </field>
        /// <field name="ChangeDate" type="Date">
        /// Gets or sets the changeDate for this issueStatusChange.
        /// </field>
        /// <field name="OldStatus" type="msls.application.IssueStatus">
        /// Gets or sets the oldStatus for this issueStatusChange.
        /// </field>
        /// <field name="NewStatus" type="msls.application.IssueStatus">
        /// Gets or sets the newStatus for this issueStatusChange.
        /// </field>
        /// <field name="Issue" type="msls.application.Issue">
        /// Gets or sets the issue for this issueStatusChange.
        /// </field>
        /// <field name="details" type="msls.application.IssueStatusChange.Details">
        /// Gets the details for this issueStatusChange.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function ApplicationData(dataWorkspace) {
        /// <summary>
        /// Represents the ApplicationData data service.
        /// </summary>
        /// <param name="dataWorkspace" type="msls.DataWorkspace">
        /// The data workspace that created this data service.
        /// </param>
        /// <field name="Engineers" type="msls.EntitySet">
        /// Gets the Engineers entity set.
        /// </field>
        /// <field name="Issues" type="msls.EntitySet">
        /// Gets the Issues entity set.
        /// </field>
        /// <field name="IssueStatusSet" type="msls.EntitySet">
        /// Gets the IssueStatusSet entity set.
        /// </field>
        /// <field name="IssueDocuments" type="msls.EntitySet">
        /// Gets the IssueDocuments entity set.
        /// </field>
        /// <field name="IssueResponses" type="msls.EntitySet">
        /// Gets the IssueResponses entity set.
        /// </field>
        /// <field name="Priorities" type="msls.EntitySet">
        /// Gets the Priorities entity set.
        /// </field>
        /// <field name="TimeTrackings" type="msls.EntitySet">
        /// Gets the TimeTrackings entity set.
        /// </field>
        /// <field name="IssueFeedbacks" type="msls.EntitySet">
        /// Gets the IssueFeedbacks entity set.
        /// </field>
        /// <field name="Users" type="msls.EntitySet">
        /// Gets the Users entity set.
        /// </field>
        /// <field name="EmailOperations" type="msls.EntitySet">
        /// Gets the EmailOperations entity set.
        /// </field>
        /// <field name="OfficeLocations" type="msls.EntitySet">
        /// Gets the OfficeLocations entity set.
        /// </field>
        /// <field name="Departments" type="msls.EntitySet">
        /// Gets the Departments entity set.
        /// </field>
        /// <field name="AppOptions" type="msls.EntitySet">
        /// Gets the AppOptions entity set.
        /// </field>
        /// <field name="IssueStatusChanges" type="msls.EntitySet">
        /// Gets the IssueStatusChanges entity set.
        /// </field>
        /// <field name="details" type="msls.application.ApplicationData.Details">
        /// Gets the details for this data service.
        /// </field>
        $DataService.call(this, dataWorkspace);
    };
    function DataWorkspace() {
        /// <summary>
        /// Represents the data workspace.
        /// </summary>
        /// <field name="ApplicationData" type="msls.application.ApplicationData">
        /// Gets the ApplicationData data service.
        /// </field>
        /// <field name="details" type="msls.application.DataWorkspace.Details">
        /// Gets the details for this data workspace.
        /// </field>
        $DataWorkspace.call(this);
    };

    msls._addToNamespace("msls.application", {

        Engineer: $defineEntity(Engineer, [
            { name: "Id", type: Number },
            { name: "RowVersion", type: Array },
            { name: "Surname", type: String },
            { name: "Firstname", type: String },
            { name: "DateOfBirth", type: Date },
            { name: "LoginName", type: String },
            { name: "Issues", kind: "collection", elementType: Issue },
            { name: "EngineerIssues", kind: "collection", elementType: Issue },
            { name: "SSN", type: String },
            { name: "EngineerPhoto", type: Array },
            { name: "TimeTracking", kind: "collection", elementType: TimeTracking },
            { name: "SecurityVetted", type: Boolean },
            { name: "ClearanceReference", type: String },
            { name: "VettingExpiryDate", type: Date },
            { name: "Manager", kind: "reference", type: Engineer },
            { name: "Subordinates", kind: "collection", elementType: Engineer }
        ]),

        Issue: $defineEntity(Issue, [
            { name: "Id", type: Number },
            { name: "RowVersion", type: Array },
            { name: "TargetEndDateTime", type: Date },
            { name: "AssignedTo", kind: "reference", type: Engineer },
            { name: "ClosedDateTime", type: Date },
            { name: "ClosedByEngineer", kind: "reference", type: Engineer },
            { name: "IssueResponses", kind: "collection", elementType: IssueResponse },
            { name: "Priority", kind: "reference", type: Priority },
            { name: "CreateDateTime", type: Date },
            { name: "ProblemDescription", type: String },
            { name: "TimeTrackings", kind: "collection", elementType: TimeTracking },
            { name: "IssueStatus", kind: "reference", type: IssueStatus },
            { name: "IssueDocuments", kind: "collection", elementType: IssueDocument },
            { name: "IssueFeedback", kind: "collection", elementType: IssueFeedback },
            { name: "User", kind: "reference", type: User },
            { name: "IssueStatusChanges", kind: "collection", elementType: IssueStatusChange },
            { name: "Subject", type: String }
        ]),

        IssueStatus: $defineEntity(IssueStatus, [
            { name: "Id", type: Number },
            { name: "RowVersion", type: Array },
            { name: "StatusDescription", type: String },
            { name: "Issues", kind: "collection", elementType: Issue },
            { name: "IssueStatusChanges", kind: "collection", elementType: IssueStatusChange },
            { name: "IssueStatusChanges1", kind: "collection", elementType: IssueStatusChange }
        ]),

        IssueDocument: $defineEntity(IssueDocument, [
            { name: "Id", type: Number },
            { name: "RowVersion", type: Array },
            { name: "DocumentName", type: String },
            { name: "IssueFile", type: Array },
            { name: "Issue", kind: "reference", type: Issue }
        ]),

        IssueResponse: $defineEntity(IssueResponse, [
            { name: "Id", type: Number },
            { name: "RowVersion", type: Array },
            { name: "ResponseDateTime", type: Date },
            { name: "ResponseText", type: String },
            { name: "ReviewDate", type: Date },
            { name: "AwaitingClient", type: Boolean },
            { name: "Issue", kind: "reference", type: Issue }
        ]),

        Priority: $defineEntity(Priority, [
            { name: "Id", type: Number },
            { name: "RowVersion", type: Array },
            { name: "PriorityDesc", type: String },
            { name: "Issues", kind: "collection", elementType: Issue }
        ]),

        TimeTracking: $defineEntity(TimeTracking, [
            { name: "Id", type: Number },
            { name: "RowVersion", type: Array },
            { name: "DurationMins", type: Number },
            { name: "Engineer", kind: "reference", type: Engineer },
            { name: "Issue", kind: "reference", type: Issue }
        ]),

        IssueFeedback: $defineEntity(IssueFeedback, [
            { name: "Id", type: Number },
            { name: "RowVersion", type: Array },
            { name: "QualityRating", type: Number },
            { name: "ResponseRating", type: Number },
            { name: "StaffRating", type: Number },
            { name: "Comment", type: String },
            { name: "OverallRating", type: Number },
            { name: "Issue", kind: "reference", type: Issue }
        ]),

        User: $defineEntity(User, [
            { name: "Id", type: Number },
            { name: "RowVersion", type: Array },
            { name: "Firstname", type: String },
            { name: "Surname", type: String },
            { name: "PhoneNumber", type: String },
            { name: "Username", type: String },
            { name: "Password", type: String },
            { name: "Address1", type: String },
            { name: "Address2", type: String },
            { name: "City", type: String },
            { name: "Postcode", type: String },
            { name: "Country", type: String },
            { name: "Department", kind: "reference", type: Department },
            { name: "Issues", kind: "collection", elementType: Issue },
            { name: "Email", type: String }
        ]),

        EmailOperation: $defineEntity(EmailOperation, [
            { name: "Id", type: Number },
            { name: "RowVersion", type: Array },
            { name: "SenderEmail", type: String },
            { name: "RecipientEmail", type: String },
            { name: "Subject", type: String },
            { name: "Body", type: String },
            { name: "Attachment", type: Array },
            { name: "AttachmentFileName", type: String }
        ]),

        OfficeLocation: $defineEntity(OfficeLocation, [
            { name: "Id", type: Number },
            { name: "RowVersion", type: Array },
            { name: "OfficeName", type: String },
            { name: "Country", type: String },
            { name: "Address1", type: String },
            { name: "Address2", type: String },
            { name: "City", type: String }
        ]),

        Department: $defineEntity(Department, [
            { name: "Id", type: Number },
            { name: "RowVersion", type: Array },
            { name: "DepartmentName", type: String },
            { name: "Address1", type: String },
            { name: "Address2", type: String },
            { name: "City", type: String },
            { name: "Postcode", type: String },
            { name: "Country", type: String },
            { name: "Users", kind: "collection", elementType: User },
            { name: "DepartmentManager", type: String }
        ]),

        AppOption: $defineEntity(AppOption, [
            { name: "Id", type: Number },
            { name: "RowVersion", type: Array },
            { name: "AuditChangesOn", type: Boolean },
            { name: "SendEmailOn", type: Boolean },
            { name: "SMTPServer", type: String },
            { name: "SMTPPort", type: Number },
            { name: "SMTPUsername", type: String },
            { name: "SMTPPassword", type: String },
            { name: "ReportWebSiteRootURL", type: String }
        ]),

        IssueStatusChange: $defineEntity(IssueStatusChange, [
            { name: "Id", type: Number },
            { name: "RowVersion", type: Array },
            { name: "ChangeDate", type: Date },
            { name: "OldStatus", kind: "reference", type: IssueStatus },
            { name: "NewStatus", kind: "reference", type: IssueStatus },
            { name: "Issue", kind: "reference", type: Issue }
        ]),

        ApplicationData: $defineDataService(ApplicationData, lightSwitchApplication.rootUri + "/ApplicationData.svc", [
            { name: "Engineers", elementType: Engineer },
            { name: "Issues", elementType: Issue },
            { name: "IssueStatusSet", elementType: IssueStatus },
            { name: "IssueDocuments", elementType: IssueDocument },
            { name: "IssueResponses", elementType: IssueResponse },
            { name: "Priorities", elementType: Priority },
            { name: "TimeTrackings", elementType: TimeTracking },
            { name: "IssueFeedbacks", elementType: IssueFeedback },
            { name: "Users", elementType: User },
            { name: "EmailOperations", elementType: EmailOperation },
            { name: "OfficeLocations", elementType: OfficeLocation },
            { name: "Departments", elementType: Department },
            { name: "AppOptions", elementType: AppOption },
            { name: "IssueStatusChanges", elementType: IssueStatusChange }
        ], [
            {
                name: "Engineers_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.Engineers },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/Engineers(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "Issues_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.Issues },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/Issues(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "IssueStatusSet_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.IssueStatusSet },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/IssueStatusSet(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "IssuesDueThisWeek", value: function () {
                    return new $DataServiceQuery({ _entitySet: this.Issues },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/IssuesDueThisWeek()",
                        {
                        });
                }
            },
            {
                name: "IssueDocuments_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.IssueDocuments },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/IssueDocuments(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "IssueResponses_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.IssueResponses },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/IssueResponses(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "Priorities_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.Priorities },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/Priorities(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "TimeTrackings_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.TimeTrackings },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/TimeTrackings(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "EngineersWithOutstandingIssues", value: function () {
                    return new $DataServiceQuery({ _entitySet: this.Engineers },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/EngineersWithOutstandingIssues()",
                        {
                        });
                }
            },
            {
                name: "IssuesWithAttachments", value: function () {
                    return new $DataServiceQuery({ _entitySet: this.Issues },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/IssuesWithAttachments()",
                        {
                        });
                }
            },
            {
                name: "IssuesByMonthAndYear", value: function (IssueMonth, IssueYear) {
                    return new $DataServiceQuery({ _entitySet: this.Issues },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/IssuesByMonthAndYear()",
                        {
                            IssueMonth: $toODataString(IssueMonth, "Int32?"),
                            IssueYear: $toODataString(IssueYear, "Int32?")
                        });
                }
            },
            {
                name: "IssuesWithHighestFeedback", value: function () {
                    return new $DataServiceQuery({ _entitySet: this.Issues },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/IssuesWithHighestFeedback()",
                        {
                        });
                }
            },
            {
                name: "IssueFeedbacks_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.IssueFeedbacks },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/IssueFeedbacks(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "IssueSearchAll", value: function (ClosedDateTime, ClosedByEngineerId, ProblemDescription, TargetEndDateTime, IssueFeedbackId, IssueStatusId, PriorityStatusId, EngineerId) {
                    return new $DataServiceQuery({ _entitySet: this.Issues },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/IssueSearchAll()",
                        {
                            ClosedDateTime: $toODataString(ClosedDateTime, "DateTime?"),
                            ClosedByEngineerId: $toODataString(ClosedByEngineerId, "Int32?"),
                            ProblemDescription: $toODataString(ProblemDescription, "String?"),
                            TargetEndDateTime: $toODataString(TargetEndDateTime, "DateTime?"),
                            IssueFeedbackId: $toODataString(IssueFeedbackId, "Int32?"),
                            IssueStatusId: $toODataString(IssueStatusId, "Int32?"),
                            PriorityStatusId: $toODataString(PriorityStatusId, "Int32?"),
                            EngineerId: $toODataString(EngineerId, "Int32?")
                        });
                }
            },
            {
                name: "EngineersByManager", value: function (ManagerId) {
                    return new $DataServiceQuery({ _entitySet: this.Engineers },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/EngineersByManager()",
                        {
                            ManagerId: $toODataString(ManagerId, "Int32?")
                        });
                }
            },
            {
                name: "IssuesByEngineer", value: function (EngineerId) {
                    return new $DataServiceQuery({ _entitySet: this.Issues },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/IssuesByEngineer()",
                        {
                            EngineerId: $toODataString(EngineerId, "Int32?")
                        });
                }
            },
            {
                name: "Users_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.Users },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/Users(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "EmailOperations_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.EmailOperations },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/EmailOperations(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "OfficeLocations_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.OfficeLocations },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/OfficeLocations(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "Departments_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.Departments },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/Departments(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "AppOptions_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.AppOptions },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/AppOptions(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "IssuesOverdue", value: function () {
                    return new $DataServiceQuery({ _entitySet: this.Issues },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/IssuesOverdue()",
                        {
                        });
                }
            },
            {
                name: "IssuesWithNoResponse", value: function () {
                    return new $DataServiceQuery({ _entitySet: this.Issues },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/IssuesWithNoResponse()",
                        {
                        });
                }
            },
            {
                name: "IssueStatusChanges_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.IssueStatusChanges },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/IssueStatusChanges(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "IssuesGreaterThan7Days", value: function () {
                    return new $DataServiceQuery({ _entitySet: this.Issues },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/IssuesGreaterThan7Days()",
                        {
                        });
                }
            },
            {
                name: "EngineersByName", value: function (Name) {
                    return new $DataServiceQuery({ _entitySet: this.Engineers },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/EngineersByName()",
                        {
                            Name: $toODataString(Name, "String?")
                        });
                }
            },
            {
                name: "IssuesDueSoon", value: function () {
                    return new $DataServiceQuery({ _entitySet: this.Issues },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/IssuesDueSoon()",
                        {
                        });
                }
            }
        ]),

        DataWorkspace: $defineDataWorkspace(DataWorkspace, [
            { name: "ApplicationData", type: ApplicationData }
        ])

    });

}(msls.application));
