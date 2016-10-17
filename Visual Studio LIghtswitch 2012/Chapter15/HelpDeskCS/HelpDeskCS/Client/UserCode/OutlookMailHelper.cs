//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.Automation;

//Listing 15-9. Client-Side COM Code to Create an Outlook Message
namespace LightSwitchApplication.UserCode
{
    public static class OutlookMailHelper
    {
        const int olMailItem = 0;
        const int olFormatPlain = 1;
        const int olFormatHTML = 2;

        public static void CreateEmail(
           string toAddress, string subject, string body)                       
        {
            try
            {
                dynamic outlook = null;

                if (AutomationFactory.IsAvailable)                              
                {
                    try                                             
                    {
                        //Get the reference to the open Outlook App             
                        outlook =
                           AutomationFactory.GetObject("Outlook.Application"); 
                    }
                    catch (Exception ex)
                    {
                        //Outlook isn't open, therefore try and open it
                       outlook =
                         AutomationFactory.CreateObject("Outlook.Application");
                    }

                    if (outlook != null)
                    {
                        //Create the email
                        dynamic mail = outlook.CreateItem(olMailItem);           
                        if (body.ToLower().Contains("<html>"))                   
                        {
                            mail.BodyFormat = olFormatHTML;
                            mail.HTMLBody = body;
                        }
                        else
                        {
                            mail.BodyFormat = olFormatPlain;
                            mail.Body = body;
                        }
                        mail.Recipients.Add(toAddress);                     
                        mail.Subject = subject;

                        mail.Save();                                           
                        mail.Display();                                        
                        //uncomment this code to send the email immediately
                        //mail.Send()                                     
                    }
                }

            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(
                   "Failed to create email.", ex);
            }
        }
    }

}
