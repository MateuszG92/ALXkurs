using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alxkurs.Lessons.M2.L1
{
    public class L1Loops
    {
        public static void RunForeach()
        {
            List<string> names = new List<string>();
            names.Add("Adrian"); 
            names.Add("Mateusz"); 
            names.Add("Monika"); 
            names.Add("Magda"); 
            names.Add("Andrzej"); 

            foreach (string name in names)
            {
                Console.WriteLine(name);
                Console.WriteLine(name.ToLower()+" name.");
            }
        }

        public static void RunFor()
        {
            int[] numbers = new int[10] {1,2,34,4,5,66,7,8,9,10};

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]+" ");
            }
            Console.WriteLine();
            for (int i = numbers.Length-1; i >=0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
        public static void RunWhile()
        {
            var c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            while (c != 'n')
            {
                Console.WriteLine("still inside the loop");
                Console.Write("Write a character: ");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            Console.WriteLine("outside rhe loop");
        }
        public static void RunDoWhile()
        {
            char c = 'q';

            do
            {
                Console.WriteLine("still inside the loop");
                Console.Write("Write a character: ");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (c != 'n');

            Console.WriteLine("outside the loop");
        }
    }
}
