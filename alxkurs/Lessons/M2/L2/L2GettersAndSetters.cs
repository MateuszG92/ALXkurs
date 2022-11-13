using alxkurs.Lessons.M2.L2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alxkurs.Lessons.M2.L2
{
    public class L2GettersAndSetters
    {
        public static void Run()
        {
            var computer = new Computer();
            computer.Brand = "Dell";
            computer.ProcessorFrequency = 3.2;
            computer.NumberOfCores = 3;
            PresentComputer(computer);

            var computer2 = new Computer();
            computer2.Brand = "Dell";
            computer2.ProcessorFrequency = 8;
            computer2.NumberOfCores = 12;
            PresentComputer(computer2);

        }
        private static void PresentComputer(Computer computer)
        {
            Console.WriteLine("Computer:");
            Console.WriteLine($"Brand: {computer.Brand}");
            Console.WriteLine($"Frequency: {computer.ProcessorFrequency}");
            Console.WriteLine($"Number of cores: {computer.NumberOfCores}");
        }
 
    }
}
