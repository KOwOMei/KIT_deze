using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;
        if (number < 2)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        if (isPrime)
        {
            Console.WriteLine("Число является простым.");
        }
        else
        {
            Console.WriteLine("Число не является простым.");
        }
        Console.ReadLine();
    }
}
