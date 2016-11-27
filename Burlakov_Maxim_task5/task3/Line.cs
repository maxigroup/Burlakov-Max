namespace task3
{
    using System;
    class Line : Figure
    {
        private Point a;
        private Point b;

        public Line(Point start, Point end)
        {
            if (start != end)
            {
                a = start;
                b = end;
            }
            else
                throw new Exception("Координаты начала и конца линии не могут совпадать!");
        }

        public override void Print()
        {
            Console.WriteLine("Линия, координаты начальной точки({0},{1}),координаты конечной точки({2},{3})",
                a.X, a.Y, b.X, b.Y);
        }
    }
}
