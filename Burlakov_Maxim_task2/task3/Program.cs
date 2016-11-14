using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        const int count = 3;   //Количество элементов
        const int maxrnd = 100; //Максимальное значение рандома

        static void Main(string[] args)
        {
            Console.WriteLine("Программа для задания 3");
            Random rnd = new Random();  //Генератор псевдослучайных чисел(инициируется текущим временем)
            bool finish = false;
            while (!finish)
            {
                int[,] arr = new int[count, count];    //Обьявляем и создаем двухмерный массив
                for (int i = 0; i < count; i++)
                    for (int j = 0; j < count; j++)
                        arr[i, j] = rnd.Next(-maxrnd, maxrnd);    //Заполняем двухмерный массив
                Console.WriteLine("Исходный двухмерный массив: ");
                ArrView(arr);
                EvenSum(arr);
                Console.WriteLine("Сумма элементов двухмерного массива, стоящих на чётных позициях: "+EvenSum(arr));
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
        static void ArrView(int[,] arr)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                    Console.Write("{0,4}", arr[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
            return;
        }

        //Находит сумму элементов, стоящих на четных позициях
        static int EvenSum(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < count; i++)
                for (int j = 0; j < count; j++)
                    if ((i+j)%2==0) sum += arr[i, j];
            return sum;
        }
    }
}