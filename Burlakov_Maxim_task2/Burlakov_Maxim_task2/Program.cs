using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0
{
    class Program
    {
        const int count = 10;   //Количество элементов в массиве
        const int maxrnd = 100; //Максимальное значение рандома

        static void Main(string[] args)
        {
            Console.WriteLine("Программа для задания 0");
            Random rnd = new Random();  //Генератор псевдослучайных чисел(инициируется текущим временем)
            bool finish = false;
            while (!finish)
            {
                int[] arr = new int[count];    //Обьявляем и создаем массив
                for (int i = 0; i < count; i++)
                    arr[i] = rnd.Next(-maxrnd, maxrnd);    //Заполняем i-ый элемент массива случайным числом
                Console.Write("Исходный массив: ");
                ArrView(arr);
                Console.WriteLine("Минимальный элемент: "+ArrMin(arr));
                Console.WriteLine("Максимальный элемент: " + ArrMax(arr));
                QuickSort(arr,0,count-1);
                Console.Write("Отсортированный массив: ");
                ArrView(arr);
                bool repeat = false;
                while (!repeat)
                {
                    Console.WriteLine("Повторить? да/нет");
                    string ans = Console.ReadLine();
                    if (ans == "да") repeat = true;     //если да то выходим из цикла вопросов и возвращаемся к вводу N//todo аналогично заданию 1
                    if (ans == "нет") return;           //если нет то завершаем программу
                }
            }
        }

        //Выводит элементы массива в консоль
        static void ArrView(int[] arr)
        {
            for (int i=0; i<count; i++)
                Console.Write(arr[i]+ " ");
            Console.WriteLine();
            return;//todo для чего?
        }
        
        //Находит максимальный элемент в массиве
        static int ArrMax(int[] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < count; i++)
                if (arr[i] > max) max = arr[i];
            return max;
        }

        //Находит минимальный элемент в массиве
        static int ArrMin(int[] arr)
        {
            int min = int.MaxValue;
            for (int i = 0; i < count; i++)
                if (arr[i] < min) min = arr[i];
            return min;
        }

        //Сортирует массив методом быстрой сортировки
        static void QuickSort(int[] a, int l, int r)
        {
            int temp;
            int x = a[l + (r - l) / 2];
            int i = l;
            int j = r;
            while (i <= j)
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < r)
                QuickSort(a, i, r);

            if (l < j)
                QuickSort(a, l, j);
            return;//todo для чего?
        }
    }
}
