namespace task1
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public const int N = 12;

        public static void Main(string[] args)
        {
            Console.WriteLine("Программа для задания 1");
            List<int> peoples = new List<int>();
            for (int i = 0; i < N; i++)
            {
                peoples.Add(i);
            }
            Console.Write("Элементы, входящие в список: ");
            foreach (int people in peoples)
            {
                Console.Write(people + " ");
            }
            Console.WriteLine("\nУдаляем каждый второй элемент: ");

            while (peoples.Count > 1)
            {
                int peoplesCount = peoples.Count;
                if (peoplesCount % 2 == 1)
                {
                    peoplesCount--;
                }

                for (int i = peoplesCount-1; i >= 0; i = i-2) //удаляем каждый второй элемент по индексу(с хвоста)
                {
                    peoples.RemoveAt(i);
                }

                foreach (int people in peoples)
                {
                    Console.Write(people + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Программа завершена!");
            Console.ReadKey();
        }
    }
}