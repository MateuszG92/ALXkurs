using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlxCourseHomework.MailingService;

namespace AlxCourseHomework.MailingService
{
    public class Homework1Test
    {
        public static void Run()
        {
            var email1 = new EmailService();
            Email newEmail1 = new Email();
            newEmail1.From = "Mateusz";
            newEmail1.To = "To1";
            newEmail1.Message = "Message1";
            newEmail1.Subject = "Subject1";
            email1.SendEmail(newEmail1);
            var email2 = new EmailService();
            Email newEmail2 = new Email();
            newEmail2.From = "Mateusz";
            newEmail2.To = "To2";
            newEmail2.Message = "Message2";
            newEmail2.Subject = "Subject2";
            email2.SendEmail(newEmail2);
            var email3 = new EmailService();
            Email newEmail3 = new Email();
            newEmail3.From = "Mateusz";
            newEmail3.To = "To3";
            newEmail3.Message = "Message3";
            newEmail3.Subject = "Subject3";
            email3.SendEmail(newEmail3);
            var email4 = new EmailService();
            Email newEmail4 = new Email();
            newEmail4.From = "Mateusz";
            newEmail4.To = "To4";
            newEmail4.Message = "Message4";
            newEmail4.Subject = "Subject4";
            email4.SendEmail(newEmail4);
            var email5 = new EmailService();
            Email newEmail5 = new Email();
            newEmail5.From = "Mateusz";
            newEmail5.To = "To5";
            newEmail5.Message = "Message5";
            newEmail5.Subject = "Subject5";
            email5.SendEmail(newEmail5);

        }
    }
}
