using Tyuiu.BerestenDS.Sprint4.Task4.V22.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Берестень Д. С.  | ИБКСБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #22                                                             *");
        Console.WriteLine("* Выполнил: Берестень Денис Сергеевич  | ИБКСБ 24-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int rows = 5;
        int columns = 5;
        int[,] mtrx = new int[rows, columns];

        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine($"Введите {i},{j} элементы массива значениями от 2 до 6:");
                mtrx[i, j] = Convert.ToInt32(Console.ReadLine());

            }
        }
        Console.WriteLine("\nМассив:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine($"{mtrx[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        mtrx = ds.Calculate(mtrx);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine(mtrx[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}