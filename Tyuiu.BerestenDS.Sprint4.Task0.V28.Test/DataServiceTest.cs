using Tyuiu.BerestenDS.Sprint4.Task0.V28.Lib;
namespace Tyuiu.BerestenDS.Sprint4.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void valid()
        {
            DataService ds = new DataService();
            int[] array = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            int a = 1;
            int res = ds.GetMultEvenArrEl(array) ;
            int wait = 9216;
            Assert.AreEqual(wait, res);
        }
    }
}