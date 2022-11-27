using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp.Exceptions
{
    public class OurOwnException:Exception
    {
        public OurOwnException()
        {

        }
        public OurOwnException(string? message) : base(message)
        {

        }
        public OurOwnException(string? message, Exception? exception):base(message, exception)
        {

        }
    }
}
