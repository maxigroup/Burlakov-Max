using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        const int count = 3;   //Количество элементов
        const int maxrnd = 100; //Максимальное значение рандома

        static void Main(string[] args)
        {
            Console.WriteLine("Программа для задания 1");
            Random rnd = new Random();  //Генератор псевдослучайных чисел(инициируется текущим временем)
            bool finish = false;
            while (!finish)
            {
                int[,,] arr = new int[count,count,count];    //Обьявляем и создаем трёхмерный массив
                for (int i = 0; i < count; i++)
                    for(int j = 0; j < count; j++)
                        for(int k = 0; k < count; k++)
                            arr[i,j,k] = rnd.Next(-maxrnd, maxrnd);    //Заполняем трёхмерный массив
                Console.WriteLine("Исходный трёхмерный массив: ");
                ArrView(arr);
                Zeroing(arr);
                Console.WriteLine("Трёхмерный массив с обнулёнными положительными элементами: ");
                ArrView(arr);
                bool repeat = false;
                while (!repeat)
                {
                    Console.WriteLine("Повторить? да/нет");
                    string ans = Console.ReadLine();
                    if (ans == "да") repeat = true;     //если да то выходим из цикла вопросов и возвращаемся к вводу N
                    if (ans == "нет") return;           //если нет то завершаем программу
                }
            }
        }

        //Выводит элементы трёхмерного массива в консоль
        static void ArrView(int[,,] arr)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    for (int k = 0; k < count; k++)
                        Console.Write("{0,4}", arr[i, j, k]);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return;//todo для чего?
        }

        //Заменяет все положительные элементы массива на нули
        static void Zeroing(int[,,] arr)
        {
            for (int i = 0; i < count; i++)
                for (int j = 0; j < count; j++)
                    for (int k = 0; k < count; k++)
                        if (arr[i, j, k] > 0) arr[i, j, k] = 0;
        }
    }
}