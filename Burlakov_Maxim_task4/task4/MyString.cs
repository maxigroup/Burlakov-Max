namespace task4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class MyString//todo не перегрузил ни один из типовых операторов (+, ==, !=)
    {
        private char[] text;

        public MyString(params char[] input)
        {
            text = new char[input.Length];
            text = input;
        }

        public Boolean Equals(MyString ms1)
        {
            if ( (this.Length() == ms1.Length()) || (this.toString().Equals(ms1.toString()) ) )   //мои вкусы очень специфичны
                return true;
            return false;
        }

        public static Boolean operator !=(MyString ms1, MyString ms2)
        {
            if (ms1.Equals(ms2))
                return false;
            return true;
        }
        public static Boolean operator ==(MyString ms1, MyString ms2)
        {
            if (ms1.Equals(ms2))
                return true;
            return false;
        } 

        public void Print()
        {
            Console.WriteLine(text);
        }

        public string toString()
        {
            return new string(text);
        }

        public bool IsNullOrEmpty()
        {
            return text == null || text.Length == 0;
        }

        public void Replace(char old, char to)
        {
            if (IsNullOrEmpty())
                return;

            for (int i = 0; i < text.Length; i++)
            {
                if (old.Equals(text[i]))
                    text[i] = to;
            }
        }

        public int Length()
        {
            return text.Length;
        }
    }
}