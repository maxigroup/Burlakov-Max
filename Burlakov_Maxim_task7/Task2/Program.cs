namespace Task2
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для задания 2");

            var time = new MyEventArgs(DateTime.Now);   //Используем настоящее время
            var employees = new List<Person>            //Список работников
            {
                new Person("Джон"),
                new Person("Билл"),
                new Person("Хьюго")
            };
            var nowWorking = new List<Person> { };    //Список работников, находящихся на работе

            foreach (Person pers in employees)
            {
                nowWorking.Add(pers);
                Console.WriteLine("\n[На работу пришел {0}]", pers.Name);
                foreach (Person p in nowWorking)
                {
                    pers.Evt.came += p.Greeting;
                    pers.Evt.escape += p.SayBye;
                }

                pers.Evt.OnCame(pers, time);//todo но они же в разное время дня приходят по условию
            }

            nowWorking.Reverse();

            foreach (Person pers in nowWorking)
            {
                Console.WriteLine("\n[{0} ушел домой]", pers.Name);
                pers.Evt.escape -= pers.SayBye;
                pers.Evt.OnEscape(pers);
            }

            Console.ReadKey();
        }
    }
}
