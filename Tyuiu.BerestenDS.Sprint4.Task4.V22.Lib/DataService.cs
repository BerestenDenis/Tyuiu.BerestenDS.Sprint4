﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BerestenDS.Sprint4.Task4.V22.Lib
{
    public class DataService : ISprint4Task4V22
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i,j] % 2 != 0)
                    {
                        matrix[i,j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}
