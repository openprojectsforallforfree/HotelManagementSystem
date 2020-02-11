using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading;
namespace Bsoft.Email
{
    public class Smtp
    {
        private bool SendIt(string subject, string filePath, bool deleteOnSuccess)
        {
            bool functionReturnValue = false;
            //Source code 'Create a mail message object 

            System.Net.Mail.MailMessage MyMailMessage = new System.Net.Mail.MailMessage();
            MyMailMessage.IsBodyHtml = false;
            MyMailMessage.Priority = System.Net.Mail.MailPriority.Normal;
            MyMailMessage.From = new System.Net.Mail.MailAddress("bajrasoft@gmail.com");
            MyMailMessage.To.Add("bajrasoft@gmail.com");
            MyMailMessage.Subject = subject;
            MyMailMessage.Body = System.IO.File.ReadAllText(filePath);
            //Dim sAttach As String
            //sAttach = "C:\j\j.jpg"
            //MyMailMessage.Attachments.Add(New System.Net.Mail.Attachment(sAttach))

            //SMTP Client and SMTP Gmail server 
            System.Net.Mail.SmtpClient SMTPServer = new System.Net.Mail.SmtpClient("smtp.gmail.com");

            SMTPServer.Port = 587;
            SMTPServer.Credentials = new System.Net.NetworkCredential("bajrasoft", "s@lech0r");
            SMTPServer.EnableSsl = true;

            try
            {
                
                SMTPServer.Send(MyMailMessage);
                functionReturnValue = true;
                if (deleteOnSuccess)
                {
                    System.IO.File.Delete(filePath);
                }
            }
            catch  
            {
                functionReturnValue = false;
            }
            //MessageBox.Show(ex.Message)
            return functionReturnValue;
        }

        private void SendAllContentsOfDirectory(string Subject, string directoryPath, bool AppendFilenameTosubject)
        {
            foreach (string file in System.IO.Directory.GetFiles(directoryPath))
            {
                string subject = Subject;
                if (AppendFilenameTosubject)
                {
                    subject = subject + ":" + Path.GetFileNameWithoutExtension(file);
                }

                SendIt(subject, file, true);
            }
        }

        public Thread SendDirectoryContentThread(string subject, string path)
        {
            var t = new Thread(() => SendAllContentsOfDirectory(subject, path, true));
            t.Start();
            return t;
        }


    }
}
