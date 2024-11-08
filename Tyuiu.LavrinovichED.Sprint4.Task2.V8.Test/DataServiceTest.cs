using Tyuiu.LavrinovichED.Sprint4.Task2.V8.Lib;

namespace Tyuiu.LavrinovichED.Sprint4.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 2, 2, 2, 5, 5, 3, 4, 2, 5, 2, 5 };

            int res = ds.Calculate(array);
            int wait = 23;

            Assert.AreEqual(res, wait);
        }
    }
}