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
using System.Runtime.InteropServices.Automation;

namespace LightSwitchApplication
{
    public partial class DepartmentDetail
    {
        partial void Department_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Department);
        }

        partial void Department_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Department);
        }

        partial void DepartmentDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Department);
        }


        //'Listing 14-8. Microsoft Word Automation Code 

        partial void CreateWordDoc_Execute()
        {
            if (AutomationFactory.IsAvailable)
            {
                try
                {
                    //Copy the word template file to 'My Documents'
                    SaveTemplateToMyDocuments();
                    string path = Environment.GetFolderPath(
                        Environment.SpecialFolder.MyDocuments) + @"\LetterTemplate.dotx";

                    using (dynamic wordApp =
                        AutomationFactory.CreateObject("Word.Application"))
                    {
                        dynamic wordDoc = wordApp.Documents.Open(
                            path);
                        wordDoc.Bookmarks("DepartmentName").Range.InsertAfter(
                            Department.DepartmentName);
                        wordApp.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Failed to create letter.", ex);
                }
            }
        }

        partial void CreateWordDocPrinter_Execute()
        {
            if (AutomationFactory.IsAvailable)
            {
                try
                {

                    //Copy the word template file to 'My Documents'
                    SaveTemplateToMyDocuments();
                    string path = Environment.GetFolderPath(
                        Environment.SpecialFolder.MyDocuments) + @"\LetterTemplate.dotx";

                    using (dynamic wordApp =
                        AutomationFactory.CreateObject("Word.Application"))
                    {
                        dynamic wordDoc = wordApp.Documents.Open(
                            path);
                        wordDoc.Bookmarks("DepartmentName").Range.InsertAfter(
                            Department.DepartmentName);
                        wordApp.PrintOut();
                        wordDoc.Close(0);
                    }
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Failed to create letter.", ex);
                }
            }

        }

        //Listing 14-10. Saving the Word Template to My Documents\LetterTemplate.dot

        private void SaveTemplateToMyDocuments()
        {
            var resourceInfo = System.Windows.Application.GetResourceStream(
                new Uri("Resources/LetterTemplate.dotx", UriKind.Relative));

            string path = Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments) + @"\LetterTemplate.dotx";

            dynamic file = System.IO.File.Create(path);
            file.Close();

            //Write the stream to the file
            System.IO.Stream stream = resourceInfo.Stream;

            using (FileStream fileStream = System.IO.File.Open(path,
                System.IO.FileMode.OpenOrCreate,
                System.IO.FileAccess.Write,
                System.IO.FileShare.None))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, int.Parse(stream.Length.ToString()));
                fileStream.Write(buffer, 0, buffer.Length);
            }
        }
    }
}