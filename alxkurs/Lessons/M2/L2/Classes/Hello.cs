using alxkurs.Lessons.M2.L2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace alxkurs.Lessons.M2.L2.Classes
{
    public class Hello : IHello
    {
        public void SayGoodMorning()
        {
            Console.WriteLine("Good morning");
        }

        public void SayGoodMorning(string name)
        {
            Console.WriteLine($"Good morning {name}");
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello");
        }

        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
