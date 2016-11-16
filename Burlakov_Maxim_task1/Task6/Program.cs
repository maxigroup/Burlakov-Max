using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        public struct Options   //Решил реализовать это структурой. Потому, что гладиолус
        {
            public bool bold;
            public bool italic;
            public bool underline;
            public Options(bool bold, bool italic, bool underline)
            {
                this.bold = bold;
                this.italic = italic;
                this.underline = underline;
            }
            public void ViewOptions()
            {
                Console.Write("Параметры надписи:");
                if (this.bold) Console.Write(" Bold");//todo this не нужно
                if (this.italic) Console.Write(" Italic");
                if (this.underline) Console.Write(" Underline");
                if (!((this.bold)|| (this.italic) || (this.underline))) Console.Write(" None");
                Console.WriteLine();
            }
            public void SetOptions(int value)
            {
                switch (value)
                {
                    case 1:
                        this.bold = !this.bold;
                        break;
                    case 2:
                        this.italic = !this.italic;
                        break;
                    case 3:
                        this.underline = !this.underline;
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для задания 5");
            Options opt = new Options(false, false, false);
            bool finish = false;
            while (!finish)//todo можно же просто поставить true и не использовать finish
            {
                bool corrvalue = false;    //корректность значения
                int value = 0;
                while (!corrvalue)
                {
                    try
                    {
                        opt.ViewOptions();
                        Console.WriteLine("Введите: \n1: bold \n2: italic \n3: underline ");
                        value = int.Parse(Console.ReadLine());
                        if ((value < 1)||(value > 3)) throw new Exception();
                        opt.SetOptions(value);
                        corrvalue = true;  //Если мы дошли до сюда, то перестройка всё идёт и идёт по плану
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Введено некорректное значение. Повторите ввод. \nОшибка: " + ex);
                    }
                }
                //todo а как выйти из цикла?
            }
        }
    }
}
