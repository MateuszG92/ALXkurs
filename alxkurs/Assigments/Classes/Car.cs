using System;

namespace alxkurs.Assigments.classes
{
    public class Car
    {
        
            public string Brand;
            public string CarColor;
            public int ProductionYear;

            public void Start()
            {
                Console.WriteLine("wrum wrum");
            }

            public void Accelerate()
            {
                Console.WriteLine("speeeeeeed");
            }
            public void Present()
            {
                Console.WriteLine("This is a car");
                Console.WriteLine("It's brand " + Brand);
                Console.WriteLine("It's color is " + CarColor);
                Console.WriteLine("It was produced in " + ProductionYear);
            }
        }
    }		


