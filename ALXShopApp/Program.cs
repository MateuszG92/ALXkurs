using ALXShopApp.Models;


var products = new List<Product>();
var shoppingCart=new ShoppingCart();
Product milk = new Product() {ProductName="MILK", Price=50M };
Product eggs = new Product() {ProductName="EGGS", Price=20M };
Product bread = new Product() {ProductName="BREAD", Price=100M };
products.Add(milk);
products.Add(eggs);
products.Add(bread);
Product product;

Console.WriteLine("Hello in our shop");
Console.WriteLine("Products list whith prices");
ShowList(products);
Console.WriteLine("Want to add new product to cart? (Y/N)");
var wantToAddProductToCart = Console.ReadLine().ToUpper();
while (wantToAddProductToCart == "Y")
{
    Console.Write("Enter product name: ");
    var chosenProductName = Console.ReadLine().ToUpper();
    var validProduct=products.Any(x=>x.ProductName == chosenProductName);
    if (validProduct)
    {
        var productToCart = new Product();
        productToCart.ProductName = chosenProductName;
        shoppingCart.Products.Add(productToCart);
        Console.WriteLine("Write Y to add next producty or N to show shoping cart ");
        wantToAddProductToCart = Console.ReadLine().ToUpper();
    }
    else
    {
        Console.WriteLine("No such product in our store.");
    }

    if (wantToAddProductToCart == "N")
    {
        ShowList(shoppingCart.Products);
        shoppingCart.GetPrice();
    }
}

void ShowList(List<Product> list)
{
    foreach (Product item in list)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine();
}