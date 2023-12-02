using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку на анализ: ");
        string input_str = Console.ReadLine();

        char[] chars = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
        int count = 0;

        foreach (char c in input_str)
        {
            if (Array.IndexOf(chars, char.ToLower(c)) != -1)
            {
                count++;
            }
        }

        Console.WriteLine("Количество гласных букв: " + count);
        Console.ReadLine();
    }
}
