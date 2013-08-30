using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace TextMessage
{
    public class TextMessage
    {
        public enum CellProvider
        {
            Rogers = 0,
            Aliant = 1
        }

        public string FromAddress { get; set; }

        public TextMessage()
        {
           var hosts = new Dictionary<CellProvider, string>()
           {
                {CellProvider.Rogers, "sms.rogers.com"},
                {CellProvider.Aliant, "sms.wirefree.informe.ca"}
           };
        }

        public void SendMessage(string phoneNumber, string subject, string messageString, CellProvider provider)
        {

            MailMessage message = new MailMessage();
            message.To.Add("luckyperson@online.microsoft.com");
            message.Subject = subject;
            message.From = new System.Net.Mail.MailAddress(FromAddress);
            message.Body = messageString;
            SmtpClient smtp = new SmtpClient();
            smtp.Send(message);

        }


    }
}
