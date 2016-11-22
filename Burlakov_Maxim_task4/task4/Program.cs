namespace task4
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
            Console.WriteLine("Программа для задания 4");
            bool finish = false;
            while (!finish)
            {
                Console.WriteLine("Введите строку для записи: ");
                string temp = Console.ReadLine();   //пишем с консоли в стринг
                MyString ms1 = new MyString(temp.ToCharArray(0, temp.Length));  //переписываем из стринга в массив символов
                Console.WriteLine("Введенная строка: {0}", ms1.toString());
                Console.WriteLine("Длина строки {0}", ms1.Length());
                Console.WriteLine("Повторить? д/н");
                string ans = Console.ReadLine();
                if (ans == "н") return;           //если нет то завершаем программу
            }
        }
    }
}