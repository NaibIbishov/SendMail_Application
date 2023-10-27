using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SendMail_Application.Models
{
    public class SendMail
    {
        public void Send(string alici,string movzu,string aciqlama)
        {
            
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Port = 587;
                smtpClient.Host = "smtp.outlook.com";
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential("naib.ibishov@outlook.com", "**********");

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("naib.ibishov@outlook.com", "Naib Ibishov");
                mail.To.Add(alici);
                mail.Subject = movzu;
                mail.Body = aciqlama;
               
                smtpClient.Send(mail);
            
            
            

        }
    }
}
