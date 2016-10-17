/// <reference path="../GeneratedArtifacts/viewModel.js" />

//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, Pro LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

//Listing 8-8. Formatting Dates with Custom Controls
myapp.BrowseIssues.RowTemplate_render = function (element, contentItem) {
    var overdueAlert = "";
    var today = new Date();
    if (contentItem.value.TargetEndDateTime < today) {
        overdueAlert =
            "<img src='Content/Images/Warning.png' " +
            "style='float:left;padding-right:10px;'/>";
    }

    var customText = $("<div>" + overdueAlert + "<strong>" +
       moment(contentItem.value.CreateDateTime).format('ddd MMM DD YYYY') +
       "</strong></br>" +
       contentItem.value.Subject + "</div>");
    customText.appendTo($(element));
};

//Listing 8-11. Query Code
myapp.BrowseIssues.IssueSummary_render = function (element, contentItem) {

    // 1 execute the IssuesDueSoon query

    myapp.activeDataWorkspace.ApplicationData.IssuesDueSoon().execute().then(

        // 2 this code runs when the query completes
        function (promiseObjResult) {

            var issuesToday = "";
            var issuesTomorrow = "";
            var issueCountToday = 0;
            var issueCountTomorrow = 0;
            var today = new Date();
            var tomorrow =
            new Date(today.getYear(), today.getMonth(), today.getDate() + 1);

            // 3 this code consumes the query result 
            promiseObjResult.results.forEach(function (issue) {

                if (issue.TargetEndDateTime.getDate() == today.getDate()) {
                    issuesToday = issuesToday + "<li>" + issue.Subject + "</li>";
                    issueCountToday = issueCountToday + 1;
                }

                if (issue.TargetEndDateTime.getDate() == tomorrow.getDate()) {
                    issuesTomorrow = issuesTomorrow + "<li>" + issue.Subject + "</li>";
                    issueCountTomorrow = issueCountTomorrow + 1;
                }

            });

            // 4 this code creates the final HTML output 
            var heading = $("<h2>Summary</h2>" +
                "<div><strong>Issues Due Today (" + issueCountToday.toString() + ")</strong><ul>" + issuesToday + "</ul></div>" +
                        "<div><strong>Issues Due Tomorrow (" + issueCountTomorrow.toString() + ")</strong><ul>" + issuesTomorrow + "</ul></div>");

            heading.appendTo($(element));

        },
        function (error) {
            // 5 this code produces the error message 
            var heading = $("<h2>Summary</h2>" +
                "<div>Unexpected error - Summary data couldn't be retrieved because:" + error + "</div>");
            heading.appendTo($(element));
        }

        );
};

myapp.BrowseIssues.IssueList_postRender = function (element, contentItem) {
    var helpText = $("<div style='padding-bottom:20px;'>" +
        "This screen shows you how to customize the tile list control, and demonstrates how to call a query in code to return a summary of data.<br/>" +
        "</div>");
    helpText.prependTo($(element));
};