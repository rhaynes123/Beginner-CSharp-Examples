// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

decimal askingPrice = 1_000_000m;

if (askingPrice < 1_000_000m)
{
    Console.WriteLine("I can buy this");
}
else if (askingPrice == 1_000_000m)
{
    Console.WriteLine("I need to think about it");
}
else
{
    Console.WriteLine("Costs too much");
}
Console.ReadKey();