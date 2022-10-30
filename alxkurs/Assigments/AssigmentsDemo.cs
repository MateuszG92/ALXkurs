using System;
using alxkurs.Assigments.classes;

namespace alxkurs.Assigments
{


    public class AssigmentsDemo
    {
            public static void Run()
            {

                var cat1 = new Cat("Mruczek", "black", 6);
                cat1.Present();
                cat1.Jump();
                cat1.Meow();
                var cat2 = new Cat("red", 4);
                cat2.Present();
                cat2.Jump();
                cat2.Meow();
                Car car = new Car();
                car.Brand = "BMW";
                car.CarColor = "Black";
                car.ProductionYear = 2013;
                car.Start();
                car.Accelerate();
                car.Present();
            }       
    }
}