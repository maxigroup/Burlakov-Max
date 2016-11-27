namespace task1
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
            Console.WriteLine("Программа для задания 1");
            bool finish = false;
            while (!finish)
            {
                Employee person1;
                string firstname;
                string lastname;
                string patronymic;
                DateTime birthday;
                string position;
                int workexp;    //Нам правда требуется проверка данных после каждой строки? =)
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
                    Console.WriteLine("Введите должность: ");
                    position = Console.ReadLine();
                    Console.WriteLine("Введите опыт работы(число лет): ");
                    workexp = Convert.ToInt32(Console.ReadLine());
                    person1 = new Employee(firstname, lastname, patronymic, birthday,workexp,position);
                }
                catch
                {
                    Console.WriteLine("Введены некорректные данные, загружены данные по умолчанию");
                    firstname = "Нонейм";
                    lastname = "Нонеймов";
                    patronymic = "Нонеймович";
                    birthday = new DateTime(1991, 11, 19);
                    position = "Тыжпрограммист";
                    workexp = 0;
                    person1 = new Employee(firstname, lastname, patronymic, birthday,workexp,position);
                }
                Console.WriteLine("Данные пользователя:\n{0}\n{1}\n{2}", 
                    person1.LastName, person1.FirstName, person1.Patronymic);
                Console.WriteLine("Дата рождения: {0}",person1.Birthday);
                Console.WriteLine("Возраст: {0}",person1.Age);
                Console.WriteLine("Должность: {0}",person1.Position);
                Console.WriteLine("Опыт работы: {0} лет", person1.WorkExp);

                Console.WriteLine("Повторить? д/н");
                string ans = Console.ReadLine();
                if (ans == "н") return;           //если нет то завершаем программу
            }
        }
    }
}