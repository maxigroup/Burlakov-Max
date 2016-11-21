namespace task3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Diagnostics;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для задания 3");
            bool finish = false;
            while (!finish)
            {
                Stopwatch stopw = new Stopwatch();  //На старт! Внимание!
                string str = string.Empty;
                StringBuilder sb = new StringBuilder();
                int n = 100;

                stopw.Start();      //Марш!
                for (int i = 0; i < n; i++)
                    str += "*";
                Console.WriteLine("String выполнил за {0} тактов", stopw.ElapsedTicks);

                stopw.Restart();    //Марш!
                for (int i = 0; i < n; i++)
                    sb.Append("*");
                Console.WriteLine("StringBuilder выполнил за {0} тактов", stopw.ElapsedTicks);
                stopw.Stop();   //Вручаем кубки победителям

                Console.WriteLine("Повторить? д/н");
                string ans = Console.ReadLine();
                if (ans == "н") return;           //если нет то завершаем программу
            }
        }
    }
}