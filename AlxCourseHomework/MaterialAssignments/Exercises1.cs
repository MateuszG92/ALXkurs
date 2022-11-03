using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AlxCourseHomework.MaterialAssignments;

namespace AlxCourseHomework.MaterialAssignments
{
    public class Exercises1
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
        public static int Run21()
        {
            int a = 3;
            int b = 6;
            int c = 15;
            int d = ((a ^ b) / 2) % c;
            Console.WriteLine($"Result of operation ((a ^ b) / 2) % c is {d}");
            bool e = d+5 > a;
            Console.WriteLine($"Is result increased by 5 more than {a}? - {e}");
            return d;

        }
        public static bool Run22()
        {
            bool pt = true;
            bool pf = false;
            bool qt = true;
            bool qf = false;
            bool check1 = !(pt | qt) == (!pt & !qt);
            bool check2 = !(pt & qt)==(!pt|!qt);
            bool check3 = !(pt | qf) == (!pt & !qf);
            bool check4= !(pt & qf)==(!pt|!qf);
            bool check5 = !(pf | qt) == (!pf & !qt);
            bool check6 = !(pf & qt) == (!pf | !qt);
            bool check7 = !(pf | qf) == (!pf & !qf);
            bool check8 = !(pf & qf) == (!pf | !qf);
            bool check9 = check1 == true && check2 == true && check3 == true && check4 ==true && check5 == true && check6 ==true && check7 == true && check8 == true;

            Console.WriteLine($"Is ~(p v q)= ~p ^ ~q if p=true and q=true true? - {check1}");
            Console.WriteLine($"Is ~(p ^ q)= ~p v ~q if p=true and q=true true? - {check2}");
            Console.WriteLine($"Is ~(p v q)= ~p ^ ~q if p=true and q=false true? - {check3}");
            Console.WriteLine($"Is ~(p ^ q)= ~p v ~q if p=true and q=false true? - {check4}");
            Console.WriteLine($"Is ~(p v q)= ~p ^ ~q if p=false and q=true true? - {check5}");
            Console.WriteLine($"Is ~(p ^ q)= ~p v ~q if p=false and q=true true? - {check6}");
            Console.WriteLine($"Is ~(p v q)= ~p ^ ~q if p=false and q=flase true? - {check7}");
            Console.WriteLine($"Is ~(p ^ q)= ~p v ~q if p=false and q=false true? - {check8}");
            Console.WriteLine($"Is all above true? - {check9}");
            if (check9 == true)
            {
                Console.WriteLine("The negation of a disjunction is the conjunction of the negations and The negation of a conjunction is the disjunction of the negations");
            }
            else { Console.WriteLine("It won't happen"); }
            return pt;
        }


    }
}
