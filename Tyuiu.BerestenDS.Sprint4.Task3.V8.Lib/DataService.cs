using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BerestenDS.Sprint4.Task3.V8.Lib
{
    public class DataService : ISprint4Task3V8
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int cols = array.Length / rows;
            int count = array[0,3];
            for (int i = 0; i < rows; i++)
            {
                if (array[i,3] < count)
                {
                    count = array[i,3];
                }

            }
            return count;
        }
    }
}
