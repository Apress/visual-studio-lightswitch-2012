/// <reference path="../GeneratedArtifacts/viewModel.js" />

//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

// Listing 8-14. File Uploader JavaScript Code
myapp.AddEditIssueDocument.IssueFile_render = function (element, contentItem) {  
  createfileUploader(element, contentItem);   
};

// Listing 8-16. Button Code That Calls DownloadIssueDocument.ashx
myapp.AddEditIssueDocument.left_postRender = function (element, contentItem) {

    if (contentItem.value.Id != undefined) {
        var downloadURL = '../Web/DownloadIssueDocument.ashx?id=' + contentItem.value.Id.toString();

        var downloadLink = $('<div><a target="_blank" ' +
              'href="' + downloadURL + '" style="margin-top: 10px;" >' +
              'Download Document File</a></div>');
        downloadLink.appendTo($(element));
    }    
};

myapp.AddEditIssueDocument.columns_postRender = function (element, contentItem) {
    var helpText = $("<div style='padding-bottom:20px;'>" +
        "Use this screen to upload, update, or download a document.<br/>" +
        "</div>");
    helpText.prependTo($(element));
};

myapp.AddEditIssueDocument.DeleteIssueDocument_execute = function (screen) {
    screen.IssueDocument.deleteEntity();
};