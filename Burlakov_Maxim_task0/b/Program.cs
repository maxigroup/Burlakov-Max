using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для задания 2 \nВведите, пожалуйста, значение h:"); //Нужно быть предельно вежливым! //todo :) всё правильно говоришь
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели значение h=" + h );
            double a = Calculatea(h);
            Console.WriteLine("Значение a=" + a);
            double b = Calculateb(h,a);
            Console.WriteLine("Значение b=" + b);
            double c = Calculatec(h,a,b);
            Console.WriteLine("Значение c=" + c);
            double diskr = Discr(a, b, c);
            Console.WriteLine("Дискриминант D=" + diskr);
            if (diskr > 0)//todo лучше использовать здесь вилку if else else и без return (код становится более читаемым)
            {
                Console.WriteLine("Имеется два корня:");
                double x1 = (-b + Math.Sqrt(diskr)) / 2 * a;
                double x2 = (-b - Math.Sqrt(diskr)) / 2 * a;
                Console.WriteLine("x1=" + x1);
                Console.WriteLine("x2=" + x2);
                Console.ReadLine();
                return;
            }
            if (diskr == 0)
            {
                Console.WriteLine("Имеется имеется один корень:");
                double x = (-b + Math.Sqrt(diskr)) / 2 * a;
                Console.WriteLine("x=" + x);
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Уравнение не имеет действительных корней");
            Console.ReadLine();
            return;
        }
        static double Calculatea(double h)  //Вычисляем a
        {
            double num = Math.Abs(Math.Sin(8 * h)) + 17;                                //Числитель
            double denom = Math.Pow((1 - Math.Sin(4 * h) * Math.Cos(h * h + 18)),2);    //Знаменатель
            return Math.Sqrt(num / denom);                                              //Возвращаем квадратный корень дроби
        }
        static double Calculateb(double h,double a) //Вычисляем b
        {
            double denom = 3 + Math.Abs(Math.Tan(a * h * h) - Math.Sin(a * h)); //Знаменатель
            return 1 - Math.Sqrt(3 / denom);
        }
        static double Calculatec(double h, double a, double b)  //Вычисляем c
        {
            return a * h * h * Math.Sin(b * h) + b * h * h * h * Math.Cos(a * h);
        }
        static double Discr(double a, double b, double c)   //Вычисляем дискриминант
        {
            return b * b - 4 * a * c;
        }
    }
}
