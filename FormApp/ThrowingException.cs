using FormApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp
{
    public class ThrowingException
    {
        public void Run()
        {
            MessageBox.Show("Throwing exception");
            throw new OurOwnException("Dont click it");
        }
    }
}
