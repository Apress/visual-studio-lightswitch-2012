/// <reference path="../GeneratedArtifacts/viewModel.js" />

//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

myapp.Startup.ManageIssuesGroup_postRender = function (element, contentItem) {
    var helpText = $("<div style='padding-bottom:20px;'>" +
        "This screen introduces basic concepts of screen design, including how to use tabs and how to navigate to other screens with buttons. Use the buttons on this tab to view, create, and search for issues.<br/>" +
        "</div>");
    helpText.prependTo($(element));
};

myapp.Startup.ManageEngineersGroup_postRender = function (element, contentItem) {
    var helpText = $("<div style='padding-bottom:20px;'>" +
        "Use the buttons on this tab to add and edit engineer records.<br/>" +
        "</div>");
    helpText.prependTo($(element));
};

myapp.Startup.Group2_postRender = function (element, contentItem) {
    var helpText = $("<div style='padding-bottom:20px;'>" +
        "Use the buttons on this tab to set up your data.<br/>" +
        "</div>");
    helpText.prependTo($(element));
};