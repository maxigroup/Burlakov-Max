using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для задания 5");
            int N = 1000;
            int sum = 0;
            //решение "в лоб"
            for (int i = 1; i < N; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                    sum += i;
            }
            Console.WriteLine("Сумма всех чисел кратных 3 и 5 меньших {0} равна {1}",N,sum);
            Console.ReadLine();
        }
    }
}
