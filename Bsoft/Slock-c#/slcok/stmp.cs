using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace slcok
{
    class stmp
    {
        public  bool stmpit(string subject, string body)
        {
            bool functionReturnValue = false;
            //Source code 'Create a mail message object 

            System.Net.Mail.MailMessage MyMailMessage = new System.Net.Mail.MailMessage();
            MyMailMessage.IsBodyHtml = false;
            MyMailMessage.Priority = System.Net.Mail.MailPriority.Normal;
            MyMailMessage.From = new System.Net.Mail.MailAddress("kbade@in.com");
            MyMailMessage.To.Add("kbade@in.com");
            MyMailMessage.Subject = subject;
            MyMailMessage.Body = body;
            //Dim sAttach As String
            //sAttach = "C:\j\j.jpg"
            //MyMailMessage.Attachments.Add(New System.Net.Mail.Attachment(sAttach))

            //SMTP Client and SMTP Gmail server 
            System.Net.Mail.SmtpClient SMTPServer = new System.Net.Mail.SmtpClient("smtp.gmail.com");

            SMTPServer.Port = 587;
            SMTPServer.Credentials = new System.Net.NetworkCredential("kraoski", "globalwarming");
            SMTPServer.EnableSsl = true;
            try
            {
                SMTPServer.Send(MyMailMessage);
                functionReturnValue = true;
            }
            catch  
            {
                // MsgBox.Show("Email Sent to:" & "kbade@in.com")
                functionReturnValue = false;
            }
            //MessageBox.Show(ex.Message)
            return functionReturnValue;
        }

    }
}
