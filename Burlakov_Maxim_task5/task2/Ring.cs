namespace task2
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

        public Ring(double r,double inr, double x, double y) : base(r, x, y)    //Здесь могла быть ваша реклама//todo ты, я смотрю, всё шутишь :)
        {
            Inr = inr;
        }

        public new double Length()  //Длина внешней и внутренней границ кольца
        {
            return (2 * Math.PI * r) + (2 * Math.PI * inr);
        }

        public new double Square()  //Площадь кольца
        {
            return (Math.PI * r * r) - (Math.PI * inr * inr);
        }
    }
}