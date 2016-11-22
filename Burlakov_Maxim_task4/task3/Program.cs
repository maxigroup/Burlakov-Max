namespace task3
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
            Console.WriteLine("Программа для задания 3");
            bool finish = false;
            while (!finish)
            {
                User person1;
                string firstname;
                string lastname;
                string patronymic;
                DateTime birthday;
                try
                {
                    Console.WriteLine("Введите имя: ");
                    firstname = Console.ReadLine();
                    Console.WriteLine("Введите фамилию: ");
                    lastname = Console.ReadLine();
                    Console.WriteLine("Введите отчество: ");
                    patronymic = Console.ReadLine();
                    Console.WriteLine("Введите дату рождения в формате yyyy/mm/dd: ");
                    birthday = Convert.ToDateTime(Console.ReadLine());
                    person1 = new User(firstname, lastname, patronymic, birthday);
                }
                catch
                {
                    Console.WriteLine("Введены некорректные данные, загружены данные по умолчанию");
                    firstname = "Нонейм";
                    lastname = "Нонеймов";
                    patronymic = "Нонеймович";
                    birthday = new DateTime(1991, 11, 19);
                    person1 = new User(firstname, lastname, patronymic, birthday);
                }
                //не записывается имя при создании экземпляра, не могу понять почему
                Console.WriteLine("Данные пользователя:\n {0}\n {1}\n {2}\n Дата рождения: {3}\n Возраст: {4}"
                    ,person1.LastName,person1.FirstName,person1.Patronymic,person1.Birthday,person1.Age);

                Console.WriteLine("Повторить? д/н");
                string ans = Console.ReadLine();
                if (ans == "н") return;           //если нет то завершаем программу
            }
        }
    }
}