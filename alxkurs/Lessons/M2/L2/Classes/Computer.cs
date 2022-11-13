using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alxkurs.Lessons.M2.L2.Classes
{
    public class Computer
    {
        public string Brand;
        public int NumberOfCores;
        private double? _processorFrequency;
        public double? ProcessorFrequency
        {
            get
            {
                Console.WriteLine("Getting frequency.");
                return _processorFrequency;
            }
            set
            { 
                if(value > 0 && value < 4)
                {
                    Console.WriteLine($"Setting computer frequency as {value} [GHz].");
                    _processorFrequency = value;
                }
                else
                {
                    Console.WriteLine("Invalid procesor frequency!");
                }              
            }
        }
    }
}
