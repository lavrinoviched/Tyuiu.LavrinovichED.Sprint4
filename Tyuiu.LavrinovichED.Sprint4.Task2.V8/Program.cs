using Tyuiu.LavrinovichED.Sprint4.Task2.V8.Lib;

namespace Tyuiu.LavrinovichED.Sprint4.Task2.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); 
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                        *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                                             *");
            Console.WriteLine("* Задание #2                                                                                       *");
            Console.WriteLine("* Вариант #8                                                                                       *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                                       *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов, заполненный случайными значениями в         *");
            Console.WriteLine("* диапазоне от 2 до 7 подсчитать сумму нечетных элементов массива                                  *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            Console.WriteLine("Введите количество элементов массива:");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numsArry = new int[len];
            for (int i = 0; i <= len - 1; i++)
            {
                numsArry[i] = rnd.Next(2, 7);
            }
            Console.WriteLine("Массив: ");
            for (int i = 0;i <= len - 1;i++)
            {
                Console.Write(numsArry[i] + "\t");

            }
            Console.WriteLine();

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            int res = ds.Calculate(numsArry);

            Console.WriteLine(" Сумма нечетных элементов массива равна: " + res);
            Console.ReadKey();

        }
    }
}
