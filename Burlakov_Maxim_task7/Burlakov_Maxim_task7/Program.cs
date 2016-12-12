namespace Task1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для задания 1");
            string[] arr = { "каждый", "охотник", "желает", "знать", "где", "сидит", "фазан" };
            Console.WriteLine("Исходный массив строк: ");
            foreach(string str in arr)
            {
                Console.WriteLine(str);
            }

            arr = StringSort(arr);
            Console.WriteLine("Отсортированный массив строк: ");
            foreach (string str in arr)
            {
                Console.WriteLine(str);
            }
            //Йода плачет от счастья
            Console.ReadKey();
        }

        delegate bool DelegateStrCompar(string a, string b);

        /// <summary>
        /// Сравнивает строки на предмет необходимости обмена их местами для сортировки
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static bool StrCompar(string a, string b)
        {
            if(a.Length > b.Length)
            {
                return true;
            }
            if (a.Length == b.Length)
            {
                char[] s1 = a.ToCharArray();
                char[] s2 = b.ToCharArray();
                for (int i = 0; i < a.Length; i++)
                {
                    if (s1[i] < s2[i]) return false;
                    if (s1[i] > s2[i]) return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Проводит сортировку в массиве строк по возрастанию количества символов 
        /// и в алфавитном порядке
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static string[] StringSort(string[] arr)
        {
            //очень сложно понять реальное назначение делегатов
            DelegateStrCompar delegateStrCompar = new DelegateStrCompar(StrCompar);
            string temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = arr.Length-1; j != i; j--)
                {
                    if (delegateStrCompar(arr[i], arr[j]))
                    {
                        temp = arr[i];      //не кидайте тапками, свапаю как умею =)
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
