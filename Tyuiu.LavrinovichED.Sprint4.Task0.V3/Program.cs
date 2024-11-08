using Tyuiu.LavrinovichED.Sprint4.Task0.V3.Lib;

namespace Tyuiu.LavrinovichED.Sprint4.Task0.V3
{
    internal class Program
    {
        static void Main(string[] args, int[] array)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                        *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                                                      *");
            Console.WriteLine("* Задание #0                                                                                       *");
            Console.WriteLine("* Вариант #3                                                                                       *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                                       *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный статическими значениями в       *");
            Console.WriteLine("* диапазоне от 0 до 9 подсчитать произведение нечетных элементов массива                           *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            int[] array = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("Исходный масив");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine(" Произведение нечетных элементов массива");

            array = ds.GetMultOddArrEl(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + "\t");
            }
            Console.WriteLine();
            Console.ReadKey(); 
        }
    }
}
