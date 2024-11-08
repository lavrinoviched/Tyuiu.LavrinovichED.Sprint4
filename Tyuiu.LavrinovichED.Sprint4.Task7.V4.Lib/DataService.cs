using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.LavrinovichED.Sprint4.Task7.V4.Lib
{
    public class DataService : ISprint4Task7V4
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];

            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }

            int count = 0;

            for(int i = 0;i < n; i++)
            {
                for(int j = 0;j < m; j++)
                {
                    if (matrix[i,j] % 2 !=0)
                    {
                        count += matrix[i,j];
                    }
                }
            }
            
            return count;
        }
    }
}
