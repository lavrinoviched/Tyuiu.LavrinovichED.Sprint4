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

            int[,] matrix = new int[5, 5] { { 0, -5, 0, 3, -4 },
                                            { -1, -1, -5, 0, -5 },
                                            { 2, 4, -6, 4, -2 },
                                            { 2, 1, -3, 2, 1 },
                                            { 1, -5, 3, 0, -6 }};
            int res = ds.Calculate(matrix);
            int wail = 23;

            Assert.AreEqual(res, wail);
        }
    }
}