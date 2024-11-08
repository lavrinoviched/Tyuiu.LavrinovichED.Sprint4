using Tyuiu.LavrinovichED.Sprint4.Task5.V15.Lib;

namespace Tyuiu.LavrinovichED.Sprint4.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] { { 4, 2, 5, 5, 3 },
                                            { 4, 2, 5, 2, 2 },
                                            { 3, 2, 4, 2, 4 },
                                            { 3, 6, 4, 5, 4 },
                                            { 2, 4, 6, 4, 2 }};
            int res = ds.Calculate(matrix);
            int wail = 60;

            Assert.AreEqual(res, wail);
        }
    }
}