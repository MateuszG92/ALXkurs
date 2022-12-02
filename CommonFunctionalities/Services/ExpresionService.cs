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
        public decimal ProcessExpression(string expression)
        {
            var result = CalculateExpression(expression);
            return result;
        }

        private decimal CalculateExpression(string expression)
        {
            List<decimal> numbers = new List<decimal>();
            List<char> operations = new List<char>();
            var numberBuilder = new StringBuilder();
            var expressionArray = expression.ToCharArray();
            
            if (expressionArray[0] == '-')
            {
                for (int j = 0; j < 1; j++)
                {
                    numberBuilder.Append('-');
                }
                for (int i = 1; i < expressionArray.Length; i++)
                {
                    if (Char.IsDigit(expressionArray[i]) || expressionArray[i] == ',')
                    {
                        numberBuilder.Append(expressionArray[i]);
                    }
                    else
                    {
                        var number = Convert.ToDecimal(numberBuilder.ToString());
                        numberBuilder.Clear();
                        numbers.Add(number);
                        operations.Add(expressionArray[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < expressionArray.Length; i++)
                {
                    if (Char.IsDigit(expressionArray[i]) || expressionArray[i] == ',')
                    {
                        numberBuilder.Append(expressionArray[i]);
                    }
                    else
                    {
                        var number = Convert.ToDecimal(numberBuilder.ToString());
                        numberBuilder.Clear();
                        numbers.Add(number);
                        operations.Add(expressionArray[i]);
                    }
                }
            }
            var result = PerformOperations(numbers, operations);
            numbers.Clear();
            numbers.Add(result);
            return result;
        }

        private decimal PerformOperations(List<decimal> numbers, List<char> operations)
        {
            var result = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                result = PerformOperation(operations[i - 1], result, numbers[i]);
            }

            return result;
        }

        private decimal PerformOperation(char operationChar, decimal x, decimal y)
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