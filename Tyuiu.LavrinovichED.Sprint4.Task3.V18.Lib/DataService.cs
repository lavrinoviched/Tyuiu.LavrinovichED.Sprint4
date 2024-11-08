using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.LavrinovichED.Sprint4.Task3.V18.Lib
{
    public class DataService : ISprint4Task3V18
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1; //количество строк
            int colums = array.Length / rows; // количество столбцов

            int max = array[4, 0];

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < colums; j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }
    }
}
