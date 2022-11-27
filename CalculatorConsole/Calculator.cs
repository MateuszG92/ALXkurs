using CommonFunctionalities.Services;
using CommonFunctionalities.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    public class Calculator
    {
        private IExpressionService Service;
        public Calculator()
        {
            Service = new ExpressionService();
        }
        public void Run()
        {
            Console.WriteLine("Enter expresion");
            var expression = Console.ReadLine();
            expression = RefactorExpresion(expression);
            var result=Service.ProcessExpression(expression);
            Console.WriteLine($"Result: {result}");
        }

        private string RefactorExpresion(string expression)
        {
            expression = expression.Trim();
            expression = expression.Replace(" ", "");
            if (!expression.EndsWith("="))
            {
                expression += "=";
            }
            return expression;
        }
    }
}
