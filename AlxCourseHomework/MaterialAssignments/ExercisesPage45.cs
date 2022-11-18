using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlxCourseHomework.MaterialAssignments;

namespace AlxCourseHomework.MaterialAssignments
{
    public class ExercisesPage45
    {
        public static void Run41()
        {
            string price;
            Car car1 = new Car("BMW", 50000, 20000, 0.23);
            car1.Present();
            price=car1.CarBruttoPrice().ToString();
            Console.WriteLine($"Car brutto price: " + price);
            Car car2 = new Car("Audi", 40000, 20000, 0.09);
            car2.Present();
            price = car2.CarBruttoPrice().ToString();
            Console.WriteLine($"Car brutto price: " + price);
            Car car3 = new Car("Mercedes", 60000, 40000, 0.19);
            car3.Present();
            price = car3.CarBruttoPrice().ToString();
            Console.WriteLine($"Car brutto price: " + price);
        }
        public static void Run42()
        {
            Console.Write("Enter your name (write END to exit): ");
            var name = Console.ReadLine();
            while (name.ToLower() != "end")
            {
                char lastLetter = name[name.Length - 1];
                if (lastLetter == 'a')
                {
                    Console.WriteLine("Hello Mrs. " + name);
                    Console.Write("Enter your name (write END to exit): ");
                    name = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Hello Mr. " + name);
                    Console.Write("Enter your name (write END to exit): ");
                    name = Console.ReadLine();
                }
            }
            Console.WriteLine("End");
        }
    }
}
