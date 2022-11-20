using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialAssignments
{
    public class ExercisesPage23
    {
        public static void Run51()
        {
            string[] Products = new string[] {"Bread", "Tomato", "Juice", "Eggs" };
            double[] Prices = new double[] { 4, 5.5, 8, 0.3 };
            Console.WriteLine("List of goods:");
            foreach (string good in Products)
            {
                Console.WriteLine(good);
            }
            Console.WriteLine("Choose what article price you want to see: ");
            var ArticleChoice = Console.ReadLine();
            for (int i = 0; i < Products.GetLength(0); i++)
            {
                if (ArticleChoice.ToLower() == Products[i].ToLower())
                {
                    Console.WriteLine("You chose: " + Products[i]);
                    Console.WriteLine("Brutto price is: " + Prices[i]);
                    Console.WriteLine("Netto price is: " + Prices[i] / 1.23);
                }
            }
        }

        public static void Run52()
        {
            int[,] array = new int[3, 3];
            int numberInArray=0;
            for (int iterator1 = 0; iterator1 < array.GetLength(0); iterator1++)
            {
                for (int iterator2 = 0; iterator2 < array.GetLength(1); iterator2++)
                {
                    Console.Write($"{array[iterator1, iterator2] =numberInArray++} ");
                }
                Console.WriteLine();
            }
        }

        public static void Run53()
        {
            Console.WriteLine("How many number you want to add");
            var howManyGivenNumbers = Int32.Parse(Console.ReadLine());
            double[] numbers = new double[howManyGivenNumbers];
            Console.WriteLine("Given number multiplied by? (enter number):");
            var multipliedBy = Double.Parse(Console.ReadLine());
            Console.WriteLine($"Write {howManyGivenNumbers} numbers that will be multiplied by {multipliedBy} and added to list:");
            for(int i = 0; i < howManyGivenNumbers; i++)
            {
                numbers[i]=Double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Given numbers multiplied by {multipliedBy}:");
            foreach (double i in numbers)
            {
                Console.WriteLine(i * multipliedBy);
            }
        }
    }
}
