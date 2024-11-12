using Tyuiu.MyshakinD.Sprint4.Task6.V11.Lib;

namespace Tyuiu.MyshakinD.Sprint4.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string[] list = { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };
            int res = ds.Calculate(list);
            int wait = 3;
            Assert.AreEqual(res, wait);
        }
    }
}