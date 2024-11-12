using System.Runtime.InteropServices;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MyshakinD.Sprint4.Task6.V11.Lib
{
    public class DataService : ISprint4Task6V11
    {
        public int Calculate(string[] array)
        {
            int count = array.Count(x => x.Length == 5);
            return count;
        }
    }
}
