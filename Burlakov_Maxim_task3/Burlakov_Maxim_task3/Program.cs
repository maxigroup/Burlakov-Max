namespace task1
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
            bool finish = false;
            while (!finish)
            {
                double average = AverageLength();
                Console.WriteLine("Средняя длина слова в введенной строке: {0}",average);
                Console.WriteLine("Повторить? д/н");
                string ans = Console.ReadLine();
                if (ans == "н") return;           //если нет то завершаем программу
            }
        }

        public static double AverageLength()
        {
            Console.WriteLine("Введите текстовую строку: ");
            string text = Console.ReadLine();
            string temp = String.Empty;     //Текущее слово
            int count = 0;                  //Количество слов
            List<string> words = new List<string>();    //Список слов, заполняем из введенной строки

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    temp = temp+text[i];    //Если буква то добавляем её к текущему слову
                }
                else
                {
                    if (temp != string.Empty)   //Иначе, если текущее слово не пустое, добавляем его в список и обнуляем
                    {
                        words.Add(temp);
                        temp = string.Empty;
                        count++;
                    }
                }
            }
            if (temp != String.Empty)       //после того как дошли до конца строки
            {
                words.Add(temp);            //добавляем в список послледнее слово(если есть)
                count++;
            }
            
            int sumlength = 0;              //Суммарна длина слов
            foreach(string word in words)
                sumlength += word.Length;
            return (sumlength/(double)count);   //Приводим к double и возращаем отношение суммарной длины к количеству слов
        }
    }
}