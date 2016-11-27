namespace task1
{
    using System;
    class User
    {
        private string firstname;
        private string lastname;
        private string patronymic;
        private DateTime birthday;
        private int age;

        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                if (value == string.Empty)
                    throw new Exception("Имя не может быть пустым");
                firstname = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                if (value == string.Empty)
                    throw new Exception("Фамилия не может быть пустой");
                lastname = value;
            }
        }
        public string Patronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                if (value == string.Empty)
                    throw new Exception("Отчество не может быть пустым");
                patronymic = value;
            }
        }
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Возраст должен быть положительным!");
                }
                age = value;
            }
        }
        public User(string firstname, string lastname, string patronymic, DateTime birthday)
        {
            FirstName = firstname;
            LastName = lastname;
            Patronymic = patronymic;
            Birthday = birthday;
            //конструкция ниже вычисляет возраст, учитывая дату рождения и дату сейчас
            DateTime dateNow = DateTime.Now;    //дата сегодня
            int year = dateNow.Year - birthday.Year;
            if (dateNow.Month < birthday.Month ||
                (dateNow.Month == birthday.Month && dateNow.Day < birthday.Day)) year--;
            Age = year;

        }
    }
}
