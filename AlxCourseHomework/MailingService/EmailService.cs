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
        public static void SendEmail(string from, string to, string message, string subject)
        {
            Console.WriteLine($"The email has been sent from: {from} \nTo: {to} \nSubject: {subject} \nMessage: {message} \nEnd\n________________");
        }
    }
}
