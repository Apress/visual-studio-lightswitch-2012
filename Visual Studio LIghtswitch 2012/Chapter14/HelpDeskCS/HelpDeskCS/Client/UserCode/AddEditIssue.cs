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
using Microsoft.LightSwitch.Threading;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Runtime.InteropServices.Automation;

namespace LightSwitchApplication
{
    public partial class AddEditIssue
    {
        //Listing 7-14. Issue Add and Edit Code
        partial void Issue_Loaded(bool succeeded)
        {

            if (!this.IssueId.HasValue)
            {
                this.IssueProperty = new Issue();
            }
            else
            {
                this.IssueProperty = this.Issue;
            }

            // Write your code here.
            this.SetDisplayNameFromEntity(this.Issue);

        }

        partial void Issue_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Issue);
        }

        partial void AddEditIssue_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Issue);
        }


        // The PDF example below uses the silverpdf library 
        // http://silverpdf.codeplex.com/license
        // The license details follow beneath:
        // 
        // Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
        // The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
        // THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

        // Listing 14-13. Programming silverPDF 
        partial void OpenPDFReport_Execute()
        {
            Microsoft.LightSwitch.Threading.Dispatchers.Main.Invoke(() =>
{
    PdfDocument document = new PdfDocument();
    document.Info.Title = "Issue";

    // Create an empty page
    PdfPage page = document.AddPage();

    // Create a font                                                 
    XFont fontHeader1 = new XFont("Verdana", 18, XFontStyle.Bold);
    XFont fontHeader2 = new XFont("Verdana", 14, XFontStyle.Bold);
    XFont fontNormal = new XFont("Verdana", 12, XFontStyle.Regular);

    // Get an XGraphics object for drawing
    XGraphics gfx = XGraphics.FromPdfPage(page);

    // Create the report text
    gfx.DrawString("HelpDesk - Issue Detail ", fontHeader1,
    XBrushes.Black, new XRect(10, 10, 200, 18), XStringFormats.TopLeft );

    gfx.DrawString("Issue Id: " + Issue.Id.ToString(), fontNormal,
        XBrushes.Black, new XRect(10, 30, 200, 18), XStringFormats.TopLeft);

    gfx.DrawString(Issue.Subject, fontHeader2,
    XBrushes.Black, new XRect(10, 50, 200, 18), XStringFormats.TopLeft);

    //.... create other Elements here

    // Save the document here
    string myDocuments =
       Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    document.Save(myDocuments + "\\IssueReport.pdf");

    // optionally 'shell' the native PDF application to view the file
    var shell = AutomationFactory.CreateObject("Shell.Application");
    shell.ShellExecute(myDocuments + "\\IssueReport.pdf", "", "", "open", 1);

});

        }
    }
}