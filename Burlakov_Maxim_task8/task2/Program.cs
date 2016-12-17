namespace task2
{
    using System;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Программа для подзадания 2");
            string[] inputStr = { "4124", "41", "Lhfnenb", "0", "234-", "7768+++", " ", "=)", "1.2" };
            string result = "Строка \"{0} является положительным целым числом";
            foreach (string s in inputStr)
            {
                if (s.IsNumber())
                {
                    Console.WriteLine(result, s + "\"");
                }
                else
                {
                    Console.WriteLine(result, s + "\"" + " не");
                }
            }

            Console.ReadKey();
        }

        private static bool IsNumber(this string array)
        {
            if (array.Equals(string.Empty) || array.Equals("0"))
            {
                return false;
            }

            foreach (char ch in array)
            {
                if (ch < '0' || ch > '9')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
