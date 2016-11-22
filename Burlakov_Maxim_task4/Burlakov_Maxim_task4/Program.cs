namespace task1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для задания 1");
            bool finish = false;
            while (!finish)
            {
                Round round1;
                double r, x, y;
                try
                {
                    Console.WriteLine("Введите радиус круга: ");
                    r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату x круга: ");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату y круга: ");
                    y = Convert.ToDouble(Console.ReadLine());
                    round1 = new Round(r, x, y);

                }
                catch
                {
                    Console.WriteLine("Введены некорректные данные, загружены данные по умолчанию");
                    x = 0;
                    y = 0;
                    r = 3;
                    round1 = new Round(r, x, y);
                }
                Console.WriteLine("Радиус круга {0}, координаты {1},{2}",round1.R,round1.X,round1.X);
                Console.WriteLine("Длина описаной окружности равна {0}",round1.Length());
                Console.WriteLine("Площадь круга равна {0}", round1.Square());
                Console.WriteLine("Повторить? д/н");
                string ans = Console.ReadLine();
                if (ans == "н") return;           //если нет то завершаем программу
            }
        }
    }
}