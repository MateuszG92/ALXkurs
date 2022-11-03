using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialAssignments
{
    public class ExercisesPage19
    {
        public static void Run31()
        {
            Console.Write("Enter a purchase sum: ");
            var purchaseSum = Int32.Parse(Console.ReadLine());
            CheckPurchaseRabat(purchaseSum);
        }
        private static void CheckPurchaseRabat(double purchaseSum, double up = 100, double down = 60)
        {
            double discountBig = 15;
            double discountMiddle = 5;

            if (purchaseSum <= down)
            {
                Console.WriteLine($"Purchase sum - {purchaseSum} \nDiscount - 0%\nAmount after doscount {purchaseSum}.");
            }
            else if (purchaseSum > up)
            {
                Console.WriteLine($"Purchase sum - {purchaseSum} \nDiscount - {discountBig}%\nAmount after doscount {purchaseSum *(( 100-discountBig)/100) }.");
            }
            else
            {
                Console.WriteLine($"Purchase sum - {purchaseSum} \nDiscount - {discountMiddle}%\nAmount after doscount {purchaseSum *((100- discountMiddle)/100) }.");
            }
        }
        public static void Run32()
        {
            Console.Write("Enter a purchase sum: ");
            var purchaseSum = Int32.Parse(Console.ReadLine());
            double discountBig = 15;
            double discountMiddle = 5;
            const int up = 100;
            const int down = 60;
            switch (purchaseSum)
            {
                case > up:
                    Console.WriteLine($"Purchase sum - {purchaseSum} \nDiscount - {discountBig}%\nAmount after doscount {purchaseSum * ((100 - discountBig) / 100)}.");
                    break;
                case <=down:               
                    Console.WriteLine($"Purchase sum - {purchaseSum} \nDiscount - 0%\nAmount after doscount {purchaseSum}.");
                    break;
                default:
                    Console.WriteLine($"Purchase sum - {purchaseSum} \nDiscount - {discountMiddle}%\nAmount after doscount {purchaseSum * ((100 - discountMiddle) / 100)}.");
                    break;
            }
        }
    }
}
