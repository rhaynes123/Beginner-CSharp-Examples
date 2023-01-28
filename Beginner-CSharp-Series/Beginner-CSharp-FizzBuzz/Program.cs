// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// loop over the numbers between 1 to 100
// If a number is divisible by 5 or 3 print FizzBuzz instead of the number
// If the number is only divisible by 5 print Buzz
// If the number is only divisible by 3 print Fizz

//for(int number = 1; number <=100; number++)
//{
//    if (number % 3 == 0 && number % 5 == 0)
//    {
//        Console.WriteLine("FizzBuzz");
//    }
//    else if (number % 5 == 0)
//    {
//        Console.WriteLine("Buzz");
//    }
//    else if (number % 3 == 0)
//    {
//        Console.WriteLine("Fizz");
//    }
//    else
//    {
//        Console.WriteLine(number);
//    }
//}
//Console.ReadKey();

var game = new Game();
game.Play("FizzBuzz");

public class Game
{
    public void Play(string name)
    {
        if (name == "FizzBuzz")
        {
            FizzBuzz();
        }
    }
    private void FizzBuzz()
    {
        for (int number = 1; number <= 100; number++)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
        Console.ReadKey();
    }
}


