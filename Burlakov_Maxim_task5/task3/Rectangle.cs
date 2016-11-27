namespace task3
{
    using System;
    class Rectangle : Figure
    {
        private Point a;
        private Point b;
        private Point c;
        private Point d;

        /// <summary>
        /// Конструктор для типа "Прямоугольник"
        /// </summary>
        /// <param name="point1">Координата левого верхнего угла</param>
        /// <param name="point2">Координата правого нижнего угла</param>
        public Rectangle(Point point1, Point point2)  //для задания прямоугольника вполне достаточно двух противостоящих точек
        {
            if ((point1.X != point2.X) || (point1.Y != point2.Y)) //Если точки не стоят на одной линии
            {
                a = point1;
                d = point2;
                b = new Point(point1.X, point2.Y);
                c = new Point(point1.Y, point2.X);
            }
            else
                throw new Exception("Противостоящие точки не должны стоять на одной линии");
        }

        public override void Print()
        {
            Console.WriteLine("Прямоугольник, координаты точек: a({0},{1}), b({2},{3}), c({4},{5}), d({6},{7})",
                a.X, a.Y, b.X, b.Y, c.Y, c.X, d.X, d.Y);
        }
    }
}
