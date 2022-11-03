using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AlxCourseHomework.MaterialAssignments;

namespace AlxCourseHomework.MaterialAssignments
{
    public class ExercisesPage12
    {

        public static void Run11()
        {
            string Name = "Mateusz";
            string LastName = "Gumkowski";
            int Age = 30;
            double Hight = 1.92;
            string Sex = "Male";
            long PeselNumber = 92180900000;

            Console.WriteLine($"Name - {Name}\nLast name - {LastName}\nAge - {Age}\nHight - {Hight}\nSex - {Sex} \nPesel - {PeselNumber}");
            
        }
        public static void Run12()
        {
            string Name = "Mateusz";
            string LastName = "Gumkowski";
            int Age = 30;
            double Hight = 1.92;
            int HightInt = (int)Hight;
            string Sex = "Male";
            long PeselNumber = 92180900000;

            Console.WriteLine($"Name - {Name}\nLast name - {LastName}\nAge - {Age}\nHight - {HightInt}\nSex - {Sex} \nPesel - {PeselNumber}");

        }
        public static void Run13()
        {
            Days today = (Days)3;
            Months todaysMonth = (Months)10;
            int year = 2022;
            Console.WriteLine($"Today is {today} {todaysMonth} {year}");
            
        }
     

    }
}
