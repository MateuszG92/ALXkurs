using CommonFunctionalities.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctionalities.Services
{
    public class ExpressionService : IExpressionService
    {
        public double ProcessExpression(string expression)
        {
            var result = CalculateExpression(expression);
            return result;
        }

        private double CalculateExpression(string expression)
        {
            List<double> numbers = new List<double>();
            List<char> operations = new List<char>();
            var numberBuilder = new StringBuilder();
            var expressionArray = expression.ToCharArray();

            for (int i = 0; i < expressionArray.Length; i++)
            {
                if (Char.IsDigit(expressionArray[i]) || expressionArray[i] == ',')
                {
                    numberBuilder.Append(expressionArray[i]);
                }
                else
                {
                    var number = Convert.ToDouble(numberBuilder.ToString());
                    numberBuilder.Clear();
                    numbers.Add(number);
                    operations.Add(expressionArray[i]);
                }
            }
            var result = PerformOperations(numbers, operations);
            return result;
        }

        private double PerformOperations(List<double> numbers, List<char> operations)
        {
            var result = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                result = PerformOperation(operations[i - 1], result, numbers[i]);
            }

            return result;
        }

        private double PerformOperation(char operationChar, double x, double y)
        {
            switch (operationChar)
            {
                case '+':
                    return x + y;
                    break;
                case '-':
                    return x - y;
                    break;
                case '*':
                    return x * y;
                    break;
                case '/':
                    return x / y;
                    break;
                default:
                    return x;
                    break;
            }
        }
    }
}