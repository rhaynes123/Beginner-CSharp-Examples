// See https://aka.ms/new-console-template for more information
//https://code-maze.com/csharp-randomize-list/
Console.WriteLine("Hello, World!");

List<int> ShuffleWithLinq(List<int> inputList)
{
    Random rnd = new Random();
    return inputList.OrderBy(input => rnd.Next()).ToList();
}
// Based of the Fisher Yates Algorithim
// O(N) complexity
List<int> ShuffleWithoutLinq(List<int> inputList)
{
    Random random = new();

    for(int lastInputIndex = inputList.Count -1; lastInputIndex > 0; lastInputIndex--)
    {
        // step 1 get random value. The plus 1 the value Next is an upper bound so the results are always less than that value
        int randomIndex = random.Next(lastInputIndex + 1); 
        // step 2 get value from random index
        int randomValue = inputList[randomIndex];
        // step 3 set the random index to what is the current last value
        inputList[randomIndex] = inputList[lastInputIndex];
        // step 4 now create some chaos and set the current last index to the random value resulting ever more changing.
        inputList[lastInputIndex] = randomValue;
    }

    return inputList;
}

var someInputList = new List<int> { 1, 2, 3, 4, 5, 6 };

var shuffledwithLinq = ShuffleWithLinq(someInputList);

var shuffledWithoutLinq = ShuffleWithoutLinq(someInputList);


Console.WriteLine("Shuffled without Linq");
foreach (var item in shuffledwithLinq)
{
    Console.Write(item);
}
Console.WriteLine("\n");
Console.WriteLine("Shuffled without Linq");
foreach (var item in shuffledWithoutLinq)
{
    Console.Write(item);
}
Console.ReadKey();