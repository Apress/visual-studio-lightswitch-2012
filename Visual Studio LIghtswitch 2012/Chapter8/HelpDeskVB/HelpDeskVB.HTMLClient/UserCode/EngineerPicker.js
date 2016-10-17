/// <reference path="../GeneratedArtifacts/viewModel.js" />

//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

myapp.EngineerPicker.Details_postRender = function (element, contentItem) {
    var helpText = $("<div style='padding-bottom:20px;'>" +
    "This dialog makes it easier to find engineers. Type the engineer you want to search for and use the 'assigned to' control to find a list of matching records." +
    "</div>");
    helpText.prependTo($(element));    
};