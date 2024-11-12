using Tyuiu.MyshakinD.Sprint4.Task7.V8.Lib;

namespace Tyuiu.MyshakinD.Sprint4.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "264795863157";
            int rows = 3;
            int colums = 4;
            int res = ds.Calculate(rows, colums, str);
            int wait = 37;

            Assert.AreEqual(res, wait);
        }
    }
}