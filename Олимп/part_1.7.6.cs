using System;

class Program
{
    static void Main()
    {
        int positiveCount = 0;
        int negativeCount = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                positiveCount++;
            }
            else if (number < 0)
            {
                negativeCount++;
            }
        }

        Console.WriteLine("Количество положительных чисел: " + positiveCount);
        Console.WriteLine("Количество отрицательных чисел: " + negativeCount);
        Console.ReadLine();
    }
}
