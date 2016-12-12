namespace Task2
{
    using System;

    public class MyEventArgs : EventArgs
    {
        public MyEventArgs(DateTime date) : base()
        {
            Date = date;
        }

        public DateTime Date { get; set; }
    }
}
