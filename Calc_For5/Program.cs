using System.Runtime.Versioning;
[SupportedOSPlatform("windows")]

class Program
{
    static void Main() 
    {
        // Задаем параметры для консоли вывода: название, цвет фона и шрифта,
        // размер окна и буфера окна;
        Console.Title = "Калькулятор (загрузка вируса - 45%)";
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        Console.SetWindowSize(40, 20);
        Console.SetBufferSize(40, 20);

        // Создаем переменные для хранения информации;
        double num1, num2;
        double mathResult;
        char mathOperator;

        // Запрашиваем ввод первого вещ-го числа;
        Console.WriteLine("Добро пожаловать в Калькулятор!");
        Console.WriteLine("Введите первое число: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        // Запрашиваем ввод второго вещ-го числа;
        Console.WriteLine("\nВведите второе число: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        // Запрашиваем ввод желаемой операции;
        Console.WriteLine("\nВыберите операцию (+, -, *, /): ");
        mathOperator = Console.ReadKey().KeyChar;


        // Условный оператор, зависит от выбора пользователя. В случае, если оператор выбран неправильно -
        // выдает параметр default с ошибкой;
        switch (mathOperator)
        {
            case '+':
                mathResult = num1 + num2;
                break;

            case '-':
                mathResult = num1 - num2;
                break;

            case '*':
                mathResult = num1 * num2;
                break;

            case '/':
                if (num2 != 0)
                {
                    mathResult = num1 / num2;
                }
                else
                {
                    Console.WriteLine("\nОшибка: деление на ноль.");
                    return;
                }
                break;
            default:
                Console.WriteLine("\nОшибка: Неверная операция.");
                return;
        }

        // Выводим результат проведенной операции;
        Console.WriteLine("\nРезультат: " + mathResult);

        // Запрашиваем нажатие любой кнопки для завершения программы;
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
