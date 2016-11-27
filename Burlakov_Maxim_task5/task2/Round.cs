namespace task2
{
    using System;
    class Round
    {
        private double x, y;
        protected double r;     //Нужен доступ потомков для сравнения внешнего и внутреннего радиуса
        public double R
        {
            get
            {
                return r;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Радиус должен быть положительным!");   //Чуть что-кидаем исключение
                else
                    r = value;
            }
        }
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public Round(double r, double x, double y)  //Конструктор(кэп)
        {
            R = r;
            X = x;
            Y = y;
        }
        public double Length()
        {
            return 2 * Math.PI * r;
        }
        public double Square()
        {
            return Math.PI * r * r;
        }
    }
}
