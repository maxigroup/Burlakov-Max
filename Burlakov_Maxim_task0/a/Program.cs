using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Программа для задания а \nВведите, пожалуйста, координаты точки:"); //Нужно быть предельно вежливым!
            Console.Write("x = ");
            double ax = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double ay = double.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели координаты a("+ax+";"+ay+")");
            if (acheck(ax,ay))
                Console.WriteLine("Точка a(" + ax + ";" + ay + ") принадлежит окружности");
            else
                Console.WriteLine("Точка a(" + ax + ";" + ay + ") не принадлежит окружности. Извините нам очень стыдно за это.");
            Console.ReadKey();
        }

        //Проверка по заданию а
        static bool acheck(double ax, double ay)
        {
            double r = 1; //Радиус
            if ((ax * ax + ay * ay) <= r * r)
                return true;
            return false;
        }

        //Проверка по заданию б
        static bool bcheck(double ax, double ay)
        {
            double rout = 1;    //Внешний радиус
            double rin= 0.5;    //Внутренний радиус
            if (((ax * ax + ay * ay) <= rout * rout)& ((ax * ax + ay * ay) >= rin * rin))
                return true;
            return false;
        }

        //Проверка по заданию в
        static bool vcheck(double ax, double ay)
        {
            double halfside = 1;    //Половина стороны квадрата
            if ((Math.Abs(ax)-halfside <=0) & (Math.Abs(ay) - halfside <=0))
                return true;
            return false;
        }

        //Проверка по заданию г
        static bool gcheck(double ax, double ay)
        {
            double xside = 1;   //вершина по x
            double yside = 1;   //вершина по y
            //определим в какой четверти находится точка
            if ((ax >= 0) & (ay >= 0))    //первая четверть
            {
                Vector a = new Vector(ax,ay);
                //задумался..
            }
            return false;
        }
    }

    //Слава велосипедам!
    class Vector
    {
        private double x;
        private double y;

        public Vector() //Конструктор по умолчанию
        {
            x = 0;
            y = 0;
        }
        public Vector(double x, double y)   //Конструктор
        {
            this.x = x;
            this.y = y;
        }
        public void Set(double x, double y)     //Сеттер
        {
            this.x = x;
            this.y = y;
        }
        public double GetX()    //Гет Икс
        {
            return x;
        }
        public double GetY()    //Не понимаю что это делает!(шутка)
        {
            return y;
        }
        public double Module()
        {
            return Math.Sqrt(this.x * this.x + this.y * this.y);
        }

    }
}
