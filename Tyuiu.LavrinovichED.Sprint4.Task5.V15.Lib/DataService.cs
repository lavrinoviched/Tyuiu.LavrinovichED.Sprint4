﻿using tyuiu.cources.programming.interfaces.Sprint4; 

namespace Tyuiu.LavrinovichED.Sprint4.Task5.V15.Lib
{
    public class DataService : ISprint4Task5V15
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1; //количество строк
            int colums = matrix.Length / rows; // количество столбцов

            int c = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        c += matrix[i, j];
                    }
                }
            }
            return c;
        }
    }
}
