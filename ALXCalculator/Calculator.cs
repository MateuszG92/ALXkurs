using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCalculator
{
    public class Calculator
    {
        public void Run()
        {
            Console.WriteLine("Running calculator");
            Console.Write("X number: ");
            var x = Double.Parse(Console.ReadLine());
            Console.Write("Y number: ");
            var y = Double.Parse(Console.ReadLine());
            Console.WriteLine($"{x}+{y}={Add(x,y)}");
            Console.WriteLine($"{x}*{y}={Multiply(x,y)}");
            Console.WriteLine($"{x}/{y}={Divide(x,y)}");
            Console.WriteLine($"{x}-{y}={Substract(x,y)}");
        }
        private double Add(double x, double y)
        {
            return x+ y;
        }
        private double Multiply(double x, double y)
        {
            return x * y;
        }
        private double Divide(double x, double y)
        {
            return x / y;
        }
        private double Substract(double x, double y)
        {
            return x - y;
        }
    }
}
