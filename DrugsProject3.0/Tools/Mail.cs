using BE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DrugsProject3._0.Tools
{
    public class Mail
    {
        public string MailAddress { get { return "drugProject770@gmail.com"; } }
        public string MailPassword { get { return "Aa963852"; } }

        public void SendMail(string mailTo, string mailSubject, string mailBody, List<Recipe> r = null)
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                if (r != null)
                {
                    foreach (var item in r)
                    {
                        if (File.Exists(item.RecipeId + ".pdf"))
                        {
                            mailMessage.Attachments.Add(new Attachment(item.RecipeId + ".pdf"));
                        }
                        
                    }
                    
                }

                
                mailMessage.Subject = mailSubject;
                mailMessage.From = new MailAddress(MailAddress);
                mailMessage.Body = mailBody;
                mailMessage.To.Add(mailTo);
                SmtpClient smtp = new SmtpClient("smtp.Gmail.com");
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(MailAddress, MailPassword);
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.Send(mailMessage);

            }
            catch (Exception e)
            {

                throw e;
            }
            
        }
    }
}






