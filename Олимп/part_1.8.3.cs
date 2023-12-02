using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку:");
        string input = Console.ReadLine();

        int wordCount = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;

        Console.WriteLine("Количество слов: " + wordCount);
        Console.ReadLine();
    }
}