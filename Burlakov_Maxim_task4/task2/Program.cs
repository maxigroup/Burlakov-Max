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
                Triangle triangle1;
                double a, b, c;
                try
                {
                    Console.WriteLine("Введите длину стороны a треугольника: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите длину стороны b треугольника: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите длину стороны c треугольника: ");
                    c = Convert.ToDouble(Console.ReadLine());
                    triangle1 = new Triangle(a, b, c);

                }
                catch
                {
                    Console.WriteLine("Введены некорректные данные, загружены данные по умолчанию");
                    a = 2;
                    b = 2;
                    c = 3;
                    triangle1 = new Triangle(a, b, c);
                }
                Console.WriteLine("Длина стороны a {0}, стороны b {1}, стороны c {2}", triangle1.A, triangle1.B, triangle1.C);
                Console.WriteLine("Периметр треугольника равен {0}", triangle1.Perimeter());
                Console.WriteLine("Площадь треугольника равна {0}", triangle1.Square());

                Console.WriteLine("Повторить? д/н");
                string ans = Console.ReadLine();
                if (ans == "н") return;           //если нет то завершаем программу
            }
        }
    }
}