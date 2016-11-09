using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для задания 1");
            bool finish = false;
            while (!finish)
            {
                bool corrvalues = false;    //корректность значений для расчета площади
                int a = 0, b = 0;   //стороны треугольника 
                //^^^^^^почему то ругается на использование неприсвоенных значений, хотя ниже мы их назначаем в любом случае...
                while (!corrvalues) //пока значения сторон не будут корректными
                {
                    try
                    {
                        Console.WriteLine("Введите, пожалуйста, сторону a:");
                        a = int.Parse(Console.ReadLine());
                        if (a <= 0) throw new Exception();
                        Console.WriteLine("Введите, пожалуйста, сторону b:");
                        b = int.Parse(Console.ReadLine());
                        if (b <= 0) throw new Exception();
                        corrvalues = true;  //Если мы дошли до сюда, то значения введены корректно
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Введено некорректное значение. Повторите ввод. \nОшибка: "+ ex);
                    }
                }
                Console.WriteLine("Площадь прямоугольника со сторонами {0} и {1} равна {2}",a,b,a*b);   //стороны и их произведение(площадь прямоугольника)
                bool repeat = false;
                while (!repeat)
                {
                    Console.WriteLine("Задать другие стороны? да/нет");
                    string ans = Console.ReadLine();
                    if (ans == "да") repeat = true;     //если да то выходим из цикла вопросов и возвращаемся к вводу сторон
                    if (ans == "нет") return;           //если нет то завершаем программу
                }
            }
        }
    }
}
