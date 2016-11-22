namespace task1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Round
    {
        private double r, x, y;
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
