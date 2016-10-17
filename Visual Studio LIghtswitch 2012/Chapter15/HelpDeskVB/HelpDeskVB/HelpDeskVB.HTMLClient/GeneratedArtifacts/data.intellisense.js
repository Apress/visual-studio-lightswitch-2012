/// <reference path="data.js" />

(function (lightSwitchApplication) {

    msls._addEntryPoints(lightSwitchApplication.Engineer, {
        /// <field>
        /// Called when a new engineer is created.
        /// <br/>created(msls.application.Engineer entity)
        /// </field>
        created: [lightSwitchApplication.Engineer]
    });

    msls._addEntryPoints(lightSwitchApplication.Issue, {
        /// <field>
        /// Called when a new issue is created.
        /// <br/>created(msls.application.Issue entity)
        /// </field>
        created: [lightSwitchApplication.Issue]
    });

    msls._addEntryPoints(lightSwitchApplication.IssueStatus, {
        /// <field>
        /// Called when a new issueStatus is created.
        /// <br/>created(msls.application.IssueStatus entity)
        /// </field>
        created: [lightSwitchApplication.IssueStatus]
    });

    msls._addEntryPoints(lightSwitchApplication.Skill, {
        /// <field>
        /// Called when a new skill is created.
        /// <br/>created(msls.application.Skill entity)
        /// </field>
        created: [lightSwitchApplication.Skill]
    });

    msls._addEntryPoints(lightSwitchApplication.EngineerSkill, {
        /// <field>
        /// Called when a new engineerSkill is created.
        /// <br/>created(msls.application.EngineerSkill entity)
        /// </field>
        created: [lightSwitchApplication.EngineerSkill]
    });

    msls._addEntryPoints(lightSwitchApplication.TimeTracking, {
        /// <field>
        /// Called when a new timeTracking is created.
        /// <br/>created(msls.application.TimeTracking entity)
        /// </field>
        created: [lightSwitchApplication.TimeTracking]
    });

    msls._addEntryPoints(lightSwitchApplication.Priority, {
        /// <field>
        /// Called when a new priority is created.
        /// <br/>created(msls.application.Priority entity)
        /// </field>
        created: [lightSwitchApplication.Priority]
    });

    msls._addEntryPoints(lightSwitchApplication.Department, {
        /// <field>
        /// Called when a new department is created.
        /// <br/>created(msls.application.Department entity)
        /// </field>
        created: [lightSwitchApplication.Department]
    });

    msls._addEntryPoints(lightSwitchApplication.User, {
        /// <field>
        /// Called when a new user is created.
        /// <br/>created(msls.application.User entity)
        /// </field>
        created: [lightSwitchApplication.User]
    });

    msls._addEntryPoints(lightSwitchApplication.IssueResponse, {
        /// <field>
        /// Called when a new issueResponse is created.
        /// <br/>created(msls.application.IssueResponse entity)
        /// </field>
        created: [lightSwitchApplication.IssueResponse]
    });

    msls._addEntryPoints(lightSwitchApplication.IssueDocument, {
        /// <field>
        /// Called when a new issueDocument is created.
        /// <br/>created(msls.application.IssueDocument entity)
        /// </field>
        created: [lightSwitchApplication.IssueDocument]
    });

    msls._addEntryPoints(lightSwitchApplication.IssueFeedback, {
        /// <field>
        /// Called when a new issueFeedback is created.
        /// <br/>created(msls.application.IssueFeedback entity)
        /// </field>
        created: [lightSwitchApplication.IssueFeedback]
    });

    msls._addEntryPoints(lightSwitchApplication.AppOption, {
        /// <field>
        /// Called when a new appOption is created.
        /// <br/>created(msls.application.AppOption entity)
        /// </field>
        created: [lightSwitchApplication.AppOption]
    });

    msls._addEntryPoints(lightSwitchApplication.EmailOperation, {
        /// <field>
        /// Called when a new emailOperation is created.
        /// <br/>created(msls.application.EmailOperation entity)
        /// </field>
        created: [lightSwitchApplication.EmailOperation]
    });

}(msls.application));
