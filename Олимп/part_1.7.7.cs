using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }

        if (sum == number)
        {
            Console.WriteLine("Число является идеальным.");
        }
        else
        {
            Console.WriteLine("Число не является идеальным.");
        }
        Console.ReadLine();
    }
}
