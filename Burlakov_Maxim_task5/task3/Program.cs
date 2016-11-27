namespace task3
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для задания 3");
            List<Figure> figures = new List<Figure>();  //список фигур
            bool finish = false;
            while (!finish)
            {
                try
                {
                    Console.WriteLine("Какое действие вы хотите выполнить?");
                    Console.WriteLine("1: Создать новую фигуру");
                    Console.WriteLine("2: Вывести созданные фигуры");
                    Console.WriteLine("3: Выход");
                    int sw = Int32.Parse(Console.ReadLine());
                    switch (sw)
                    {
                        case 1:
                            FigureMenu(figures);
                            break;
                        case 2:
                            Console.WriteLine("Создано {0} фигур:", figures.Count);
                            foreach(Figure f in figures)    //для каждой фигуры в листе вызываем Print
                                f.Print();
                            Console.WriteLine();
                            break;
                        case 3:
                            return;
                    }

                }
                catch
                {
                    Console.WriteLine("Некорректное значение, повторите ввод");
                }
            }
        }

        /// <summary>
        /// Меню выбора фигур для создания
        /// </summary>
        static void FigureMenu(List<Figure> figures)
        {
            bool ok = false;
            while (!ok)
            {
                try
                {
                    Console.WriteLine("Какую фигуру вы хотите создать?");
                    Console.WriteLine("1: Линия");
                    Console.WriteLine("2: Круг");
                    Console.WriteLine("3: Кольцо");
                    Console.WriteLine("4: Квадрат");
                    Console.WriteLine("5: Вернуться в главное меню");
                    int sw = Int32.Parse(Console.ReadLine());
                    switch (sw)
                    {
                        case 1:
                            LineMenu(figures);
                            break;
                        case 2:
                            RoundMenu(figures);
                            break;
                        case 3:
                            RingMenu(figures);
                            break;
                        case 4:
                            RectangleMenu(figures);
                            break;
                        case 5:
                            return;
                    }
                }
                catch
                {
                    Console.WriteLine("Некорректное значение, повторите ввод");
                }
            }
        }

        static void LineMenu(List<Figure> figures)
        {
            try
            {
                Console.WriteLine("Создаем линию");
                Console.WriteLine("Введите координаты начальной точки:");
                Double x1, x2, y1, y2;
                Console.Write("x = ");
                x1 = Int32.Parse(Console.ReadLine());
                Console.Write("y = ");
                y1 = Int32.Parse(Console.ReadLine());
                Point start = new Point(x1, y1);
                Console.WriteLine("Введите координаты конечной точки:");
                Console.Write("x = ");
                x2 = Int32.Parse(Console.ReadLine());
                Console.Write("y = ");
                y2 = Int32.Parse(Console.ReadLine());
                Point end = new Point(x2, y2);
                figures.Add(new Line(start,end));
                Console.Write("Линия a({0},{1}) - b({2},{3}) успешно создана!",x1, y1, x2, y2);
                return;
            }
            catch
            {
                Console.WriteLine("Некорректное значение, повторите ввод");
            }
        }

        static void RoundMenu(List<Figure> figures)
        {
            try
            {
                Console.WriteLine("Создаем круг");
                Console.WriteLine("Введите координаты центра круга:");
                Double x, y, r;
                Console.Write("x = ");
                x = Int32.Parse(Console.ReadLine());
                Console.Write("y = ");
                y = Int32.Parse(Console.ReadLine());
                Point center = new Point(x, y);
                Console.WriteLine("Введите радиус круга:");
                Console.Write("r = ");
                r = Int32.Parse(Console.ReadLine());
                figures.Add(new Round(r,center));
                Console.Write("Круг радиусом {0} и центром в точке ({1},{2}) успешно создан!", r, x, y);
                return;
            }
            catch
            {
                Console.WriteLine("Некорректное значение, повторите ввод");
            }
        }

        static void RingMenu(List<Figure> figures)
        {
            try
            {
                Console.WriteLine("Создаем кольцо");
                Console.WriteLine("Введите координаты центра кольца:");
                Double x, y, r, inr;
                Console.Write("x = ");
                x = Int32.Parse(Console.ReadLine());
                Console.Write("y = ");
                y = Int32.Parse(Console.ReadLine());
                Point center = new Point(x, y);
                Console.Write("Введите внешний радиус кольца: ");
                r = Int32.Parse(Console.ReadLine());
                Console.Write("Введите внутренний радиус кольца: ");
                inr = Int32.Parse(Console.ReadLine());
                figures.Add(new Ring(r, inr, center));
                Console.Write("Кольцо с внешним радиусом {0}, внутренним радиусом {1} и центром в точке ({2},{3}) успешно создан!", r, inr, x, y);
                return;
            }
            catch
            {
                Console.WriteLine("Некорректное значение, повторите ввод");
            }
        }

        static void RectangleMenu(List<Figure> figures)
        {
            try
            {
                Console.WriteLine("Создаем прямоугольник");
                Console.WriteLine("Введите координаты левого верхнего угла:");
                Double x1, x2, y1, y2;
                Console.Write("x = ");
                x1 = Int32.Parse(Console.ReadLine());
                Console.Write("y = ");
                y1 = Int32.Parse(Console.ReadLine());
                Point start = new Point(x1, y1);
                Console.WriteLine("Введите координаты правого нижнего угла:");
                Console.Write("x = ");
                x2 = Int32.Parse(Console.ReadLine());
                Console.Write("y = ");
                y2 = Int32.Parse(Console.ReadLine());
                Point end = new Point(x2, y2);
                figures.Add(new Rectangle(start, end));
                Console.Write("Прямоугольник a({0},{1}) b({2},{3}) c({4},{5}) d({6},{7}) успешно создан!", 
                    x1, y1, x1, y2, x2, y1, x2, y2);
                return;
            }
            catch
            {
                Console.WriteLine("Некорректное значение, повторите ввод");
            }
        }
    }
}
