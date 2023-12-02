using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку:");
        string input = Convert.ToString(Console.ReadLine());

        string output = input.Replace('а', 'о');
        output = output.Replace('А', 'О');

        Console.WriteLine("Ваша измененная строка: " + output);
        Console.ReadLine();
    }
}

