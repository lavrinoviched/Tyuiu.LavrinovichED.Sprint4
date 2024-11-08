using Newtonsoft.Json.Linq;
using Tyuiu.LavrinovichED.Sprint4.Task7.V4.Lib; 

namespace Tyuiu.LavrinovichED.Sprint4.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 3;
            int m = 4;
            int[,] matrix = new int[n, m];
            string value = "382976421897";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, value);
            int wait = 36;
            Assert.AreEqual(wait, res);
        }
    }
}