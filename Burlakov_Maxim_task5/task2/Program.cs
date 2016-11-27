namespace task2
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
            Console.WriteLine("Программа для задания 2");
            bool finish = false;
            while (!finish)
            {
                Ring round1;
                double r, inr, x, y;
                try
                {
                    Console.WriteLine("Введите внешний радиус кольца: ");
                    r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите внутренний радиус кольца: ");
                    inr = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату x центра кольца: ");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату y центра кольца: ");
                    y = Convert.ToDouble(Console.ReadLine());
                    round1 = new Ring(r, inr, x, y);

                }
                catch
                {
                    Console.WriteLine("Введены некорректные данные, загружены данные по умолчанию");
                    r = 3;
                    inr = 1;
                    x = 0;
                    y = 0;
                    round1 = new Ring(r, inr, x, y);
                }
                Console.WriteLine("Внешний радиус кольца {0}, внутренний радиус кольца {1} координаты ({2},{3})", 
                    round1.R, round1.Inr, round1.X, round1.Y);
                Console.WriteLine("Суммарная длинна внешней и внутренней окружности кольца равна {0}", round1.Length());
                Console.WriteLine("Площадь кольца равна {0}", round1.Square());

                Console.WriteLine("Повторить? д/н");
                string ans = Console.ReadLine();
                if (ans == "н") return;           //если нет то завершаем программу
            }
        }
    }
}