using System;

namespace Obshie_progi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать!");
            Console.WriteLine("Введите первое число: ");
            integer Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            integer Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Num1 + Num2);
        }
    }
}