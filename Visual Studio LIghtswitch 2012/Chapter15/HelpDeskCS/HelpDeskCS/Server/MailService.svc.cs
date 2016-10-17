//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;

//Listing 15-17. Implementing Your Web Service Method
namespace LightSwitchApplication
{
    [AspNetCompatibilityRequirements(
        RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class MailService : IMailService
    {
        public string SendMail(
           string emailTo, string subject, string body)
        {
            try
            {
                string senderEmail = "admin@lsfaq.com";
                LightSwitchApplication.UserCode.SmtpMailHelper.SendMail(
                   senderEmail, emailTo, subject, body,
                   null, null); // optional - add email attachment here...
                return ("Email Sent");
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
