namespace task2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Triangle
    {
        private double a, b, c;
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Длина стороны должна быть положительной!");   //Чуть что-кидаем исключение
                a = value;  //чуть было в запарке не добавил проверку на совпадение координат(которых мы не знаем) =)
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Длина стороны должна быть положительной!");   //Чуть что-кидаем исключение
                b = value;
            }
        }
        public double C
        {
            get
            {
                return c;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Длина стороны должна быть положительной!");   //Чуть что-кидаем исключение
                c = value;
            }
        }

        public Triangle(double a, double b, double c)  //Конструктор(кэп)
        {
            A = a;
            B = b;
            C = c;
        }

        public double Perimeter()
        {
            return a+b+c;
        }
        public double Square()
        {
            double p = this.Perimeter() / 2;         //полупериметр
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));   //формула Герона
        }
    }
}
