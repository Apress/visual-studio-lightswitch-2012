//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".


// Listing 8-12. File Uploader JavaScript
function createfileUploader(element, contentItem) {

    var $element = $(element);

    //1 Create either an HTML5 or Non HTML5 control
    if (window.FileReader) {
        createHTML5Control();
    } else {
        createNonHTML5Control();
    }

    //2 This code creates the HTML5 control
    function createHTML5Control() {
        var $file_browse_button = $(
            '<input name="file" type="file" style="margin-bottom: 10px;" />');
        $element.append($file_browse_button);

        var $review = $('<div></div>');
        $element.append($review);

        $file_browse_button.bind('change', function handleFileSelect(evt) {
            var files = evt.target.files;
            if (files.length == 1) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    reviewAndSetContentItem(
                        e.target.result, $review, contentItem);
                };
                reader.readAsDataURL(files[0]);
            } else {
                //  if no file was chosen, set the content to null
                reviewAndSetContentItem(null, $review, contentItem);
            }
        });
    }

    //3 This code creates the non HTML5 control
    function createNonHTML5Control() {
        // Create a file submission form
        var $file_upload_form = $('<form method="post" ' +
                'action="../Web/FileUploader/FileUploader.aspx" ' +
                'enctype="multipart/form-data" target="uploadTargetIFrame" />');
        var $file_browse_button = $(
            '<input name="file" type="file" style="margin-bottom: 10px;" />');
        $file_upload_form.append($file_browse_button);
        $element.append($file_upload_form);

        // The file contents will be posted to this hidden iframe
        var $uploadTargetIFrame = $('<iframe name="uploadTargetIFrame" ' +
                'style="width: 0px; height: 0px; border: 0px solid #fff;"/>');
        $element.append($uploadTargetIFrame);

        // This div shows the upload status, 
        //      and upload confirmation 
        var $review = $('<div></div>');
        $element.append($review);

        // Submit the file automatically when the user chooses a file
        $file_browse_button.change(function () {
            $file_upload_form.submit();
        });

        // On form submission, show a "processing" message:
        $file_upload_form.submit(function () {
            $review.append($('<div>Processing file...</div>'));
        });

        // Once the result frame is loaded (e.g., result came back), 
        //      preview the image and set the content item appropriately. 
        $uploadTargetIFrame.load(function () {
            var serverResponse = null;
            try {
                serverResponse =
                    $uploadTargetIFrame.contents().find("body").html();
            } catch (e) {
                // request must have failed, keep server response empty. 
            }
            reviewAndSetContentItem(serverResponse, $review, contentItem);
        });
    }

    //4 This code shows the upload confirmation
    function reviewAndSetContentItem(fullBinaryString, $review, contentItem) {
        $review.empty();

        if ((fullBinaryString == null) || (fullBinaryString.length == 0)) {
            contentItem.value = null;
        } else {
            //$review.append($('<img src="' + fullBinaryString + '" style="' + previewStyle + '" />'));
            $review.append($('<div>File uploaded</div>'));

            //remove the preamble that the FileReader adds
            contentItem.value =
                fullBinaryString.substring(fullBinaryString.indexOf(",") + 1);
        }
    }
}