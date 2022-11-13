using alxkurs.Assigments.M1;
using alxkurs.Lessons.M2.L2.Classes;
using CommonFunctionalities.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace alxkurs.Lessons.M2.L2
{
    public class L2Encapsulation
    {
        public static void Run()
        {
            var taxService = new TaxService();
            var income = 5000;
            var tax=taxService.CalculateTax(income);
            Present(tax, income);
        }
        private static void Present (double tax, double income)
        {
            Console.WriteLine($"Income: {income}");
            Console.WriteLine($"Tax: {tax}");
            Console.WriteLine($"Netto: {income-tax}");
        }
    }
}
