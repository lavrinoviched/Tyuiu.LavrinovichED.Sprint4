using Tyuiu.LavrinovichED.Sprint4.Task3.V18.Lib; 

namespace Tyuiu.LavrinovichED.Sprint4.Task3.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] { { 2, 4, 2, 7, 7 },
                                           { 4, 7, 9, 9, 7 },
                                           { 8, 5, 5, 6, 5 },
                                           { 7, 7, 5, 2, 9 },
                                           { 9, 3, 7, 9, 8 }};

            int rows = array.GetUpperBound(0) + 1; //количество строк
            int colums = array.Length / rows; // количество столбцов

            Console.Title = "Спринт #4 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                        *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                                                       *");
            Console.WriteLine("* Задание #3                                                                                       *");
            Console.WriteLine("* Вариант #18                                                                                      *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                                       *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими значениями в       *");
            Console.WriteLine("* диапазоне от 2 до 9. Найдите максимальный элемент в последней строке массива                     *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            Console.WriteLine("Массив: ");
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < colums; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine("Максимальный элемент в последней строчке массива: " + res);
            Console.ReadKey(); 

        }
    }
}
