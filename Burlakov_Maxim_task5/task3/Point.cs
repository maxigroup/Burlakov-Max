namespace task3
{
    using System;
    public class Point
    {
        private double x, y;
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                try
                {
                    x = (Double)value;
                }
                catch
                {
                    throw new Exception("Координаты должны иметь числовой тип");
                }
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
                try
                {
                    y = (Double)value;
                }
                catch
                {
                    throw new Exception("Координаты должны иметь числовой тип");
                }
            }
        }

        /// <summary>
        /// Конструктор для типа "Точка"
        /// </summary>
        /// <param name="x">Координата по оси x</param>
        /// <param name="y">Координата по оси y</param>
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}