namespace task3
{
    using System;
    class Ring : Round
    {
        private double inr; //Внутренний радиус кольца

        public double Inr
        {
            get
            {
                return inr;
            }
            set
            {
                if ((value < 0) || (value >= r))
                    throw new Exception("Внутренний радиус должен быть меньше внешнего, но не отрицательным!");
                inr = value;
            }
        }

        /// <summary>
        /// Конструктор для типа "Кольцо"
        /// </summary>
        /// <param name="r">Внешний радиус кольца</param>
        /// <param name="inr">Внутренний радиус кольца</param>
        /// <param name="a">Координаты центра кольца</param>
        public Ring(double r,double inr, Point a) : base(r, a)    //Здесь могла быть ваша реклама
        {
            Inr = inr;
        }

        public override void Print()
        {
            Console.WriteLine("Кольцо с внешним радиусом {0}, внутренним радиусом {1} координаты центра: ({2},{3})", R,Inr, a.X, a.Y);
        }
    }
}