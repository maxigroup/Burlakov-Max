using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для задания 2");
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
                        if (N <= 0) throw new Exception();//todo правило хорошего кода всегда обрамлять тело if фигурными скобками
                        corrvalue = true;  //Если мы дошли до сюда, то всё идет по плану
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Введено некорректное значение. Повторите ввод. \nОшибка: " + ex);
                    }
                }
                for(int i = 0; i < N; i++)
                {
                    for(int j = 0; j<= i; j++)  //пишем количество звездочек согласно номеру строки
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();        //переходим к следующей строке
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
