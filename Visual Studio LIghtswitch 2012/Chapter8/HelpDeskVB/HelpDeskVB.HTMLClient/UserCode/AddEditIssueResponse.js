/// <reference path="../GeneratedArtifacts/viewModel.js" />

//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

//Listing 8-4. Deleting Records 
// Part 1 - Popup Display Code
myapp.AddEditIssueResponse.created = function (screen) {
    screen.PopupTitle = "Confirm Delete";
    screen.PopupText = "Are you sure you want to delete this record?";
};

// Part 2 - Popup Button Code
myapp.AddEditIssueResponse.CancelPopup_execute = function (screen) {
    screen.closePopup();
};

myapp.AddEditIssueResponse.DoDelete_execute = function (screen) {
    screen.IssueResponse.deleteEntity();
    myapp.applyChanges();
    myapp.navigateBack();   
};

