//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Listing 15-14. SendMail Handler Code
namespace LightSwitchApplication.Web
{
    /// <summary>
    /// Summary description for SendMail
    /// </summary>
    public class SendMail : IHttpHandler
    {

        //Listing 15-14. SendMail Handler Code
        public void ProcessRequest(HttpContext context)
        {
            //1 Is the user authenticated? Does he belong in the Manager Role?          
            //context.User.Identity.IsAuthenticated 
            //context.User.IsInRole("Manager")

            if (context.Request.Params["emailTo"] != null &&
                context.Request.Params["subject"] != null &&
                context.Request.Params["body"] != null)
            {
                try
                {
                    string senderEmail = "admin@lsfaq.com";
                    LightSwitchApplication.UserCode.SmtpMailHelper.SendMail(
                        senderEmail,
                        context.Request.Params["emailTo"].ToString(),
                        context.Request.Params["subject"].ToString(),
                        context.Request.Params["body"].ToString(), null, null);
                    context.Response.Write("Email Sent");
                }
                catch (Exception ex)
                {
                    context.Response.Write(ex.Message);
                }
            }
            else
            {
                context.Response.Write("EmailTo, Subject, and Body required");
            }

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}