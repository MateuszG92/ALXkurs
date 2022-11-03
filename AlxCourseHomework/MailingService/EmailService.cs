using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AlxCourseHomework.MailingService;
 

namespace AlxCourseHomework.MailingService
{
    public class EmailService
    {
        public void SendEmail(Email property)
        {
         
            Console.WriteLine($"The email has been sent from: {property.From} \nTo: {property.To} \nSubject: {property.Subject} \nMessage: {property.Message} \nEnd\n________________");
        }
    }
}
