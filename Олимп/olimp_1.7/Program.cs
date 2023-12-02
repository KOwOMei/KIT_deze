using System;

class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string newString = "";

        foreach (char c in s)
        {
            if (char.IsLower(c))
            {
                newString += "1";
            }
            else
            {
                newString += c;
            }
        }

        Console.WriteLine(newString);
        Console.ReadKey();
    }
}
