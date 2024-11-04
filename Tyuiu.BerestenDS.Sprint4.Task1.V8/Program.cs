using Tyuiu.BerestenDS.Sprint4.Task1.V8.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int len;
        Console.WriteLine("введите кол во элементов");
        len = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[len];
        for (int i = 0; i < len; i++)
        {
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("введите массив");
        for (int i = 0;i < len; i++)
        {
            Console.WriteLine(nums[i] + "\t");
        }
        Console.WriteLine() ;
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.Calculate(nums);
        Console.WriteLine(res);
        Console.ReadKey();

    }
}