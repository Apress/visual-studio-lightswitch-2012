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
using System.Reflection;

//Listing 14-11. Mail-Merge Code 
namespace LightSwitchApplication
{
    public partial class DepartmentsWithHighIssues
    {

        dynamic wordApp;
        dynamic wordDoc;
        object missingValue = System.Reflection.Missing.Value;

        // Here are the values of the WdMailMergeDestination Enum
        const int wdSendToNewDocument = 0;
        const int wdSendToPrinter = 1;
        const int wdSendToEmail = 2;
        const int wdSendToFax = 3;

        partial void DoMailMerge_Execute()
        {

            // Save the mail merge template to 'My Documents'
            SaveTemplateToMyDocuments();

            dynamic wordMailMerge;
            dynamic wordMergeFields;

            // Create an instance of Word  and make it visible.
            wordApp = AutomationFactory.CreateObject("Word.Application");
            wordApp.Visible = true;

            string path = Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments) + @"\MailMergeTemplate.dotx";

            // Open the template file
            wordDoc =
                wordApp.Documents.Open(path);
            wordDoc.Select();

            wordMailMerge = wordDoc.MailMerge;

            // Create a MailMerge Data file.
            CreateMailMergeDataFile();

            wordMergeFields = wordMailMerge.Fields;
            wordMailMerge.Destination = wdSendToNewDocument;

            wordMailMerge.Execute(false);

            // Close the original form document.
            wordDoc.Saved = true;
            wordDoc.Close(false, ref missingValue, ref missingValue);

            // Release References.
            wordMailMerge = null;
            wordMergeFields = null;
            wordDoc = null;
            wordApp = null;
        }

        private void CreateMailMergeDataFile()
        {
            dynamic wordDataDoc;

            var fileName = Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments) + @"\DataDoc.doc";
            var header = "DepartmentName, DepartmentManager, Address1";

            wordDoc.MailMerge.CreateDataSource(ref fileName, ref missingValue,
                ref missingValue, ref header);

            // Open the data document to insert data.
            wordDataDoc = wordApp.Documents.Open(ref fileName);

            // Loop through the customer screen collection
            // Start at rowCount 2 because row 1 contains the column headers
            int rowCount = 2;
            foreach (Department d in Departments)
            {
                FillRow(
                  wordDataDoc, rowCount,
                  d.DepartmentName, d.DepartmentManager, d.Address1);
                rowCount++;
            }

            // Save and close the file.
            wordDataDoc.Save();
            wordDataDoc.Close(false, ref missingValue, ref missingValue);

        }

        private void FillRow(dynamic wordDoc, int Row,
            string Text1, string Text2, string Text3)
        {
            if (Row > wordDoc.Tables[1].Rows.Count)
            {
                wordDoc.Tables[1].Rows.Add();
            }

            // Insert the data into the table.
            wordDoc.Tables[1].Cell(Row, 1).Range.InsertAfter(Text1);
            wordDoc.Tables[1].Cell(Row, 2).Range.InsertAfter(Text2);
            wordDoc.Tables[1].Cell(Row, 3).Range.InsertAfter(Text3);
        }

        //Listing 14-12. Creating the Mail Merge Fields in Code
        partial void DoMailMergeInCode_Execute()
        {
            dynamic wordMailMerge;
            dynamic wordMergeFields;
            dynamic wordSelection;

            // Create an instance of Word and make it visible.
            wordApp = AutomationFactory.CreateObject("Word.Application");
            wordApp.Visible = true;

            // Create a new file rather than open it from a template 
            wordDoc = wordApp.Documents.Add();

            wordSelection = wordApp.Selection;
            wordMailMerge = wordDoc.MailMerge;

            // Create a MailMerge Data file.
            CreateMailMergeDataFile();

            wordMergeFields = wordMailMerge.Fields;

            // Type the salutation and add the ' DepartmentManager' merge field
            if (FormalityProperty.GetValueOrDefault(false))
            {
                wordSelection.TypeText("Dear ");
            }
            else
            {
                wordSelection.TypeText("Hi ");
            }


            wordMergeFields.Add(wordSelection.Range, "DepartmentManager");
            wordSelection.TypeText(",");
            // add the paragraph text that the user has entered
            wordSelection.TypeText(FirstParagraphProperty);

            // Perform mail merge.
            wordMailMerge.Destination = 0;
            wordMailMerge.Execute(false);

            // Release References.
            wordMailMerge = null;
            wordMergeFields = null;
            wordDoc = null;
            wordApp = null;
        }

        private void SaveTemplateToMyDocuments()
        {
            var resourceInfo = System.Windows.Application.GetResourceStream(
                new Uri("Resources/MailMergeTemplate.dotx", UriKind.Relative));

            string path = Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments) + @"\MailMergeTemplate.dotx";

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

        partial void DepartmentsWithHighIssues_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            FirstParagraphProperty = "Enter your letter text here..";
        }
    }
}

