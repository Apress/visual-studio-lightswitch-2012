//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

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
using System.Windows.Controls;
using System.Windows;
using System.Runtime.InteropServices.Automation;
using System.ServiceModel;
using Microsoft.LightSwitch.Threading;

namespace LightSwitchApplication
{
    public partial class UserDetail
    {
        partial void User_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.User);
        }

        partial void User_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.User);
        }

        partial void UserDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.User);
        }

        //Listing 15-5. Button Code for Sending E-mail
        partial void SendEmail_Execute()
        {
            using (var tempWorkspace = new DataWorkspace())
            {
                EmailOperation newEmail =
                   tempWorkspace.ApplicationData.EmailOperations.AddNew();

                newEmail.RecipientEmail = User.Email;
                newEmail.SenderEmail = "admin@lsfaq.com";
                newEmail.Subject = SubjectProperty;
                newEmail.Body = BodyProperty;

                try
                {
                    tempWorkspace.ApplicationData.SaveChanges();

                    //If you want, you can write some code here to create a record in an audit table
                    newEmail.Delete();
                    tempWorkspace.ApplicationData.SaveChanges();
                    this.ShowMessageBox("Your email has been sent");

                }
                catch (Exception ex)
                {
                    this.ShowMessageBox(ex.Message);
                }
            }


        }

        //Listing 15-7. Screen Code to Send E-mail Attachments
        partial void UserDetail_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            var control = this.FindControl("FileUploadButton");

            control.ControlAvailable +=
            (object sender, ControlAvailableEventArgs e) =>
            {
                var fileButton = (Button)e.Control;
                fileButton.Content = "Send Message With Attachment";

                fileButton.Click +=
                    (object sender2, RoutedEventArgs e2) =>
                    {
                        OpenFileDialog dlg = new OpenFileDialog();
                        if (dlg.ShowDialog().GetValueOrDefault(false) == true)
                        {
                            byte[] data;
                            using (FileStream stream = dlg.File.OpenRead())
                            {
                                data = new byte[stream.Length];
                                stream.Read(data, 0, data.Length);
                            }

                            string filename = dlg.File.Name;
                            //send the email here
                            this.Details.Dispatcher.BeginInvoke(() =>
                            {
                                using (var dw = new DataWorkspace())
                                {
                                    EmailOperation newEmail =
                                       dw.ApplicationData.EmailOperations.AddNew();
                                    newEmail.RecipientEmail = User.Email;
                                    newEmail.SenderEmail = "admin@lsfaq.com";
                                    newEmail.Subject = SubjectProperty;
                                    newEmail.Body = BodyProperty;
                                    newEmail.Attachment = data;
                                    newEmail.AttachmentFileName = filename;

                                    try
                                    {
                                        dw.ApplicationData.SaveChanges();
                                        //If you want, you can write some code here to 
                                        //create a record in an audit table
                                        newEmail.Delete();
                                        dw.ApplicationData.SaveChanges();
                                    }
                                    catch (Exception ex)
                                    {
                                        this.ShowMessageBox(ex.Message);
                                    }
                                }
                            });
                        };
                    };
            };
        }

        //Listing 15-10. Screen Code to Create an Outlook Message 
        partial void SendWithOutlook_Execute()
        {
            LightSwitchApplication.UserCode.OutlookMailHelper.CreateEmail(
                User.Email,
                SubjectProperty,
                BodyProperty);
        }

        partial void SendWithOutlook_CanExecute(ref bool result)
        {
            result = AutomationFactory.IsAvailable;
        }


        //Listing 15-12. Screen Code to Use the Default Client  
        partial void OpenDefaultMailClient_Execute()
        {
            // Write your code here.
            OpenDefaultMailClient(
                User.Email,
                SubjectProperty,
                BodyProperty);

        }

        //Listing 15-11. Sending E-mail by Using a mailto Hyperlink 

        public static void OpenDefaultMailClient(
    string toAddress, string subject, string body)
        {
            subject = Uri.EscapeDataString(subject);
            body = Uri.EscapeDataString(body);

            string url = string.Format(
                "mailto:{0}?subject={1}&body={2}", toAddress, subject, body);
            Uri uri = new Uri(url);

            if (AutomationFactory.IsAvailable)
            {
                var shell = AutomationFactory.CreateObject("Shell.Application");
                shell.ShellExecute(url);
            }
            else
            {
                Microsoft.LightSwitch.Threading.Dispatchers.Main.BeginInvoke(() =>
                {
                    System.Windows.Browser.HtmlPage.Window.Navigate(
                       uri, "_blank");
                });
            }
        }

        //Listing 15-19. Screen Code to Send an E-mail via a Web Service Call
        partial void SendWithWebService_Execute()
        {
            Microsoft.LightSwitch.Threading.Dispatchers.Main.BeginInvoke(() =>
            {
                Uri serverUrl = System.Windows.Application.Current.Host.Source;

                this.Details.Dispatcher.BeginInvoke(() =>
                {
                    //serverUrl.AbsoluteUri returns a URL like this: 
                    //    http://localhost:49715/Client/Web/HelpDesk.Client.xap
                    string rootUrl =
                       serverUrl.AbsoluteUri.Substring(
                          0, serverUrl.AbsoluteUri.IndexOf("/Client/Web/"));

                    var binding = new System.ServiceModel.BasicHttpBinding();

                    //example endPoint url:
                    //   http://localhost:49715/MailService.svc/MailService.svc
                    var endPoint =
                       new EndpointAddress(rootUrl + "/MailService.svc/MailService.svc");

                    MailService.MailServiceClient proxy =
                        new MailService.MailServiceClient(binding, endPoint);

                    proxy.SendMailCompleted +=
                        (object sender, MailService.SendMailCompletedEventArgs e) =>
                        {
                            this.Details.Dispatcher.BeginInvoke(() =>
                            {
                                this.ShowMessageBox(e.Result.ToString());
                            });
                        };

                    proxy.SendMailAsync(User.Email, SubjectProperty, BodyProperty);

                });
            }
            );

        }


    }
}