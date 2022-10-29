using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alxkurs.Lessons
{
    public class L1Strings
    {
        public static void Test()
        {
            string name = "Mateusz";
            Console.WriteLine(name);
            name = "Ala";
            Console.WriteLine(name);
            name = name + " ma kota";
            Console.WriteLine(name);

            ExpandString(name, " hello1");
            Console.WriteLine(name);
            ExpandString(name, " hello2");
            Console.WriteLine(name);
            ExpandString(name, " hello3");
            Console.WriteLine(name);
        }

        public static void ExpandString(string word, string extansion)
        {
            word = word + extansion;
        }
        

    }
}
