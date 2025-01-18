// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int ReverseWithLinq(int input)
{
    return int.Parse(new String(input.ToString().ToCharArray().Reverse().ToArray()));
}

int reversednumerWithLinq = ReverseWithLinq(1234323);
Console.WriteLine($"Linq Result: {reversednumerWithLinq}");



int reverseWithoutLinq(int input)
{
    int reversednumber = 0;

    while(input > 0)
    {
        int lastDigit = input % 10; // Any number dividended by ten always results in the last digit
        reversednumber = reversednumber * 10 + lastDigit;
        input /= 10;// Since these are integers this will result in the last digit falling off because it becomes a decimal point.
    }

    return reversednumber;
}

int reversednumerWithOutLinq = reverseWithoutLinq(1234323);
Console.WriteLine($"No Linq Result: {reversednumerWithOutLinq}");

int reversednumberWithoutLinq2(int input)
{
    string inputString = input.ToString();
    string reversedString = "";
    for (int i = inputString.Length -1 ; i >= 0; i--)
    {
        reversedString += inputString[i];
    }
    return int.Parse(reversedString);
}

;
int result  = reversednumberWithoutLinq2(1234323);

Console.WriteLine($"No Linq Result 2: {result}");
Console.ReadKey();