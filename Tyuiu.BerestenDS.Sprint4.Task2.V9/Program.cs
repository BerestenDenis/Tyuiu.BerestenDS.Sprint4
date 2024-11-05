using Tyuiu.BerestenDS.Sprint4.Task2.V9.Lib;
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Берестень Д. С.  | ИБКСБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы.                                               *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #9                                                              *");
        Console.WriteLine("* Выполнил: Берестень Денис Сергеевич  | ИБКСБ 24-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("введите кол во элементов");
        int len = Convert.ToInt32(Console.ReadLine());
        int[] numsarray = new int[len];
        for (int i = 0; i < len; i++)
        {
            numsarray[i] = rnd.Next(1, 7);
        }
        Console.WriteLine("массив");
        for (int i = 0;i < len; i++)
        {
            Console.WriteLine(numsarray[i] + "\t");
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.Calculate(numsarray);
        Console.WriteLine("произведение четных элементов массива =" + res);
        Console.ReadKey();
    }
}