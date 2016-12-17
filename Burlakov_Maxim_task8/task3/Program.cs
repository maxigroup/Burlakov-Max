namespace task3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Diagnostics;

    internal delegate IEnumerable<int> Del(int[] array);    //Я всё еще не понимаю делегаты =(

    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Программа для подзадания 3");

            const int N = 1000;

            Random rnd = new Random();
            int[] numArray = new int[N];
            for(int i = 0; i < N; i++)
            {
                numArray[i] = rnd.Next(-100, 100);
            }

            Stopwatch sw = new Stopwatch();
            sw.Start();
            PositiveNumbers(numArray);
            Console.WriteLine("Поиск напрямую справился за {0} тиков", sw.ElapsedTicks);
            sw.Reset();

            sw.Start();
            PositiveNumbers(numArray, PositiveNumbers);
            Console.WriteLine("Поиск с условием через делегат справился за {0} тиков", sw.ElapsedTicks);
            sw.Reset();

            sw.Start();
            Del anonymousMethod = delegate (int[] array)
            {
                return PositiveNumbers(array);
            };
            PositiveNumbers(anonymousMethod, numArray);
            Console.WriteLine("Поиск с условием через делегат в виде анонимного метода справился за {0} тиков", sw.ElapsedTicks);
            sw.Reset();

            sw.Start();
            Del lambda = (list) => PositiveNumbers(list);
            PositiveNumbers(lambda, numArray);
            Console.WriteLine("Поиск с условием через делегат в виде лямбда-выражения справился за {0} тиков", sw.ElapsedTicks);
            sw.Reset();

            sw.Start();
            PositiveNumbersLinq(numArray);
            Console.WriteLine("LINQ-выражение справилось за {0} тиков", sw.ElapsedTicks);   //работает на порядок дольше, это норма?

            Console.ReadKey();
        }

        private static IEnumerable<int> PositiveNumbers(int[] numArray)
        {
            List<int> tempList = new List<int>();
            foreach(int i in numArray)
            {
                if (i > 0)
                {
                    tempList.Add(i);
                }
            }
            return tempList.ToArray();
        }

        private static IEnumerable<int> PositiveNumbers(int[] numArray, Func<int[], IEnumerable<int>> func)
        {
            return func(numArray);
        }

        private static IEnumerable<int> PositiveNumbers(Del anonMethod, int[] numArray)
        {
            return anonMethod(numArray);
        }

        private static IEnumerable<int> PositiveNumbersLinq(int[] numArray)
        {
            return from num in numArray
                   where num > 0
                   select num;
        }

        private static void Print(IEnumerable<int> numArray)
        {
            foreach (int i in numArray)
            {
                Console.Write("{0} ", i);
            }

            Console.Write("\n");
        }
    }
}