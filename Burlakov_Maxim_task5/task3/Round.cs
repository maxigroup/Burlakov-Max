namespace task3
{
    using System;
    class Round : Figure
    {
        protected Point a;  //Раз уж ввели класс точек то почему бы и нет?
        protected double r; //Нужен доступ потомков для сравнения внешнего и внутреннего радиуса
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

        /// <summary>
        /// Конструктор для типа "Круг"
        /// </summary>
        /// <param name="r">Радиус</param>
        /// <param name="point">Координаты центра круга</param>
        public Round(double r, Point point)  //Конструктор(кэп)
        {
            R = r;
            a = point;
        }
        
        public override void Print()
        {
            Console.WriteLine("Круг радиусом {0}, координаты центра: ({1},{2})",R,a.X,a.Y);
        }
    }
}
