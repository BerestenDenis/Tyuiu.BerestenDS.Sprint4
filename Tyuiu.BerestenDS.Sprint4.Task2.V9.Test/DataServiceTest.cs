using Tyuiu.BerestenDS.Sprint4.Task2.V9.Lib;
namespace Tyuiu.BerestenDS.Sprint4.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            int[] array = { 1, 3, 5, 7 };
            int res = ds.Calculate(array);
            int wait = 1;
            Assert.AreEqual(res, wait);
        }
    }
}