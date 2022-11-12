using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialAssignments
{
    public class ExercisesPage17
    {
        public static int Run21()
        {
            int a = 3;
            int b = 6;
            int c = 15;
            int d = ((a ^ b) / 2) % c;
            Console.WriteLine($"Result of operation ((a ^ b) / 2) % c is {d}");
            bool e = d + 5 > a;
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
            bool check2 = !(pt & qt) == (!pt | !qt);
            bool check3 = !(pt | qf) == (!pt & !qf);
            bool check4 = !(pt & qf) == (!pt | !qf);
            bool check5 = !(pf | qt) == (!pf & !qt);
            bool check6 = !(pf & qt) == (!pf | !qt);
            bool check7 = !(pf | qf) == (!pf & !qf);
            bool check8 = !(pf & qf) == (!pf | !qf);
            bool check9 = check1 == true && check2 == true && check3 == true && check4 == true && check5 == true && check6 == true && check7 == true && check8 == true;

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
