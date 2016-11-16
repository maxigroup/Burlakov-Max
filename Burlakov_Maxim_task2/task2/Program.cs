using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        const int count = 10;   //Количество элементов в массиве
        const int maxrnd = 100; //Максимальное значение рандома

        static void Main(string[] args)
        {
            Console.WriteLine("Программа для задания 2");
            Random rnd = new Random();  //Генератор псевдослучайных чисел(инициируется текущим временем)
            bool finish = false;
            while (!finish)
            {
                int[] arr = new int[count];    //Обьявляем и создаем массив
                for (int i = 0; i < count; i++)
                    arr[i] = rnd.Next(-maxrnd, maxrnd);    //Заполняем i-ый элемент массива случайным числом
                Console.Write("Массив: ");
                ArrView(arr);
                Console.WriteLine("Сумма нетрицательных элементов массива равна "+ArrSumNoNegative(arr));
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

        //Выводит элементы массива в консоль
        static void ArrView(int[] arr)
        {
            for (int i = 0; i < count; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
            return;//todo для чего?
        }

        //Находит сумму неотрицательных элементов в массиве
        static int ArrSumNoNegative(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < count; i++)
                if (arr[i] >= 0) sum += arr[i];
            return sum;
        }
    }
}
