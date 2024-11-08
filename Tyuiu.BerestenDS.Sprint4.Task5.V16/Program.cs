using Tyuiu.BerestenDS.Sprint4.Task5.V16.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rand = new Random();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите кол-во строк в массиве");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите кол во столбцов в массиве");
        int cols = Convert.ToInt32(Console.ReadLine());
        int[,]mtrx = new int[rows, cols];
        Console.WriteLine("***************************************************************************");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                mtrx[i, j] = rand.Next(-6, 3);
            }
        }
        Console.WriteLine("\nМассив");
        for(int i = 0;i < rows; i++)
        {
            for(int j = 0;j < cols; j++)
            {
                Console.WriteLine($"{mtrx[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        mtrx = ds.Calculate(mtrx);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine(mtrx[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}