using Tyuiu.BerestenDS.Sprint4.Task5.V16.Lib;
namespace Tyuiu.BerestenDS.Sprint4.Task5.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[3, 3] { { 3, 2, 1 }, { -5, -1, 0 }, { 1, -2, -6 } };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = new int[3, 3] { { 1, 1, 1 }, { -5, -1, 0 }, { 1, -2, -6 } };
            CollectionAssert.AreEqual(wait, res);

        }
    }
}