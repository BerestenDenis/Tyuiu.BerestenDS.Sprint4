using System.CodeDom.Compiler;
using Tyuiu.BerestenDS.Sprint4.Task1.V8.Lib;
namespace Tyuiu.BerestenDS.Sprint4.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void valid()
        {
            DataService ds = new DataService();
            int[] array = { 8, 4, 7, 7, 3, 8, 8, 5, 8, 7, 2, 4 };
            int res = ds.Calculate(array);
            int wait = 29;
            Assert.AreEqual(wait, res);
        }
    }
}