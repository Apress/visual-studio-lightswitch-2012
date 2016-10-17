/// <reference path="viewModel.js" />

(function (lightSwitchApplication) {

    var $parameters = [document.createElement("div"), msls.ContentItem];

    msls._addEntryPoints(lightSwitchApplication.BrowseIssues, {
        /// <field>
        /// Called when a new BrowseIssues screen is created.
        /// <br/>created(msls.application.BrowseIssues screen)
        /// </field>
        created: [lightSwitchApplication.BrowseIssues],
        /// <field>
        /// Called before changes on an active BrowseIssues screen are applied.
        /// <br/>beforeApplyChanges(msls.application.BrowseIssues screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.BrowseIssues],
        /// <field>
        /// Called after the IssueList content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        IssueList_postRender: $parameters,
        /// <field>
        /// Called after the Issue content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Issue_postRender: $parameters,
        /// <field>
        /// Called to render the RowTemplate content item.
        /// <br/>render(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        RowTemplate_render: $parameters,
        /// <field>
        /// Called to render the IssueSummary content item.
        /// <br/>render(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        IssueSummary_render: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.Startup, {
        /// <field>
        /// Called when a new Startup screen is created.
        /// <br/>created(msls.application.Startup screen)
        /// </field>
        created: [lightSwitchApplication.Startup],
        /// <field>
        /// Called before changes on an active Startup screen are applied.
        /// <br/>beforeApplyChanges(msls.application.Startup screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.Startup],
        /// <field>
        /// Called to determine if the ViewMyIssues method can be executed.
        /// <br/>canExecute(msls.application.Startup screen)
        /// </field>
        ViewMyIssues_canExecute: [lightSwitchApplication.Startup],
        /// <field>
        /// Called to execute the ViewMyIssues method.
        /// <br/>execute(msls.application.Startup screen)
        /// </field>
        ViewMyIssues_execute: [lightSwitchApplication.Startup],
        /// <field>
        /// Called to determine if the CreateNewIssue method can be executed.
        /// <br/>canExecute(msls.application.Startup screen)
        /// </field>
        CreateNewIssue_canExecute: [lightSwitchApplication.Startup],
        /// <field>
        /// Called to execute the CreateNewIssue method.
        /// <br/>execute(msls.application.Startup screen)
        /// </field>
        CreateNewIssue_execute: [lightSwitchApplication.Startup],
        /// <field>
        /// Called to determine if the ViewIssues method can be executed.
        /// <br/>canExecute(msls.application.Startup screen)
        /// </field>
        ViewIssues_canExecute: [lightSwitchApplication.Startup],
        /// <field>
        /// Called to execute the ViewIssues method.
        /// <br/>execute(msls.application.Startup screen)
        /// </field>
        ViewIssues_execute: [lightSwitchApplication.Startup],
        /// <field>
        /// Called to determine if the ManageEngineers method can be executed.
        /// <br/>canExecute(msls.application.Startup screen)
        /// </field>
        ManageEngineers_canExecute: [lightSwitchApplication.Startup],
        /// <field>
        /// Called to execute the ManageEngineers method.
        /// <br/>execute(msls.application.Startup screen)
        /// </field>
        ManageEngineers_execute: [lightSwitchApplication.Startup],
        /// <field>
        /// Called to determine if the ViewTimesheet method can be executed.
        /// <br/>canExecute(msls.application.Startup screen)
        /// </field>
        ViewTimesheet_canExecute: [lightSwitchApplication.Startup],
        /// <field>
        /// Called to execute the ViewTimesheet method.
        /// <br/>execute(msls.application.Startup screen)
        /// </field>
        ViewTimesheet_execute: [lightSwitchApplication.Startup],
        /// <field>
        /// Called to determine if the ConfigureSystem method can be executed.
        /// <br/>canExecute(msls.application.Startup screen)
        /// </field>
        ConfigureSystem_canExecute: [lightSwitchApplication.Startup],
        /// <field>
        /// Called to execute the ConfigureSystem method.
        /// <br/>execute(msls.application.Startup screen)
        /// </field>
        ConfigureSystem_execute: [lightSwitchApplication.Startup],
        /// <field>
        /// Called to determine if the ViewAuditRecords method can be executed.
        /// <br/>canExecute(msls.application.Startup screen)
        /// </field>
        ViewAuditRecords_canExecute: [lightSwitchApplication.Startup],
        /// <field>
        /// Called to execute the ViewAuditRecords method.
        /// <br/>execute(msls.application.Startup screen)
        /// </field>
        ViewAuditRecords_execute: [lightSwitchApplication.Startup],
        /// <field>
        /// Called to determine if the TestMethod method can be executed.
        /// <br/>canExecute(msls.application.Startup screen)
        /// </field>
        TestMethod_canExecute: [lightSwitchApplication.Startup],
        /// <field>
        /// Called to execute the TestMethod method.
        /// <br/>execute(msls.application.Startup screen)
        /// </field>
        TestMethod_execute: [lightSwitchApplication.Startup],
        /// <field>
        /// Called to determine if the TestMethod2 method can be executed.
        /// <br/>canExecute(msls.application.Startup screen)
        /// </field>
        TestMethod2_canExecute: [lightSwitchApplication.Startup],
        /// <field>
        /// Called to execute the TestMethod2 method.
        /// <br/>execute(msls.application.Startup screen)
        /// </field>
        TestMethod2_execute: [lightSwitchApplication.Startup],
        /// <field>
        /// Called after the Group content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Group_postRender: $parameters,
        /// <field>
        /// Called after the ManageIssuesGroup content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ManageIssuesGroup_postRender: $parameters,
        /// <field>
        /// Called after the ViewIssues content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ViewIssues_postRender: $parameters,
        /// <field>
        /// Called after the CreateNewIssue content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        CreateNewIssue_postRender: $parameters,
        /// <field>
        /// Called after the ShowBrowseIssueSearchAll content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ShowBrowseIssueSearchAll_postRender: $parameters,
        /// <field>
        /// Called after the Group1 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Group1_postRender: $parameters,
        /// <field>
        /// Called after the ManageEngineersGroup content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ManageEngineersGroup_postRender: $parameters,
        /// <field>
        /// Called after the AddEngineer content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        AddEngineer_postRender: $parameters,
        /// <field>
        /// Called after the Engineers content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Engineers_postRender: $parameters,
        /// <field>
        /// Called after the EngineersTemplate content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        EngineersTemplate_postRender: $parameters,
        /// <field>
        /// Called after the Firstname content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Firstname_postRender: $parameters,
        /// <field>
        /// Called after the Surname content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Surname_postRender: $parameters,
        /// <field>
        /// Called after the Group2 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Group2_postRender: $parameters,
        /// <field>
        /// Called after the SetupAppGroup content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        SetupAppGroup_postRender: $parameters,
        /// <field>
        /// Called after the ShowBrowsePriorities content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ShowBrowsePriorities_postRender: $parameters,
        /// <field>
        /// Called after the ShowBrowseDepartments content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ShowBrowseDepartments_postRender: $parameters,
        /// <field>
        /// Called after the ShowBrowseIssueStatusSet content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ShowBrowseIssueStatusSet_postRender: $parameters,
        /// <field>
        /// Called after the ShowBrowseUsers content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ShowBrowseUsers_postRender: $parameters,
        /// <field>
        /// Called after the ShowAbout content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ShowAbout_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.AddEditIssue, {
        /// <field>
        /// Called when a new AddEditIssue screen is created.
        /// <br/>created(msls.application.AddEditIssue screen)
        /// </field>
        created: [lightSwitchApplication.AddEditIssue],
        /// <field>
        /// Called before changes on an active AddEditIssue screen are applied.
        /// <br/>beforeApplyChanges(msls.application.AddEditIssue screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.AddEditIssue],
        /// <field>
        /// Called to determine if the ClearAwaitingClient method can be executed.
        /// <br/>canExecute(msls.application.AddEditIssue screen)
        /// </field>
        ClearAwaitingClient_canExecute: [lightSwitchApplication.AddEditIssue],
        /// <field>
        /// Called to execute the ClearAwaitingClient method.
        /// <br/>execute(msls.application.AddEditIssue screen)
        /// </field>
        ClearAwaitingClient_execute: [lightSwitchApplication.AddEditIssue],
        /// <field>
        /// Called after the Info content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Info_postRender: $parameters,
        /// <field>
        /// Called after the Details content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Details_postRender: $parameters,
        /// <field>
        /// Called after the left content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        left_postRender: $parameters,
        /// <field>
        /// Called after the Issue_Subject content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Issue_Subject_postRender: $parameters,
        /// <field>
        /// Called after the ProblemDescription content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ProblemDescription_postRender: $parameters,
        /// <field>
        /// Called after the ShowEngineerPicker content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ShowEngineerPicker_postRender: $parameters,
        /// <field>
        /// Called after the Group2 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Group2_postRender: $parameters,
        /// <field>
        /// Called after the ShowAssignedEngineerPopup content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ShowAssignedEngineerPopup_postRender: $parameters,
        /// <field>
        /// Called after the Engineer content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Engineer_postRender: $parameters,
        /// <field>
        /// Called after the Firstname content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Firstname_postRender: $parameters,
        /// <field>
        /// Called after the Surname content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Surname_postRender: $parameters,
        /// <field>
        /// Called after the Priority content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Priority_postRender: $parameters,
        /// <field>
        /// Called after the RowTemplate2 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        RowTemplate2_postRender: $parameters,
        /// <field>
        /// Called after the IssueStatus content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        IssueStatus_postRender: $parameters,
        /// <field>
        /// Called after the RowTemplate3 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        RowTemplate3_postRender: $parameters,
        /// <field>
        /// Called after the User content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        User_postRender: $parameters,
        /// <field>
        /// Called after the RowTemplate4 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        RowTemplate4_postRender: $parameters,
        /// <field>
        /// Called after the Firstname1 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Firstname1_postRender: $parameters,
        /// <field>
        /// Called after the Surname1 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Surname1_postRender: $parameters,
        /// <field>
        /// Called after the Dates content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Dates_postRender: $parameters,
        /// <field>
        /// Called to render the Issue_CreateDateTime content item.
        /// <br/>render(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Issue_CreateDateTime_render: $parameters,
        /// <field>
        /// Called after the TargetEndDateTime content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        TargetEndDateTime_postRender: $parameters,
        /// <field>
        /// Called after the ClosureDetails content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ClosureDetails_postRender: $parameters,
        /// <field>
        /// Called after the ClosedByEngineer content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ClosedByEngineer_postRender: $parameters,
        /// <field>
        /// Called after the RowTemplate1 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        RowTemplate1_postRender: $parameters,
        /// <field>
        /// Called after the Issue_ClosedDateTime content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Issue_ClosedDateTime_postRender: $parameters,
        /// <field>
        /// Called after the IssueResponses content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        IssueResponses_postRender: $parameters,
        /// <field>
        /// Called after the AddIssueResponse content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        AddIssueResponse_postRender: $parameters,
        /// <field>
        /// Called after the ClearAwaitingClient content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ClearAwaitingClient_postRender: $parameters,
        /// <field>
        /// Called after the IssueResponses1 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        IssueResponses1_postRender: $parameters,
        /// <field>
        /// Called after the RowTemplate5 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        RowTemplate5_postRender: $parameters,
        /// <field>
        /// Called after the IssueDocumentsTab content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        IssueDocumentsTab_postRender: $parameters,
        /// <field>
        /// Called after the AddIssueDocument content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        AddIssueDocument_postRender: $parameters,
        /// <field>
        /// Called after the IssueDocuments content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        IssueDocuments_postRender: $parameters,
        /// <field>
        /// Called after the IssueDocumentsTemplate content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        IssueDocumentsTemplate_postRender: $parameters,
        /// <field>
        /// Called after the AssignedEngineerPopup content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        AssignedEngineerPopup_postRender: $parameters,
        /// <field>
        /// Called after the Issue_AssignedTo3 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Issue_AssignedTo3_postRender: $parameters,
        /// <field>
        /// Called after the Surname2 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Surname2_postRender: $parameters,
        /// <field>
        /// Called after the Firstname2 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Firstname2_postRender: $parameters,
        /// <field>
        /// Called after the DateOfBirth2 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        DateOfBirth2_postRender: $parameters,
        /// <field>
        /// Called after the SecurityVetted2 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        SecurityVetted2_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.ViewIssue, {
        /// <field>
        /// Called when a new ViewIssue screen is created.
        /// <br/>created(msls.application.ViewIssue screen)
        /// </field>
        created: [lightSwitchApplication.ViewIssue],
        /// <field>
        /// Called before changes on an active ViewIssue screen are applied.
        /// <br/>beforeApplyChanges(msls.application.ViewIssue screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.ViewIssue],
        /// <field>
        /// Called after the Details content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Details_postRender: $parameters,
        /// <field>
        /// Called after the columns content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        columns_postRender: $parameters,
        /// <field>
        /// Called after the left content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        left_postRender: $parameters,
        /// <field>
        /// Called after the TargetEndDateTime content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        TargetEndDateTime_postRender: $parameters,
        /// <field>
        /// Called after the Engineer content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Engineer_postRender: $parameters,
        /// <field>
        /// Called after the ClosedDateTime content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ClosedDateTime_postRender: $parameters,
        /// <field>
        /// Called after the ClosedByEngineer content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ClosedByEngineer_postRender: $parameters,
        /// <field>
        /// Called after the Priority content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Priority_postRender: $parameters,
        /// <field>
        /// Called after the right content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        right_postRender: $parameters,
        /// <field>
        /// Called after the CreateDateTime content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        CreateDateTime_postRender: $parameters,
        /// <field>
        /// Called after the ProblemDescription content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ProblemDescription_postRender: $parameters,
        /// <field>
        /// Called after the IssueStatus content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        IssueStatus_postRender: $parameters,
        /// <field>
        /// Called after the User content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        User_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.AddEditIssueResponse, {
        /// <field>
        /// Called when a new AddEditIssueResponse screen is created.
        /// <br/>created(msls.application.AddEditIssueResponse screen)
        /// </field>
        created: [lightSwitchApplication.AddEditIssueResponse],
        /// <field>
        /// Called before changes on an active AddEditIssueResponse screen are applied.
        /// <br/>beforeApplyChanges(msls.application.AddEditIssueResponse screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.AddEditIssueResponse],
        /// <field>
        /// Called to determine if the DoDelete method can be executed.
        /// <br/>canExecute(msls.application.AddEditIssueResponse screen)
        /// </field>
        DoDelete_canExecute: [lightSwitchApplication.AddEditIssueResponse],
        /// <field>
        /// Called to execute the DoDelete method.
        /// <br/>execute(msls.application.AddEditIssueResponse screen)
        /// </field>
        DoDelete_execute: [lightSwitchApplication.AddEditIssueResponse],
        /// <field>
        /// Called to determine if the CancelPopup method can be executed.
        /// <br/>canExecute(msls.application.AddEditIssueResponse screen)
        /// </field>
        CancelPopup_canExecute: [lightSwitchApplication.AddEditIssueResponse],
        /// <field>
        /// Called to execute the CancelPopup method.
        /// <br/>execute(msls.application.AddEditIssueResponse screen)
        /// </field>
        CancelPopup_execute: [lightSwitchApplication.AddEditIssueResponse],
        /// <field>
        /// Called after the Details content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Details_postRender: $parameters,
        /// <field>
        /// Called after the columns content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        columns_postRender: $parameters,
        /// <field>
        /// Called after the left content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        left_postRender: $parameters,
        /// <field>
        /// Called after the ResponseDateTime content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ResponseDateTime_postRender: $parameters,
        /// <field>
        /// Called after the ResponseText content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ResponseText_postRender: $parameters,
        /// <field>
        /// Called after the AwaitingClient content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        AwaitingClient_postRender: $parameters,
        /// <field>
        /// Called after the ReviewDate content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ReviewDate_postRender: $parameters,
        /// <field>
        /// Called after the ConfirmDelete content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ConfirmDelete_postRender: $parameters,
        /// <field>
        /// Called after the PopupTitle content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        PopupTitle_postRender: $parameters,
        /// <field>
        /// Called after the Property1 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Property1_postRender: $parameters,
        /// <field>
        /// Called after the ButtonGroup content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ButtonGroup_postRender: $parameters,
        /// <field>
        /// Called after the DeleteMethod content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        DeleteMethod_postRender: $parameters,
        /// <field>
        /// Called after the CancelPopup content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        CancelPopup_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.BrowseIssueSearchAll, {
        /// <field>
        /// Called when a new BrowseIssueSearchAll screen is created.
        /// <br/>created(msls.application.BrowseIssueSearchAll screen)
        /// </field>
        created: [lightSwitchApplication.BrowseIssueSearchAll],
        /// <field>
        /// Called before changes on an active BrowseIssueSearchAll screen are applied.
        /// <br/>beforeApplyChanges(msls.application.BrowseIssueSearchAll screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.BrowseIssueSearchAll],
        /// <field>
        /// Called after the IssueList content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        IssueList_postRender: $parameters,
        /// <field>
        /// Called after the IssueProblemDescription content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        IssueProblemDescription_postRender: $parameters,
        /// <field>
        /// Called after the EngineerSelectionProperty content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        EngineerSelectionProperty_postRender: $parameters,
        /// <field>
        /// Called after the Issue content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Issue_postRender: $parameters,
        /// <field>
        /// Called after the RowTemplate3 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        RowTemplate3_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.EngineerPicker, {
        /// <field>
        /// Called when a new EngineerPicker screen is created.
        /// <br/>created(msls.application.EngineerPicker screen)
        /// </field>
        created: [lightSwitchApplication.EngineerPicker],
        /// <field>
        /// Called before changes on an active EngineerPicker screen are applied.
        /// <br/>beforeApplyChanges(msls.application.EngineerPicker screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.EngineerPicker],
        /// <field>
        /// Called after the Details content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Details_postRender: $parameters,
        /// <field>
        /// Called after the columns content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        columns_postRender: $parameters,
        /// <field>
        /// Called after the left content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        left_postRender: $parameters,
        /// <field>
        /// Called after the EngineerName content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        EngineerName_postRender: $parameters,
        /// <field>
        /// Called after the AssignedTo content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        AssignedTo_postRender: $parameters,
        /// <field>
        /// Called after the RowTemplate content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        RowTemplate_postRender: $parameters,
        /// <field>
        /// Called after the Firstname content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Firstname_postRender: $parameters,
        /// <field>
        /// Called after the Surname content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Surname_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.AddEditIssueDocument, {
        /// <field>
        /// Called when a new AddEditIssueDocument screen is created.
        /// <br/>created(msls.application.AddEditIssueDocument screen)
        /// </field>
        created: [lightSwitchApplication.AddEditIssueDocument],
        /// <field>
        /// Called before changes on an active AddEditIssueDocument screen are applied.
        /// <br/>beforeApplyChanges(msls.application.AddEditIssueDocument screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.AddEditIssueDocument],
        /// <field>
        /// Called to determine if the DeleteIssueDocument method can be executed.
        /// <br/>canExecute(msls.application.AddEditIssueDocument screen)
        /// </field>
        DeleteIssueDocument_canExecute: [lightSwitchApplication.AddEditIssueDocument],
        /// <field>
        /// Called to execute the DeleteIssueDocument method.
        /// <br/>execute(msls.application.AddEditIssueDocument screen)
        /// </field>
        DeleteIssueDocument_execute: [lightSwitchApplication.AddEditIssueDocument],
        /// <field>
        /// Called after the Details content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Details_postRender: $parameters,
        /// <field>
        /// Called after the columns content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        columns_postRender: $parameters,
        /// <field>
        /// Called after the left content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        left_postRender: $parameters,
        /// <field>
        /// Called after the DocumentName content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        DocumentName_postRender: $parameters,
        /// <field>
        /// Called to render the IssueFile content item.
        /// <br/>render(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        IssueFile_render: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.BrowseEngineers, {
        /// <field>
        /// Called when a new BrowseEngineers screen is created.
        /// <br/>created(msls.application.BrowseEngineers screen)
        /// </field>
        created: [lightSwitchApplication.BrowseEngineers],
        /// <field>
        /// Called before changes on an active BrowseEngineers screen are applied.
        /// <br/>beforeApplyChanges(msls.application.BrowseEngineers screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.BrowseEngineers],
        /// <field>
        /// Called after the EngineerList content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        EngineerList_postRender: $parameters,
        /// <field>
        /// Called after the Engineer content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Engineer_postRender: $parameters,
        /// <field>
        /// Called after the RowTemplate content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        RowTemplate_postRender: $parameters,
        /// <field>
        /// Called after the Firstname content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Firstname_postRender: $parameters,
        /// <field>
        /// Called after the Surname content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Surname_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.AddEditEngineer, {
        /// <field>
        /// Called when a new AddEditEngineer screen is created.
        /// <br/>created(msls.application.AddEditEngineer screen)
        /// </field>
        created: [lightSwitchApplication.AddEditEngineer],
        /// <field>
        /// Called before changes on an active AddEditEngineer screen are applied.
        /// <br/>beforeApplyChanges(msls.application.AddEditEngineer screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.AddEditEngineer],
        /// <field>
        /// Called after the Details content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Details_postRender: $parameters,
        /// <field>
        /// Called after the columns content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        columns_postRender: $parameters,
        /// <field>
        /// Called after the left content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        left_postRender: $parameters,
        /// <field>
        /// Called after the Surname content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Surname_postRender: $parameters,
        /// <field>
        /// Called after the Firstname content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Firstname_postRender: $parameters,
        /// <field>
        /// Called after the DateOfBirth content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        DateOfBirth_postRender: $parameters,
        /// <field>
        /// Called after the LoginName content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        LoginName_postRender: $parameters,
        /// <field>
        /// Called after the SSN content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        SSN_postRender: $parameters,
        /// <field>
        /// Called after the right content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        right_postRender: $parameters,
        /// <field>
        /// Called after the EngineerPhoto content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        EngineerPhoto_postRender: $parameters,
        /// <field>
        /// Called after the SecurityVetted content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        SecurityVetted_postRender: $parameters,
        /// <field>
        /// Called after the ClearanceReference content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ClearanceReference_postRender: $parameters,
        /// <field>
        /// Called after the VettingExpiryDate content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        VettingExpiryDate_postRender: $parameters,
        /// <field>
        /// Called after the Manager content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Manager_postRender: $parameters,
        /// <field>
        /// Called after the RowTemplate content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        RowTemplate_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.BrowsePriorities, {
        /// <field>
        /// Called when a new BrowsePriorities screen is created.
        /// <br/>created(msls.application.BrowsePriorities screen)
        /// </field>
        created: [lightSwitchApplication.BrowsePriorities],
        /// <field>
        /// Called before changes on an active BrowsePriorities screen are applied.
        /// <br/>beforeApplyChanges(msls.application.BrowsePriorities screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.BrowsePriorities],
        /// <field>
        /// Called after the PriorityList content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        PriorityList_postRender: $parameters,
        /// <field>
        /// Called after the AddPriority content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        AddPriority_postRender: $parameters,
        /// <field>
        /// Called after the Priority content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Priority_postRender: $parameters,
        /// <field>
        /// Called after the RowTemplate content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        RowTemplate_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.AddEditUser, {
        /// <field>
        /// Called when a new AddEditUser screen is created.
        /// <br/>created(msls.application.AddEditUser screen)
        /// </field>
        created: [lightSwitchApplication.AddEditUser],
        /// <field>
        /// Called before changes on an active AddEditUser screen are applied.
        /// <br/>beforeApplyChanges(msls.application.AddEditUser screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.AddEditUser],
        /// <field>
        /// Called to determine if the SendEmail method can be executed.
        /// <br/>canExecute(msls.application.AddEditUser screen)
        /// </field>
        SendEmail_canExecute: [lightSwitchApplication.AddEditUser],
        /// <field>
        /// Called to execute the SendEmail method.
        /// <br/>execute(msls.application.AddEditUser screen)
        /// </field>
        SendEmail_execute: [lightSwitchApplication.AddEditUser],
        /// <field>
        /// Called to determine if the DeleteUser method can be executed.
        /// <br/>canExecute(msls.application.AddEditUser screen)
        /// </field>
        DeleteUser_canExecute: [lightSwitchApplication.AddEditUser],
        /// <field>
        /// Called to execute the DeleteUser method.
        /// <br/>execute(msls.application.AddEditUser screen)
        /// </field>
        DeleteUser_execute: [lightSwitchApplication.AddEditUser],
        /// <field>
        /// Called after the Details content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Details_postRender: $parameters,
        /// <field>
        /// Called after the columns content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        columns_postRender: $parameters,
        /// <field>
        /// Called after the left content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        left_postRender: $parameters,
        /// <field>
        /// Called after the Firstname content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Firstname_postRender: $parameters,
        /// <field>
        /// Called after the Surname content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Surname_postRender: $parameters,
        /// <field>
        /// Called after the PhoneNumber content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        PhoneNumber_postRender: $parameters,
        /// <field>
        /// Called after the Username content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Username_postRender: $parameters,
        /// <field>
        /// Called after the Password content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Password_postRender: $parameters,
        /// <field>
        /// Called after the Address1 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Address1_postRender: $parameters,
        /// <field>
        /// Called after the right content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        right_postRender: $parameters,
        /// <field>
        /// Called after the Address2 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Address2_postRender: $parameters,
        /// <field>
        /// Called after the City content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        City_postRender: $parameters,
        /// <field>
        /// Called after the Postcode content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Postcode_postRender: $parameters,
        /// <field>
        /// Called after the Country content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Country_postRender: $parameters,
        /// <field>
        /// Called after the Department content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Department_postRender: $parameters,
        /// <field>
        /// Called after the RowTemplate content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        RowTemplate_postRender: $parameters,
        /// <field>
        /// Called after the Email content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Email_postRender: $parameters,
        /// <field>
        /// Called after the Group content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Group_postRender: $parameters,
        /// <field>
        /// Called after the SubjectProperty content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        SubjectProperty_postRender: $parameters,
        /// <field>
        /// Called after the BodyProperty content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        BodyProperty_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.About, {
        /// <field>
        /// Called when a new About screen is created.
        /// <br/>created(msls.application.About screen)
        /// </field>
        created: [lightSwitchApplication.About],
        /// <field>
        /// Called before changes on an active About screen are applied.
        /// <br/>beforeApplyChanges(msls.application.About screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.About],
        /// <field>
        /// Called to determine if the EmailAdministrator method can be executed.
        /// <br/>canExecute(msls.application.About screen)
        /// </field>
        EmailAdministrator_canExecute: [lightSwitchApplication.About],
        /// <field>
        /// Called to execute the EmailAdministrator method.
        /// <br/>execute(msls.application.About screen)
        /// </field>
        EmailAdministrator_execute: [lightSwitchApplication.About],
        /// <field>
        /// Called after the Group content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Group_postRender: $parameters,
        /// <field>
        /// Called after the EmailAdministrator content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        EmailAdministrator_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.AddEditPriority, {
        /// <field>
        /// Called when a new AddEditPriority screen is created.
        /// <br/>created(msls.application.AddEditPriority screen)
        /// </field>
        created: [lightSwitchApplication.AddEditPriority],
        /// <field>
        /// Called before changes on an active AddEditPriority screen are applied.
        /// <br/>beforeApplyChanges(msls.application.AddEditPriority screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.AddEditPriority],
        /// <field>
        /// Called to determine if the DeletePriority method can be executed.
        /// <br/>canExecute(msls.application.AddEditPriority screen)
        /// </field>
        DeletePriority_canExecute: [lightSwitchApplication.AddEditPriority],
        /// <field>
        /// Called to execute the DeletePriority method.
        /// <br/>execute(msls.application.AddEditPriority screen)
        /// </field>
        DeletePriority_execute: [lightSwitchApplication.AddEditPriority],
        /// <field>
        /// Called after the Details content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Details_postRender: $parameters,
        /// <field>
        /// Called after the columns content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        columns_postRender: $parameters,
        /// <field>
        /// Called after the left content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        left_postRender: $parameters,
        /// <field>
        /// Called after the PriorityDesc content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        PriorityDesc_postRender: $parameters,
        /// <field>
        /// Called after the right content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        right_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.BrowseIssueStatusSet, {
        /// <field>
        /// Called when a new BrowseIssueStatusSet screen is created.
        /// <br/>created(msls.application.BrowseIssueStatusSet screen)
        /// </field>
        created: [lightSwitchApplication.BrowseIssueStatusSet],
        /// <field>
        /// Called before changes on an active BrowseIssueStatusSet screen are applied.
        /// <br/>beforeApplyChanges(msls.application.BrowseIssueStatusSet screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.BrowseIssueStatusSet],
        /// <field>
        /// Called after the IssueStatusList content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        IssueStatusList_postRender: $parameters,
        /// <field>
        /// Called after the AddIssueStatus content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        AddIssueStatus_postRender: $parameters,
        /// <field>
        /// Called after the IssueStatus content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        IssueStatus_postRender: $parameters,
        /// <field>
        /// Called after the RowTemplate content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        RowTemplate_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.BrowseDepartments, {
        /// <field>
        /// Called when a new BrowseDepartments screen is created.
        /// <br/>created(msls.application.BrowseDepartments screen)
        /// </field>
        created: [lightSwitchApplication.BrowseDepartments],
        /// <field>
        /// Called before changes on an active BrowseDepartments screen are applied.
        /// <br/>beforeApplyChanges(msls.application.BrowseDepartments screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.BrowseDepartments],
        /// <field>
        /// Called after the DepartmentList content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        DepartmentList_postRender: $parameters,
        /// <field>
        /// Called after the AddDepartment content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        AddDepartment_postRender: $parameters,
        /// <field>
        /// Called after the Department content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Department_postRender: $parameters,
        /// <field>
        /// Called after the RowTemplate content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        RowTemplate_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.BrowseUsers, {
        /// <field>
        /// Called when a new BrowseUsers screen is created.
        /// <br/>created(msls.application.BrowseUsers screen)
        /// </field>
        created: [lightSwitchApplication.BrowseUsers],
        /// <field>
        /// Called before changes on an active BrowseUsers screen are applied.
        /// <br/>beforeApplyChanges(msls.application.BrowseUsers screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.BrowseUsers],
        /// <field>
        /// Called after the UserList content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        UserList_postRender: $parameters,
        /// <field>
        /// Called after the AddUser content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        AddUser_postRender: $parameters,
        /// <field>
        /// Called after the User content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        User_postRender: $parameters,
        /// <field>
        /// Called after the RowTemplate content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        RowTemplate_postRender: $parameters,
        /// <field>
        /// Called after the Firstname content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Firstname_postRender: $parameters,
        /// <field>
        /// Called after the Surname content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Surname_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.AddEditDepartment, {
        /// <field>
        /// Called when a new AddEditDepartment screen is created.
        /// <br/>created(msls.application.AddEditDepartment screen)
        /// </field>
        created: [lightSwitchApplication.AddEditDepartment],
        /// <field>
        /// Called before changes on an active AddEditDepartment screen are applied.
        /// <br/>beforeApplyChanges(msls.application.AddEditDepartment screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.AddEditDepartment],
        /// <field>
        /// Called to determine if the DeleteDepartment method can be executed.
        /// <br/>canExecute(msls.application.AddEditDepartment screen)
        /// </field>
        DeleteDepartment_canExecute: [lightSwitchApplication.AddEditDepartment],
        /// <field>
        /// Called to execute the DeleteDepartment method.
        /// <br/>execute(msls.application.AddEditDepartment screen)
        /// </field>
        DeleteDepartment_execute: [lightSwitchApplication.AddEditDepartment],
        /// <field>
        /// Called after the Details content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Details_postRender: $parameters,
        /// <field>
        /// Called after the columns content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        columns_postRender: $parameters,
        /// <field>
        /// Called after the left content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        left_postRender: $parameters,
        /// <field>
        /// Called after the DepartmentName content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        DepartmentName_postRender: $parameters,
        /// <field>
        /// Called after the Address1 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Address1_postRender: $parameters,
        /// <field>
        /// Called after the Address2 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Address2_postRender: $parameters,
        /// <field>
        /// Called after the City content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        City_postRender: $parameters,
        /// <field>
        /// Called after the right content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        right_postRender: $parameters,
        /// <field>
        /// Called after the Postcode content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Postcode_postRender: $parameters,
        /// <field>
        /// Called after the Country content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Country_postRender: $parameters,
        /// <field>
        /// Called after the DepartmentManager content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        DepartmentManager_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.AddEditIssueStatus, {
        /// <field>
        /// Called when a new AddEditIssueStatus screen is created.
        /// <br/>created(msls.application.AddEditIssueStatus screen)
        /// </field>
        created: [lightSwitchApplication.AddEditIssueStatus],
        /// <field>
        /// Called before changes on an active AddEditIssueStatus screen are applied.
        /// <br/>beforeApplyChanges(msls.application.AddEditIssueStatus screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.AddEditIssueStatus],
        /// <field>
        /// Called to determine if the DeleteIssueStatus method can be executed.
        /// <br/>canExecute(msls.application.AddEditIssueStatus screen)
        /// </field>
        DeleteIssueStatus_canExecute: [lightSwitchApplication.AddEditIssueStatus],
        /// <field>
        /// Called to execute the DeleteIssueStatus method.
        /// <br/>execute(msls.application.AddEditIssueStatus screen)
        /// </field>
        DeleteIssueStatus_execute: [lightSwitchApplication.AddEditIssueStatus],
        /// <field>
        /// Called after the Details content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Details_postRender: $parameters,
        /// <field>
        /// Called after the columns content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        columns_postRender: $parameters,
        /// <field>
        /// Called after the left content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        left_postRender: $parameters,
        /// <field>
        /// Called after the StatusDescription content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        StatusDescription_postRender: $parameters,
        /// <field>
        /// Called after the right content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        right_postRender: $parameters
    });

}(msls.application));
