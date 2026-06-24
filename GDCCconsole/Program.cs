using System;

namespace GDCCconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор стоимости разработки игры");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();

            try
            {
                // 1. Ввод данных (UI)
                Console.Write("Введите количество программистов: ");
                int programmers = int.Parse(Console.ReadLine());

                Console.Write("Введите количество художников: ");
                int artists = int.Parse(Console.ReadLine());

                Console.Write("Введите количество месяцев: ");
                int months = int.Parse(Console.ReadLine());

                // 2. Создаем экземпляр класса с логикой
                Calculator calc = new Calculator();

                // 3. Передаем данные в метод и получаем результат (return)
                decimal total = calc.CalculateTotalCost(programmers, artists, months);

                // 4. Вывод результата (UI)
                Console.WriteLine();
                Console.WriteLine($"Общая стоимость: {total:C2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите корректные числа (только цифры)!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
