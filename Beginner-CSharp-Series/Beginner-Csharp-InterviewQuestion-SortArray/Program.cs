// See https://aka.ms/new-console-template for more information
// https://code-maze.com/insertion-sort-csharp/
// https://code-maze.com/sorting-algorithms-csharp/
Console.WriteLine("Hello, World!");

decimal[] SortCollection(decimal[] collection)
{
    for(int index = 1; index < collection.Length; index++)
    {
        var key = collection[index];
        var flag = 0;
        for(int innerIndex = index -1; innerIndex >= 0 && flag !=1;)
        {
            if(key < collection[innerIndex])
            {
                collection[innerIndex + 1] = collection[innerIndex];
                innerIndex--;
                collection[innerIndex + 1] = key;
            }
            else
            {
                flag = 1;
            }
        }
    }
    return collection;
}
var someInputList = new decimal[] { 9.10m, 2, 3, 7.5m, 5, 6 };
foreach (var item in SortCollection(someInputList))
{
    Console.Write(item);
}
Console.ReadKey();