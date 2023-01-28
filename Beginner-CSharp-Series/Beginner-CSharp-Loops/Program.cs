// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//While loops

string pizzaName = "Pep Pizza";
int cookTime = 6;
int cookTimeCounter = 0;
while (cookTimeCounter < cookTime)
{
    cookTimeCounter++;
    Console.WriteLine($"Cook Time Current at: {cookTimeCounter}");
}
Console.WriteLine($"{pizzaName} Done");
//Console.ReadKey();

List<string> names = new List<string>() { "Richard", "Kellie", "Peter" };

for (int index = 0; index < names.Count;index++)
{
    Console.WriteLine(names[index]);
}

for (int index = 0; index < 2; index++)
{
    Console.WriteLine(names[index]);
}

// This will blow up because there is no 3rd item so there is no third index
//for (int index = 0; index < 4; index++)
//{
//    Console.WriteLine(names[index]);
//}

foreach (string name in names)
{
    Console.WriteLine(name);
}

Dictionary<string, decimal> Products = new Dictionary<string, decimal>()
{
    {"HNR",5.00m },
    {"Cheese",5.00m },
    {"Pepsi",2.00m}
};
//Dictionary can't be accessed by index
//for (int index = 0; index < Products.Count; index++)
//{
//    Console.WriteLine(Products[index]);
//}

foreach (var product in Products)
{
    Console.WriteLine(product.Key);
}
Console.ReadKey();