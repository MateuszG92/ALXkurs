using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialAssignments
{
    public class Car 
    {
        public string Brand;
        public double NettoPrice;
        public double InventoryNettoPrice;
        public double Tax;
        public double Price;
        public Car()
        {

        }
        public Car(string brand, double nettoPrice, double inventoryPrice, double tax)
        {
            Brand = brand;
            NettoPrice = nettoPrice;
            InventoryNettoPrice = inventoryPrice;
            Tax = tax;
        }
        public double CarBruttoPrice()
        {
            return (NettoPrice+InventoryNettoPrice)*(1+Tax);
        }
        public void Present()
        {
            Console.WriteLine("Car info");
            Console.WriteLine($"Car brand: {Brand}");
            Console.WriteLine($"Car netto price: {NettoPrice}");
            Console.WriteLine($"Car inventory price: {InventoryNettoPrice}");
            Console.WriteLine("Tax:" + (NettoPrice+InventoryNettoPrice)*Tax);
        }
    }
}
