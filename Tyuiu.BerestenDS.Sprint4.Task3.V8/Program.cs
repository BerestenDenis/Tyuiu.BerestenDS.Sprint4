using Tyuiu.BerestenDS.Sprint4.Task3.V8.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Берестень Д. С.  | ИБКСБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы.                                                *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнил: Берестень Денис Сергеевич  | ИБКСБ 24-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int[,] array = new int[5, 5] { {4, 8, 3, 4, 8},
                                          {5, 3, 5, 7, 8 },
                                          {3, 7, 2, 7, 7 },
                                          {5, 2, 4, 6, 4 },
                                          {4, 4, 6, 7, 2 } };
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.Calculate(array);
        Console.WriteLine("Минимальное число в 4 столбце это = " + res);
        Console.ReadKey();
    }
}
