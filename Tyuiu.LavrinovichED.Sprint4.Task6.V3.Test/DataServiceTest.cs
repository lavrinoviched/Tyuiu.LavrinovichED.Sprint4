using Tyuiu.LavrinovichED.Sprint4.Task6.V3.Lib; 

namespace Tyuiu.LavrinovichED.Sprint4.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService(); 

            var array = new string[] { "������", "�������", "����", "������", "���", "����", "����", "������", "��������",
            "�������", "������", "�������" };
            int res = ds.Calculate(array); 
            int wait = 4;

            Assert.AreEqual(res, wait); 
        }
    }
}