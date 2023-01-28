// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Dictionary<string, decimal> Products = new Dictionary<string, decimal>()
{
    {"HNR",5.00m },
    {"Cheese",5.00m },
    {"Pepsi",2.00m},
    {"3 Meat",8.00m },
    {"Cheese Bread",3.00m },
    {"Salad",5.00m },
};


//if (Products.ContainsKey("HNR"))
//{
//    decimal productPrice = Products["HNR"];
//    decimal reduction = productPrice / 2 * 0.03m;
//    productPrice = productPrice - reduction;
//    Console.WriteLine($"HNR Price: {productPrice}");
//}
//if (Products.ContainsKey("Cheese"))
//{
//    decimal productPrice = Products["Cheese"];
//    decimal reduction = productPrice / 2 * 0.03m;
//    productPrice = productPrice - reduction;
//    Console.WriteLine($"Cheese Price: {productPrice}");
//}
//if (Products.ContainsKey("3 Meat"))
//{
//    decimal productPrice = Products["3 Meat"];
//    decimal reduction = productPrice / 2 * 0.03m;
//    productPrice = productPrice - reduction;
//    Console.WriteLine($"3 Meat Price: {productPrice}");
//}

if(Products.ContainsKey("HNR"))
{
    decimal productPrice = Products["HNR"];
    decimal reducedPrice = GetDiscount(productPrice);
    Console.WriteLine($"HNR Price: {reducedPrice}");
}
if (Products.ContainsKey("Cheese"))
{
    decimal productPrice = Products["Cheese"];
    decimal reducedPrice = GetDiscount(productPrice);
    Console.WriteLine($"Cheese Price: {reducedPrice}");
}
if (Products.ContainsKey("3 Meat"))
{
    decimal productPrice = Products["3 Meat"];
    decimal reducedPrice = GetDiscount(productPrice);
    Console.WriteLine($"3 Meat Price: {reducedPrice}");
}
decimal GetDiscount(decimal originalPrice)
{
    decimal reduction = originalPrice / 2 * 0.03m;
    return originalPrice - reduction;
}
Console.ReadKey();