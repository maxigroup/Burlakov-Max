namespace task2
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Program//todo было бы здорово, если бы ты выделил все эти методы в отдельный класс (например, Parser)
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для задания 2");
            while (true)
            {
                List<Word> words = GetWords();
                PrintList(words);
                Console.WriteLine("Повторить? д/н");
                string ans = Console.ReadLine();
                if (ans == "н")
                {
                    return;
                }
            }
        }

        public static List<Word> GetWords()
        {
            List<Word> words = new List<Word>();
            Console.WriteLine("Введите текст:");
            string inputString = Console.ReadLine();
            StringBuilder temp = new StringBuilder(string.Empty);

            for(int i = 0; i < inputString.Length; i++)
            {
                if (char.IsLetter(inputString[i]))
                {
                    temp.Append(inputString[i]);
                }
                else
                {
                    if (temp.Length > 0)
                    {
                        if (IfExist(words, temp))
                        {
                            IncCount(words, temp);
                        }
                        else
                        {
                            words.Add(new Word(temp.ToString()));
                        }

                        temp.Clear();
                    }
                }
            }
            if (temp.Length > 0)    //Кусочек повторяется =)
            {
                if (IfExist(words, temp))
                {
                    IncCount(words, temp);
                }
                else
                {
                    words.Add(new Word(temp.ToString()));
                }
            }
            return words;
        }

        /// <summary>
        /// Определяет содержится ли указанное слово в списке слов
        /// </summary>
        /// <param name="list">Список слов</param>
        /// <param name="sb">Искомое слово</param>
        /// <returns></returns>
        public static bool IfExist(List<Word> list, StringBuilder sb)
        {
            foreach(Word word in list)
            {
                if (word.Value.ToLower().Equals(sb.ToString().ToLower()))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Увеличивает счетчик вхождений указанного слова в строку
        /// </summary>
        /// <param name="list">Список слов</param>
        /// <param name="sb">Слово с увеличиваемым счетчиком</param>
        public static void IncCount(List<Word> list, StringBuilder sb)
        {
            foreach (Word word in list)
            {
                if (word.Value.ToLower().Equals(sb.ToString().ToLower()))
                {
                    word.Count++;
                }
            }
        }

        /// <summary>
        /// Выводит в консоль слова из списка и количество их вхождений
        /// </summary>
        /// <param name="words"></param>
        public static void PrintList(List<Word> words)
        {
            Console.WriteLine("Слова и количество их вхождений в строку:");
            foreach (Word word in words)
            {
                Console.WriteLine("Слово: {0}, вхождения: {1}", word.Value, word.Count);
            }
        }
    }
}
