using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер пирамиды: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
