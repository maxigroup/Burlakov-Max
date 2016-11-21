namespace task2
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
            Console.WriteLine("Программа для задания 2");
            bool finish = false;
            while (!finish)
            {
                Console.WriteLine("Введите первую строку: ");
                string text1 = Console.ReadLine();
                Console.WriteLine("Введите вторую строку: ");
                string text2 = Console.ReadLine();
                Console.WriteLine("Результирующая строка: "+TextDoubler(text1,text2));
                Console.WriteLine("Повторить? д/н");
                string ans = Console.ReadLine();
                if (ans == "н") return;           //если нет то завершаем программу
            }
        }

        static string TextDoubler(string text1, string text2)
        {
            string text3 = string.Empty;    //Результирующая строка
            foreach (char letter in text1)
            {
                if (text2.Contains(letter))     //Если второй текст содержит текущую букву то добавляем её в строку
                    text3 = text3 + letter;
                text3 = text3 + letter;         //Пишем текущую букву в строку
            }
            return text3;
        }
    }
}