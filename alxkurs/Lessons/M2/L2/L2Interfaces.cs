using alxkurs.Lessons.M2.L2.Classes;
using alxkurs.Lessons.M2.L2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alxkurs.Lessons.M2.L2
{
    public class L2Interfaces
    {
        public static void Run()
        {
            IHello helloService = new PolishHello();
            helloService.SayGoodMorning();
            helloService.SayGoodMorning("Mateusz");
            helloService.SayHello();
            helloService.SayHello("Mateusz");

            helloService = new Hello();
            helloService.SayGoodMorning();
            helloService.SayGoodMorning("Mateusz");
            helloService.SayHello();
            helloService.SayHello("Mateusz");
        }
    }
}
