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
using System.Runtime.InteropServices.Automation;

namespace LightSwitchApplication
{
    public partial class IssueDocumentDetail
    {
        partial void IssueDocument_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.IssueDocument);
        }

        partial void IssueDocument_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.IssueDocument);
        }

        partial void IssueDocumentDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.IssueDocument);
        }

        //Listing 7-24. Downloading a Ffile
        partial void SaveFileFromDatabase_Execute()
        {
            //1 Invoke the method on the main UI thread                          
            Dispatchers.Main.Invoke(() =>
            {
                System.IO.MemoryStream ms =
                    new System.IO.MemoryStream(IssueDocument.IssueFile);

                Dispatchers.Main.Invoke(() =>
                {
                    SaveFileDialog saveDialog = new SaveFileDialog();

                    if (saveDialog.ShowDialog() == true)
                    {
                        using (Stream fileStream = saveDialog.OpenFile())
                        {
                            ms.WriteTo(fileStream);
                        }
                    }
                });
            });
        }


        // Listing 7-25. Opening Ffiles in Ttheir Aapplications
        partial void OpenFileFromDatabase_Execute()
        {
            try
            {
                if ((AutomationFactory.IsAvailable))
                {
                    //this is where we'll save the file
                    string fullFilePath = System.IO.Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                        IssueDocument.DocumentName);

                    byte[] fileData = IssueDocument.IssueFile.ToArray();

                    if ((fileData != null))
                    {
                        using (FileStream fs =
                            new FileStream(
                                fullFilePath, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            fs.Write(fileData, 0, fileData.Length);
                            fs.Close();
                        }
                    }

                    dynamic shell = AutomationFactory.CreateObject("Shell.Application");
                    shell.ShellExecute(fullFilePath);
                }
            }
            catch (Exception ex)
            {
                this.ShowMessageBox(ex.ToString());
            }
        }



    }
}