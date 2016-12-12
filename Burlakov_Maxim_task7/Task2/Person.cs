namespace Task2
{
    using System;

    public class Person
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == string.Empty)
                    throw new Exception("Имя не может быть пустым");
                name = value;
            }
        }

        public Event Evt { get; set; }

        public Person (string name)
        {
            Name = name;
            Evt = new Event();
        }

        public void Greeting(Person pers, MyEventArgs time)
        {
            if (pers.Name.Equals(Name)) //Сами с собой в офисе не здороваемся - провинция-с, не поймут-с
            {
                return;
            }

            string[] greetings = { "Привет", "Доброе утро", "Добрый день", "Добрый вечер" };
            int timeindex = 1;
            int intime = time.Date.Hour;
            while(timeindex*6 < intime)    
            {
                timeindex++;
            }

            Console.WriteLine("{0}, {1} - сказал {2}", greetings[timeindex-1], pers.Name, this.Name);
        }
        
        public void SayBye(Person pers)
        {
            if (pers.Name.Equals(Name))
            {
                return;
            }
            Console.WriteLine ("До свидания, {0}!, - сказал {1}", pers.Name, this.Name);
        }
    }
}
