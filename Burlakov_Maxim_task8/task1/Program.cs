namespace task1
{
    using System;

    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для подзадания 1");
            int[] array = { 2, 5, 4, 6 };
            Console.Write("Элементы массива: ");
            foreach(int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nСумма элементов массива: {0}",array.Sum());
            Console.ReadKey();

        }

        private static int Sum(this int[] array)
        {
            int finalsum = 0;
            foreach(int i in array)
            {
                finalsum += i;
            }

            return finalsum;
        }
    }
}
