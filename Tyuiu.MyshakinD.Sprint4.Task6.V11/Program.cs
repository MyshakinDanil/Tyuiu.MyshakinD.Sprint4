using Tyuiu.MyshakinD.Sprint4.Task6.V11.Lib;

namespace Tyuiu.MyshakinD.Sprint4.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Мышакин Д. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Мышакин Данил              | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Кошка\", \"Собака\", \"Слон\",           *");
            Console.WriteLine("* \"Жираф\", \"Бегемот\", \"Игуана\", \"Ягуар\"] используя класс Array    *");
            Console.WriteLine("* подсчитайте количество элементов, длина которых равна 5.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string[] list = { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(list);
            Console.WriteLine($"Количество элементов, длина которых равна 5: {res}");
        }
    }
}
