// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool IsPalinedromeWithLinq(string input)
{
    string reversedString = new String(input.ToCharArray().Reverse().ToArray());
    return input.Equals(reversedString,StringComparison.CurrentCultureIgnoreCase);
}

Console.WriteLine(IsPalinedromeWithLinq("Ten"));
Console.WriteLine(IsPalinedromeWithLinq("Mom"));

bool IsPalinedromeWithoutLinq(string input)
{
    string reversedString = string.Empty;
    for(int characterIndex = input.Length - 1; characterIndex>=0; characterIndex--)
    {
        reversedString += input[characterIndex];
    }

    //return input.Equals(reversedString, StringComparison.CurrentCultureIgnoreCase);
    return input == reversedString;
}
Console.WriteLine(IsPalinedromeWithoutLinq("Ten"));
Console.WriteLine(IsPalinedromeWithoutLinq("mom"));

Console.ReadKey();