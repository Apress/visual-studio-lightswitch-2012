/// <reference path="data.js" />

(function (lightSwitchApplication) {

    var $Screen = msls.Screen,
        $defineScreen = msls._defineScreen,
        $DataServiceQuery = msls.DataServiceQuery,
        $toODataString = msls._toODataString,
        $defineShowScreen = msls._defineShowScreen;

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
        /// <field name="AppOptions" type="msls.VisualCollection" elementType="msls.application.AppOption">
        /// Gets the appOptions for this screen.
        /// </field>
        /// <field name="details" type="msls.application.BrowseUsers.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "BrowseUsers", parameters);
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
        /// <field name="Subject" type="String">
        /// Gets or sets the subject for this screen.
        /// </field>
        /// <field name="Body" type="String">
        /// Gets or sets the body for this screen.
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

    function AddEditAppOption(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the AddEditAppOption screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="AppOption" type="msls.application.AppOption">
        /// Gets or sets the appOption for this screen.
        /// </field>
        /// <field name="details" type="msls.application.AddEditAppOption.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "AddEditAppOption", parameters);
    }

    msls._addToNamespace("msls.application", {

        BrowseUsers: $defineScreen(BrowseUsers, [
            {
                name: "Users", kind: "collection", elementType: lightSwitchApplication.User,
                createQuery: function () {
                    return this.dataWorkspace.ApplicationData.Users.expand("Department");
                }
            },
            {
                name: "AppOptions", kind: "collection", elementType: lightSwitchApplication.AppOption,
                createQuery: function () {
                    return this.dataWorkspace.ApplicationData.AppOptions;
                }
            }
        ], [
        ]),

        AddEditUser: $defineScreen(AddEditUser, [
            { name: "User", kind: "local", type: lightSwitchApplication.User },
            { name: "Subject", kind: "local", type: String },
            { name: "Body", kind: "local", type: String }
        ], [
            { name: "SendEmail" },
            { name: "SendMailAjax" }
        ]),

        About: $defineScreen(About, [
        ], [
            { name: "EmailAdministrator" }
        ]),

        AddEditAppOption: $defineScreen(AddEditAppOption, [
            { name: "AppOption", kind: "local", type: lightSwitchApplication.AppOption }
        ], [
        ]),

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

        showAddEditAppOption: $defineShowScreen(function showAddEditAppOption(AppOption, options) {
            /// <summary>
            /// Asynchronously navigates forward to the AddEditAppOption screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 1);
            return lightSwitchApplication.showScreen("AddEditAppOption", parameters, options);
        })

    });

}(msls.application));
