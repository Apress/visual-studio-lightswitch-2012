// You can use and redistribute the code from this book (and sample application) for non-commercial and 
// most commercial purposes as long as you acknowledge the source and authorship. 
// You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
// The acknowledgment should include author, title, publisher, and ISBN. 
// An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
using System.Windows.Controls;
using Microsoft.LightSwitch.Threading;


namespace LightSwitchApplication
{
    public partial class CreateNewIssueDocument
    {
        partial void CreateNewIssueDocument_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Write your code here.
            this.IssueDocumentProperty = new IssueDocument();

              if(IssueId.HasValue){
                //set the default value
                IssueDocumentProperty.Issue =
                    DataWorkspace.ApplicationData.Issues.Where(item => item.Id == IssueId).SingleOrDefault();
              }
        }

        partial void CreateNewIssueDocument_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.IssueDocumentProperty);
        }


        //        Listing 7-23. Uploading a Ffile
        partial void UploadFileToDatabase_Execute()
{
    //1 Invoke the method on the main UI thread                           
    Dispatchers.Main.Invoke(() =>
    {
        OpenFileDialog openDialog = new OpenFileDialog();                     
        openDialog.Filter = "Supported files|*.*";
        //Use this syntax to only allow Word/Excel files
        //opendlg.Filter = "Word Files|*.doc|Excel Files |*.xls"; 

        if (openDialog.ShowDialog() == true)
        {
            using (System.IO.FileStream fileData =
                openDialog.File.OpenRead())
            {
                int fileLen = (int)fileData.Length;

                if ((fileLen > 0))
                {
                    byte[] fileBArray = new byte[fileLen];
                    fileData.Read(fileBArray, 0, fileLen);                   
                    fileData.Close();

                    this.IssueDocumentProperty.IssueFile = fileBArray;       
                    this.IssueDocumentProperty.FileExtension =
                        openDialog.File.Extension.ToString();
                    this.IssueDocumentProperty.DocumentName = 
                        openDialog.File.Name;
                }
            }
        }

    });
}


    }
}