namespace task1
{
    using System;
    class Employee : User
    {
        private int workexp;
        private string position;

        public int WorkExp
        {
            get
            {
                return workexp;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Опыт работы не может быть отрицательным");
                workexp = value;
            }
        }

        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                if (value == string.Empty)
                    throw new Exception("Должность не может быть пустой");
                position = value;
            }
        }
        public Employee(string firstname, string lastname, string patronymic, DateTime birthday, int workexp,string position) : base (firstname, lastname, patronymic, birthday)
        {
            WorkExp = workexp;
            Position = position;
        }
    }
}
