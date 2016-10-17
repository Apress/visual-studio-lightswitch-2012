//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.IO;
using Microsoft.LightSwitch;

namespace LightSwitchApplication.UserCode
{
    public static class SmtpMailHelper
    {
        const string SMTPServer = "relay.yourmailserver.net";
        const string SMTPUserId = "myUsername";
        const string SMTPPassword = "myPassword";
        const int SMTPPort = 25;

        public static void SendMail(string sendFrom,
          string sendTo,
          string subject,
          string body,
          byte[] attachment,
          string filename)
        {
            MailAddress fromAddress = new MailAddress(sendFrom);
            MailAddress toAddress = new MailAddress(sendTo);
            MailMessage mail = new MailMessage();

            //mail.From = fromAddress;
            mail.To.Add(toAddress);
            mail.Subject = subject;
            mail.Body = body;
            if (body.ToLower().Contains("<html>"))
            {
                mail.IsBodyHtml = true;
            }

            //Use the server context API to get the SMTP details from the AppOptions table
            string appOptionServer;
            string appOptionPort;
            string appOptionSentFrom;

            if (LightSwitchApplication.ServerApplicationContext.Current != null)
            {
                var appOption = LightSwitchApplication.ServerApplicationContext.Current.DataWorkspace.ApplicationData.AppOptions.FirstOrDefault();
                appOptionServer = appOption.SMTPServer;
                appOptionPort = appOption.SMTPPort;
                appOptionSentFrom = appOption.EmailFrom;
            }
            else
            {
                using (var serverContext = LightSwitchApplication.ServerApplicationContext.CreateContext())
                {
                    var appOption = serverContext.DataWorkspace.ApplicationData.AppOptions.FirstOrDefault();
                    appOptionServer = appOption.SMTPServer;
                    appOptionPort = appOption.SMTPPort;
                    appOptionSentFrom = appOption.EmailFrom;
                }
            }

            SmtpClient smtp = new SmtpClient(appOptionServer, int.Parse(appOptionPort));
            mail.From = new MailAddress(appOptionSentFrom);
            //This is the code that you'd use to pick up the hardcoded SMTP values instead
            //SmtpClient smtp = new SmtpClient(SMTPServer, SMTPPort);

            if (attachment != null && !string.IsNullOrEmpty(filename))
            {
                using (MemoryStream ms = new MemoryStream(attachment))
                {
                    mail.Attachments.Add(new Attachment(ms, filename));
                    smtp.Send(mail);
                }
            }
            else
            {
                smtp.Send(mail);
            }
        }
    }
}