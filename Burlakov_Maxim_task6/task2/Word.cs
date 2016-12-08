namespace task2
{
    public class Word
    {
        public int Count { get; set; }
        public string Value { get; set; }

        /// <summary>
        /// Слово, количество его вхождений
        /// </summary>
        /// <param name="word">Слово</param>
        /// <param name="count">Количество вхождений</param>
        public Word(string word, int count = 1)
        {
            Count = count;
            Value = word;
        }
    }
}
