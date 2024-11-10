using Tyuiu.BerestenDS.Sprint4.Task7.V20.Lib;
namespace Tyuiu.BerestenDS.Sprint4.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            int n = 5;
            int m = 3;
            string str = "357951248632587";
            int res = ds.Calculate(n, m, str);
            int wait = 496125;
            Assert.AreEqual(wait, res);
        }
    }
}