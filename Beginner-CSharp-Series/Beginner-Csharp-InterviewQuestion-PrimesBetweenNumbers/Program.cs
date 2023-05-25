// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// https://www.w3resource.com/csharp-exercises/for-loop/csharp-for-loop-exercise-34.php
// https://www.geeksforgeeks.org/program-to-find-prime-numbers-between-given-interval/
// Big o complexity should be O(N ^ 2)
// https://www.bigocheatsheet.com
// https://www.enjoyalgorithms.com/blog/time-complexity-analysis-of-loop-in-programming
IEnumerable<int> PrimesBetween(int beginning, int ending)
{
    var primes = new List<int>();
    
    for(int target = beginning; target <= ending;target++)
    {
        if(target <= 1)
        {
            continue;
        }
        bool isPrime = true;
        for (int index = 2; index <= target / 2; index++)
        {
            if(target % index == 0) // Since a prime number is any number only dividisble by 1 and itself. It should not have an even remainder
            {
                isPrime = false;
                break;
            }
            
        }
        if (isPrime)
        {
            primes.Add(target);
        }
    }
    return primes;
}



foreach (var i in PrimesBetween(1, 20))
{
    Console.WriteLine(i);
}

Console.ReadKey();