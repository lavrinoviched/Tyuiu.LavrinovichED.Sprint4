using Tyuiu.LavrinovichED.Sprint4.Task7.V4.Lib;

namespace Tyuiu.LavrinovichED.Sprint4.Task7.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int m = 4;
            int[,] matrix = new int[n, m];
            string value = "382976421897";

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                        *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                          *");
            Console.WriteLine("* Задание #7                                                                                       *");
            Console.WriteLine("* Вариант #4                                                                                       *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                                       *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 382976421897. Преобразуйте ее в матрицу 3 на 4 и подсчитайте   *");
            Console.WriteLine("* сумму нечетных чисел                                                                             *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            int index = 0;

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{value[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            int res = ds.Calculate(n, m, value);

            Console.WriteLine(" Сумма нечетных чисел = " + res);

            Console.ReadKey();

        }
    }
}
