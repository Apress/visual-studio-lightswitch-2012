/// <reference path="../GeneratedArtifacts/viewModel.js" />

//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

//Listing 15-13. Sending E-mail by Using a mailto Hyperlink 
myapp.About.EmailAdministrator_execute = function (screen) {
    var emailTo = "administrator@lsfaq.com";                      
    var subject = "Helpdesk Mobile App Enquiry";
    var body  = "I have an enquiry about the Helpdesk App.";

    var url = "mailto:" + emailTo +                                  
        "?subject=" + encodeURIComponent(subject) +               
        "&body=" + encodeURIComponent(body);

    document.location.href = url;                                  
};

myapp.About.Group1_render = function (element, contentItem) {
    var helpText = $("<div style='padding-bottom:20px;'>" +
     " Click on the button to compose a message using your default email client.</div>");
    helpText.prependTo($(element));
};