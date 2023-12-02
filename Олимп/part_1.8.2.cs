using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Convert.ToString(Console.ReadLine());

        char[] characters = input.ToCharArray();
        Array.Reverse(characters);
        
        string reversed = new string(characters);
        Console.WriteLine("Это ваша строка наоборот: " + reversed);
        Console.ReadLine();
    }
}
