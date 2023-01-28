// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Dictionary<string, decimal> Products = new Dictionary<string, decimal>()
//{
//    {"HNR",5.00m },
//    {"Cheese",5.00m },
//    {"Pepsi",2.00m}
//};

//decimal hnrPrice = Products["HNR"];
//Console.WriteLine($"Items: {hnrPrice}");
//Console.ReadKey();



var hnr = new Product
{
    Name = "HNR",
    Price = 5.00m,
    HasToppings = true,
    IsCooked = true
};

Dictionary<string, Product> products = new Dictionary<string, Product>()
{
    {"HNR",hnr },
};

decimal hnrProductPrice = products["HNR"].Price;
decimal discountedHnrProductPrice = products["HNR"].GetDiscount();
Console.WriteLine($"Items: {hnrProductPrice}");
Console.WriteLine($"Discounted Items: {discountedHnrProductPrice}");
Console.ReadKey();

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool HasToppings { get; set; }
    public bool IsCooked { get; set; }

    public decimal GetDiscount()
    {
        decimal reduction = Price / 2 * 0.03m;
        return Price - reduction;
    }
}