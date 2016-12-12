namespace Task2
{
    public delegate void Came(Person p, MyEventArgs e);

    public delegate void Escape(Person p);

    public class Event
    {
        public event Came came;

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
