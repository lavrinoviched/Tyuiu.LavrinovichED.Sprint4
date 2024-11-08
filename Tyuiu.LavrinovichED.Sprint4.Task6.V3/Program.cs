using Tyuiu.LavrinovichED.Sprint4.Task6.V3.Lib;

namespace Tyuiu.LavrinovichED.Sprint4.Task6.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                        *");
            Console.WriteLine("* Тема: Класс Array                                                                                *");
            Console.WriteLine("* Задание #6                                                                                       *");
            Console.WriteLine("* Вариант #3                                                                                       *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                                       *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дан строковый массив данных, используя класс Array подсчитайте количество элементов, длина       *");
            Console.WriteLine("* которых меньше 6                                                                                 *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            var array = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь",
            "Октябрь", "Ноябрь", "Декабрь" };

            Console.WriteLine(" Исходный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine(" Количество элементов, длина которых < 6: ");

            int nums = ds.Calculate(array);
            Console.WriteLine(nums);

            Console.ReadKey();
        }
    }
}
