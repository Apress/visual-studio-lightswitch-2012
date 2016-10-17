/// <reference path="../GeneratedArtifacts/viewModel.js" />

//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

myapp.BrowseUsers.Group2_render = function (element, contentItem) {

    var helpText = $("<div style='padding-bottom:20px;'>" +
         "This application demonstrates how to send email." +
         "<ul>" +
         "<li>Use the 'App Options' tab to set up your SMTP server details</li>" +
         "<li>Click the 'Show About' button to open a screen that opens the default mail client</li>" +
         "<li>Use the 'User List' tab to send an email to a user</li>" +
         " </ul></div>");

    helpText.prependTo($(element));

};