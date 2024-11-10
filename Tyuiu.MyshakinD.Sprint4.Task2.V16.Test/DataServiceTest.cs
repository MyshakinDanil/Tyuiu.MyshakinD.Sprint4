using Tyuiu.MyshakinD.Sprint4.Task2.V16.Lib;

namespace Tyuiu.MyshakinD.Sprint4.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 4, 2, 3, 7, 5, 9, 6, 4, 7, 7 };
            int res = ds.Calculate(array);
            int wait = 38;
            Assert.AreEqual(res, wait);
        }
    }
}