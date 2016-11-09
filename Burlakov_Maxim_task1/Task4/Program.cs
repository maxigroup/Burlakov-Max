using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для задания 4");
            bool finish = false;
            while (!finish)
            {
                bool corrvalue = false;    //корректность значения
                int N = 0;
                while (!corrvalue)
                {
                    try
                    {
                        Console.WriteLine("Введите, пожалуйста, число N: ");
                        N = int.Parse(Console.ReadLine());
                        if (N <= 0) throw new Exception();
                        corrvalue = true;  //Если мы дошли до сюда, то всё идет по плану, а грязь превратилась лёд 
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Введено некорректное значение. Повторите ввод. \nОшибка: " + ex);
                    }
                }
                for (int x = 0; x <= N ; x++)
                {
                    for (int i = x; i > 0; i--)
                    {
                        for (int j = x - i; j < N-1; j++)   //так до конца и не понял, решил методом научного тыка
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j <= x - i; j++)
                        {
                            Console.Write("*");
                        }
                        for (int j = 0; j < x - i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
                bool repeat = false;
                while (!repeat)
                {
                    Console.WriteLine("Задать другое N? да/нет");
                    string ans = Console.ReadLine();
                    if (ans == "да") repeat = true;     //если да то выходим из цикла вопросов и возвращаемся к вводу N
                    if (ans == "нет") return;           //если нет то завершаем программу
                }
            }
        }
    }
}
