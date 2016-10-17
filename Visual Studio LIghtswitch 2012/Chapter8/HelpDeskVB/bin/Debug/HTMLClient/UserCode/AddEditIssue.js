/// <reference path="../GeneratedArtifacts/viewModel.js" />

//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

myapp.AddEditIssue.created = function (screen) {

    // Listing 8-1. Setting Default Values
    if (screen.Issue.Id == undefined) {                    
        screen.Issue.CreateDateTime = new Date();         
    }

    //Listing 8-2. Setting the Screen Title
    if (screen.Issue.Id == undefined) {                   
        screen.details.displayName = "New Issue";          
    } else{
        screen.details.displayName = screen.Issue.Subject; 
    }

    //Listing 8-3. Hiding Controls
    if (screen.Issue.Id == undefined) {
        screen.findContentItem("ClosureDetails").isVisible = false;
    }

    //Listing 8-6. Validating Data
    //1 add a change listener to the ClosedDateTime property
    screen.Issue.addChangeListener("ClosedDateTime",
        function (e) {

            //2 this code runs each time ClosedDateTime changes
            var issue = screen.Issue;                                     

            var contentItem = screen.findContentItem("Issue_ClosedDateTime");

            if (issue.CreateDateTime != undefined &&
            issue.ClosedDateTime < issue.CreateDateTime) {

                contentItem.validationResults = [
                   new msls.ValidationResult(
                       screen.Issue.details.properties.ClosedDateTime,
                       "Closed date can't be earlier than create date")]; 
            }
        });
};

//Listing 8-5. Working with Screen Collections 
myapp.AddEditIssue.ClearAwaitingClient_execute = function (screen) {
    for (var i = 0; i < screen.IssueResponses.count; i++) {              
        var issResp = screen.IssueResponses.data[i];                     
        issResp.AwaitingClient = false;
    }
    msls.showMessageBox('The awaiting client flag has been cleared for all issue response records');
};

myapp.AddEditIssue.Details_postRender = function (element, contentItem) {

    //Listing 8-7. Adding Custom HTML to a Screen
    //var helpText = $("<div style='padding-bottom:20px;'>" +                     
    //    "<img src='Content/Images/Info.png' style='float:left;padding-right:10px;'/>" +
    //"Use this screen to enter a new issue.<br/>" + 
    //"<a href='http://intranet/help.htm' target='_blank'>Click here</a>" +
    //" for more help.</div>");
    //helpText.prependTo($(element));

    //Listing 8-9. Running Code When Data Changes
    // 1 databind the createDateTime
    contentItem.dataBind("screen.Issue.CreateDateTime", function () {
        setTargetEndDate(contentItem);
    });

    //Listing 8-9. Running Code When Data Changes
    function setTargetEndDate(contentItem) {

        // 2 only set the target date for new issues
        if (contentItem.screen.Issue.Id == undefined
             && contentItem.screen.Issue.CreateDateTime != undefined) {

            // get the create date
            var createDate = contentItem.screen.Issue.CreateDateTime;
            var futureDate = new Date(createDate.getFullYear(), createDate.getMonth(), createDate.getDate());

            // add 3 days onto the create date
            futureDate.setDate(futureDate.getDate() + 3);              
            contentItem.screen.Issue.TargetEndDateTime = futureDate;  
        }
    };
};

// Listing 8-10. Adding the Mobiscroll Control
myapp.AddEditIssue.Issue_CreateDateTime_render = function (element, contentItem) {
    var CreateDateTime =
        $('<input id="CreateDateTime" type="datetime"/>');
    CreateDateTime.appendTo($(element));                     

    // 2 Initialize the mobiscroll control
    $(function () {
        var now = new Date();
        $('#CreateDateTime').mobiscroll().datetime({
            minDate: new Date(now.getFullYear() - 10,
            now.getMonth(), now.getDate()),
            dateFormat: 'yy-MM-dd HH:mm',
            theme: 'default',
            lang: ' ',
            display: 'modal',
            animate: ' ',
            mode: 'scroller'
        });
    });

    // 3 Listen for changes made in the view model 
    contentItem.dataBind("value", function (newValue) {
        // Update the HTML Input and Scroller Control
        CreateDateTime.val(moment(newValue).format('YYYY-MM-DD HH:mm'));
        $("#CreateDateTime").scroller('setDate', newValue, false);
    });

    // Listen for changes made via the custom control 
    CreateDateTime.change(function () {
        // update the content item value
        var newDate = moment(CreateDateTime.val(), "YYYY-MM-DD HH:mm");
        if (contentItem.value != newDate.toDate()) {
            contentItem.value = newDate.toDate();
        }
    });
};

myapp.AddEditIssue.Info_postRender = function (element, contentItem) {
    var helpText = $("<div style='padding-bottom:20px;'>" +
        "<img src='Content/Images/info_icon.gif' style='float:left;padding-right:10px;'/>" +
    "Use this screen to create or enter an issue. This screen demonstrates various screen design techniques including:<br/>" +
    "<ul>" +
    "<li>How to create and edit 'child' issue response records</li>" +
    "<li>How to use custom controls</li>" +
    "<li>How to access data in code</li>" +
    "<li>How to upload and download documents</li>" +
    "</ul><br/>" +
    "Other notable features on this screen are:<br/>" +
    "<ul>" +
    "<li>This screen hides the issue closure controls when you create a new issue. The closure controls appear when you edit an issue.</li>" +
    "<li>You can set the create date for an issue by using a custom date picker control.</li>" +
    "<li>When you modify the create date, the screen sets the target end date to 3 days later.</li>" +
    "<li>When you assign an engineer by clicking the 'Show Engineer Picker' button, the dialog uses a custom search query to make it easier for you to find an engineer.</li>" +
    "</ul><br/>" +
    "</div>");
    helpText.prependTo($(element));
};

myapp.AddEditIssue.IssueResponses_postRender = function (element, contentItem) {
    var helpText = $("<div style='padding-bottom:20px;'>" +
    "Use the controls on this tab to manage child issue response records.<br/>" +
    "<ul>" +
    "<li>To delete a record, open the issue response record and use the delete button that you'll find in the child dialog.</li>" +
    "<li>Click the 'Clear Awaiting Client Flag' button to set the Awaiting Client field on all child records to false. This feature demonstrates how you can work with child collections in code.</li>" +
    "</ul>" +
    "</div>");
    helpText.prependTo($(element));
};

myapp.AddEditIssue.IssueDocumentsTab_postRender = function (element, contentItem) {
    var helpText = $("<div style='padding-bottom:20px;'>" +
    "Use the controls on this tab to manage child issue response documents.<br/>" +
    "</div>");
    helpText.prependTo($(element));
};

myapp.AddEditIssue.Dates_postRender = function (element, contentItem) {
    var helpText = $("<div style='padding-bottom:20px;'>" +
    "<ul>" +
    "<li>The 'create date time' field uses a custom date picker control</li>" +
    "<li>Try setting a 'closed date time' that's earlier than the create date. Custom JavaScript validation prevents you from doing this. Ideally, you'd validate the other fields in the same way so that users can immediately see any data problems.</li>" +
    "</ul>" +
    "</div>");
    helpText.prependTo($(element));
};
