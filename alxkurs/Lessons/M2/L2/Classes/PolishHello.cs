using alxkurs.Lessons.M2.L2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alxkurs.Lessons.M2.L2.Classes
{
    public class PolishHello : IHello
    {
        public void SayGoodMorning()
        {
            Console.WriteLine("Dzień dobry");
        }

        public void SayGoodMorning(string name)
        {
            Console.WriteLine($"Dzień dobry {name}");
        }

        public void SayHello()
        {
            Console.WriteLine($"Cześć");
        }

        public void SayHello(string name)
        {
            Console.WriteLine($"Cześć {name}");
        }
    }
}
