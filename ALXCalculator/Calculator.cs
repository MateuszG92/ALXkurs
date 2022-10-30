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
            Console.Write("Operation char (+ - * /): ");
            var operationCharInfo = Console.ReadKey();
            Console.Write("\nY number: ");
            var y = Double.Parse(Console.ReadLine());
            PerformOperation(operationCharInfo.KeyChar, x, y);
        }

        private void PerformOperation(char operationChar, double x, double y)
        {
            switch (operationChar)
            {
                case '+':
                    Console.WriteLine($"{x}+{y}={Add(x, y)}");
                    break;
                case '-':
                    Console.WriteLine($"{x}-{y}={Substract(x, y)}");
                    break;
                case '*':
                    Console.WriteLine($"{x}*{y}={Multiply(x, y)}");
                    break;
                case '/':
                    Console.WriteLine($"{x}/{y}={Divide(x, y)}");
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;

            }
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
