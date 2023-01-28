// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> names = new List<string>() { "Richard", "Kellie", "Peter" };

string rich = names[0];
string kellie = names[1];

//Console.WriteLine($"Names: {rich},{kellie}");
//Console.ReadKey();
Dictionary<string, decimal> Products = new Dictionary<string, decimal>()
{
    {"HNR",5.00m },
    {"Cheese",5.00m },
    {"Pepsi",2.00m}
};

decimal hnrPrice = Products["HNR"];
Console.WriteLine($"Items: {hnrPrice}");
Console.ReadKey();