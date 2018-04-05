using System;

namespace Task2
{
    class User
    {
        protected static string name, family, patronymic;
        protected static DateTime datebth;
        private int age;

        public User(string name, string family, string patronymic, DateTime datebth)
        {
            Name = name;
            Family = family;
            Patronymic = patronymic;
            Datebth = datebth;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("name cannot be empty");
                }
            }
        }
        public string Family
        {
            get
            {
                return family;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    family = value;
                }
                else
                {
                    throw new ArgumentException("family cannot be empty");
                }
            }
        }
        public string Patronymic { get; set; }
        public DateTime Datebth
        {
            get
            {
                return datebth;
            }
            set
            {
                if (value < DateTime.Now || value != null)
                {
                    datebth = value;
                }
                else
                {
                    throw new ArgumentException("date of birth cannot be empty or more than today's date");
                }
            }
        }
        public double Age
        {
            get
            {
                DateTime dateNow = DateTime.Now;
                if (datebth != null)
                {
                    if (datebth.Month > dateNow.Month || datebth.Month == dateNow.Month && datebth.Day > dateNow.Day)
                    {
                        age = dateNow.Year - datebth.Year - 1;
                    }
                    else
                    {
                        age = dateNow.Year - datebth.Year;
                    }
                    return age;
                }
                else
                {
                    throw new ArgumentException("age cannot be get, becouse date of birth is empty");
                }
            }
        }

    }
}