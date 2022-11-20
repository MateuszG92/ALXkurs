using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialAssignments
{
    public class GoodsPage21
    {
        int Id;
        double Price;
        double Vat;
        int ThingsInOneBox;
        int NumberOfBoxes;

        public GoodsPage21(int id,double price, double vat, int thingsInOneBox, int numberOfBoxes)
        {
            Id=id;
            Price = price;
            Vat=vat;
            ThingsInOneBox=thingsInOneBox;
            NumberOfBoxes=numberOfBoxes;
        }
        public GoodsPage21()
        {

        }
        public double GetBruttoPrice()
        {
            return Price*(1+(Vat/100));
            Console.WriteLine("Brutto price " + GetBruttoPrice().ToString());
        }
        public double GetWarehouseValueForEachThing()
        {
            return Price * ThingsInOneBox * NumberOfBoxes;
            Console.WriteLine("Warhause good value" + GetWarehouseValueForEachThing().ToString());
        }
        public void Present()
        {
            Console.WriteLine($"Id number: {Id}");
            Console.WriteLine($"Netto Price: {Price}");
            Console.WriteLine($"Vat: {Vat}");
            Console.WriteLine("Brutto Price: " + GetBruttoPrice().ToString());
            Console.WriteLine($"Price for Box: {Price*ThingsInOneBox}");
            Console.WriteLine("_____________________");
        }
    }
}
