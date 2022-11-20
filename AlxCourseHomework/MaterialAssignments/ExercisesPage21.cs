using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialAssignments
{
    public class ExercisesPage21
    {
        public static void Run41()
        {
            var id1 = new GoodsPage21(1,3.58,5,10,2);
            id1.GetBruttoPrice();
            id1.GetWarehouseValueForEachThing();
            id1.Present();
            var id2 = new GoodsPage21(2, 9.61, 5, 25, 5);
            id2.GetBruttoPrice();
            id2.GetWarehouseValueForEachThing();
            id2.Present();
            var id3 = new GoodsPage21(3, 8.52, 8, 18, 3);
            id3.GetBruttoPrice();
            id3.GetWarehouseValueForEachThing();
            id3.Present();
            var id4 = new GoodsPage21(4, 10.25, 8, 36, 6);
            id4.GetBruttoPrice();
            id4.GetWarehouseValueForEachThing();
            id4.Present();
            var id5 = new GoodsPage21(5, 6.17, 23, 4, 1);
            id5.GetBruttoPrice();
            id5.GetWarehouseValueForEachThing();
            id5.Present();
        }
        public static void Run42()
        {
            Console.Write("Tell me a number: ");
            var UserNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Number divdies by: ");
            for (int i=1; i<=UserNumber; i++)
            {
                if(UserNumber % i == 0)
                {
                    Console.Write(i.ToString()+", ");
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
