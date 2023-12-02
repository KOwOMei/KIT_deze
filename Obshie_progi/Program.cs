using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obshie_progi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать!");
            Console.WriteLine("Введите ваше имя: ");
            string Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Привет, " + Name);
            Console.ReadLine();
        }
    }
}
