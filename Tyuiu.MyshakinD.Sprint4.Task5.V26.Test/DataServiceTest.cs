using Tyuiu.MyshakinD.Sprint4.Task5.V26.Lib;

namespace Tyuiu.MyshakinD.Sprint4.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = { { -1, -3, 4, 2, 3},
            { 4, 1, -1, -4, 3 },
            { 1, 2, -3, 4, -2},
            { -2, -3, 1, -4, 3},
            { -1, 1, -1, 1, 2} };

            int[,] wait = { { -1, -3, 1, 1, 1},
            {1, 1, -1, -4, 1 },
            {1, 1, -3, 1, -2 },
            { -2, -3, 1, -4, 1},
            { -1, 1, -1, 1, 1} };

            int[,] res = ds.Calculate(matrix);

            CollectionAssert.AreEqual(res, wait);
        }
    }
}