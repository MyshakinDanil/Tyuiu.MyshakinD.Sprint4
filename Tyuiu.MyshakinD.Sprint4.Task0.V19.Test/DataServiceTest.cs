using Tyuiu.MyshakinD.Sprint4.Task0.V19.Lib;

namespace Tyuiu.MyshakinD.Sprint4.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] arrays = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            int res = ds.GetMultOddArrEl(arrays);
            int wait = 297675;
            Assert.AreEqual(res, wait);
        }
    }
}