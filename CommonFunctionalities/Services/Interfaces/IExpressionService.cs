using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctionalities.Services.Interface
{
    public interface IExpressionService
    {
        decimal ProcessExpression(string expression);
    }
}
