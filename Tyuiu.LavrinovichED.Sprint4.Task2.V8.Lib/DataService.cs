﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.LavrinovichED.Sprint4.Task2.V8.Lib
{
    public class DataService : ISprint4Task2V8
    {
        public int Calculate(int[] array)
        {
            int с = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    с += array[i];
                }
            }
            return с;
        }
    }
}
