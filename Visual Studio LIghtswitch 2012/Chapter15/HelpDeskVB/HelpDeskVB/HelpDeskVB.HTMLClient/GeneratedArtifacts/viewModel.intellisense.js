/// <reference path="viewModel.js" />

(function (lightSwitchApplication) {

    var $parameters = [document.createElement("div"), msls.ContentItem];

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
        /// Called after the Group content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Group_postRender: $parameters,
        /// <field>
        /// Called to render the Group2 content item.
        /// <br/>render(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Group2_render: $parameters,
        /// <field>
        /// Called after the Group1 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Group1_postRender: $parameters,
        /// <field>
        /// Called after the ShowAbout content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ShowAbout_postRender: $parameters,
        /// <field>
        /// Called after the AppOptions content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        AppOptions_postRender: $parameters,
        /// <field>
        /// Called after the AppOptions1 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        AppOptions1_postRender: $parameters,
        /// <field>
        /// Called after the AppOptions1Template content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        AppOptions1Template_postRender: $parameters,
        /// <field>
        /// Called after the UserList content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        UserList_postRender: $parameters,
        /// <field>
        /// Called after the User content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        User_postRender: $parameters,
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
        /// Called to determine if the SendMailAjax method can be executed.
        /// <br/>canExecute(msls.application.AddEditUser screen)
        /// </field>
        SendMailAjax_canExecute: [lightSwitchApplication.AddEditUser],
        /// <field>
        /// Called to execute the SendMailAjax method.
        /// <br/>execute(msls.application.AddEditUser screen)
        /// </field>
        SendMailAjax_execute: [lightSwitchApplication.AddEditUser],
        /// <field>
        /// Called after the Details content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Details_postRender: $parameters,
        /// <field>
        /// Called to render the Group content item.
        /// <br/>render(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Group_render: $parameters,
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
        /// Called after the Email content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Email_postRender: $parameters,
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
        /// Called after the ContactUser content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ContactUser_postRender: $parameters,
        /// <field>
        /// Called to render the Group1 content item.
        /// <br/>render(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Group1_render: $parameters,
        /// <field>
        /// Called after the Subject content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Subject_postRender: $parameters,
        /// <field>
        /// Called after the Body content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Body_postRender: $parameters,
        /// <field>
        /// Called after the SendEmail content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        SendEmail_postRender: $parameters,
        /// <field>
        /// Called after the SendMailAjax content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        SendMailAjax_postRender: $parameters
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
        /// Called to render the Group1 content item.
        /// <br/>render(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Group1_render: $parameters,
        /// <field>
        /// Called after the EmailAdministrator content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        EmailAdministrator_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.AddEditAppOption, {
        /// <field>
        /// Called when a new AddEditAppOption screen is created.
        /// <br/>created(msls.application.AddEditAppOption screen)
        /// </field>
        created: [lightSwitchApplication.AddEditAppOption],
        /// <field>
        /// Called before changes on an active AddEditAppOption screen are applied.
        /// <br/>beforeApplyChanges(msls.application.AddEditAppOption screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.AddEditAppOption],
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
        /// Called after the SMTPServer content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        SMTPServer_postRender: $parameters,
        /// <field>
        /// Called after the SMTPPort content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        SMTPPort_postRender: $parameters,
        /// <field>
        /// Called after the EmailFrom content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        EmailFrom_postRender: $parameters
    });

}(msls.application));
