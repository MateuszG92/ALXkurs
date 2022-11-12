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


            Email newEmail1 = new Email();
            newEmail1.From = "Mateusz";
            newEmail1.To = "To1";
            newEmail1.Message = "Message1";
            newEmail1.Subject = "Subject1";
            EmailService.SendEmail(newEmail1.From, newEmail1.To, newEmail1.Message, newEmail1.Subject);
            
            Email newEmail2 = new Email();
            newEmail2.From = "Mateusz";
            newEmail2.To = "To2";
            newEmail2.Message = "Message2";
            newEmail2.Subject = "Subject2";
            EmailService.SendEmail(newEmail2.From, newEmail2.To, newEmail2.Message, newEmail2.Subject);
            
            Email newEmail3 = new Email();
            newEmail3.From = "Mateusz";
            newEmail3.To = "To3";
            newEmail3.Message = "Message3";
            newEmail3.Subject = "Subject3";
            EmailService.SendEmail(newEmail3.From, newEmail3.To, newEmail3.Message, newEmail3.Subject);
           
            Email newEmail4 = new Email();
            newEmail4.From = "Mateusz";
            newEmail4.To = "To4";
            newEmail4.Message = "Message4";
            newEmail4.Subject = "Subject4";
            EmailService.SendEmail(newEmail4.From, newEmail4.To, newEmail4.Message, newEmail4.Subject);

            Email newEmail5 = new Email();
            newEmail5.From = "Mateusz";
            newEmail5.To = "To5";
            newEmail5.Message = "Message5";
            newEmail5.Subject = "Subject5";
            EmailService.SendEmail(newEmail5.From,newEmail5.To,newEmail5.Message,newEmail5.Subject);

        }
    }
}
