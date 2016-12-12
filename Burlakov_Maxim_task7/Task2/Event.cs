namespace Task2
{
    public delegate void Came(Person p, MyEventArgs e);

    public delegate void Escape(Person p);

    public class Event//todo тогда уж Events
    {
        public event Came came;//todo как то это на костыли очень сильно похоже. Тебе event здесь писать уже не надо, поскольку ты выше объявил делегат. Событие - это частный случай делегата. Либо ты прогаешь событиями, либо делегатами.

        public event Escape escape;

        public virtual void OnCame(Person p, MyEventArgs date)
        {
            if (came != null)
            {
                came(p, date);
            }
        }

        public virtual void OnEscape(Person p)
        {
            if (escape != null)
            {
                escape(p);
            }
        }
    }
}
