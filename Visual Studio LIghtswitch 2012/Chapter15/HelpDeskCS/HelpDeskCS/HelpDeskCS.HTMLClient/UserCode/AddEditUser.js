/// <reference path="../GeneratedArtifacts/viewModel.js" />

//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

//Listing 15-6. Sending an E-mail in the HTML Client 
myapp.AddEditUser.SendEmail_execute = function (screen) {

    var tempWorkspace = new msls.application.DataWorkspace();
    var newEmail = new myapp.EmailOperation(
        tempWorkspace.ApplicationData.EmailOperations);

    newEmail.RecipientEmail = screen.User.Email;
    newEmail.SenderEmail = "admin@lsfaq.com";
    newEmail.Subject = screen.Subject ;
    newEmail.Body = screen.Body;

    return tempWorkspace.ApplicationData.saveChanges().then(function () {
        newEmail.deleteEntity();
        return tempWorkspace.ApplicationData.saveChanges().then(function () {
            msls.showMessageBox("Your email has been sent");
        });
    });

};

//Listing 15-15. Calling the SendEmail Handler Page via AJAX
myapp.AddEditUser.SendMailAjax_execute = function (screen) {

    return new msls.promiseOperation(function (operation) {
        var emailTo = screen.User.Email;
        var mailUrl = "../Web/SendMail.ashx" +
            "?emailTo=" + emailTo +
            "&subject=" + encodeURIComponent(screen.Subject) +
            "&body=" + encodeURIComponent(screen.Body);
        $.ajax({
            type: 'post',
            data: {},
            url: mailUrl,
            success: function success(result) {
                operation.complete();
                msls.showMessageBox(result);
            },
            error: function err(jqXHR, textStatus, errorThrown) {
                operation.error(errorThrown);
            }
        });
    });

};

myapp.AddEditUser.Group_render = function (element, contentItem) {
    var helpText = $("<div style='padding-bottom:20px;'>" +
     "Use this screen to compose an email.<ul>" +
     "<li>The 'Send Email' button sends your message using the EmailOperation table</li>" +
     "<li>The 'Send Email AJAX' button sends you message via an AJAX call to a web service</li>" +
     " </ul></div>");
    helpText.prependTo($(element));
};