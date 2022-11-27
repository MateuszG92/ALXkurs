using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ALXShopApp.Models
{
    public class ShoppingCart
    {
        public List<Product> Products { get; set; }

        public ShoppingCart()
        {
            Products = new List<Product>();
        }

        public decimal GetPrice()
        {
            return Products.Sum(x => x.Price);
        }
        public void ClearCart()
        {
            Products.Clear();
        }
    }
}
