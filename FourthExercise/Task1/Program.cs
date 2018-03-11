using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class User
    {
        public string name, family, patronymic, datebth;
        public byte age;

        public void WriteInConsoleInfo(string family, string name, string patronymic, string datebth, byte age)
        {
            Console.WriteLine(" Фамилия: {0}\n Имя: {1}\n Отчество: {2}\n Дата рождения: {3}\n Возраст: {4}\n", family, name, patronymic, datebth, age);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            User myInfo = new User
            {
                name = "Мария",
                patronymic = "Дмитриевна",
                family = "Иванова",
                datebth = "12.01.1994",
                age = 24
            };

            User anotherInfo = new User
            {
                name = "Филлип",
                patronymic = "Бедросович",
                family = "Киркоров",
                datebth = "23.06.1990",
                age = 27
            };

            myInfo.WriteInConsoleInfo(myInfo.family, myInfo.name, myInfo.patronymic, myInfo.datebth, myInfo.age);
            anotherInfo.WriteInConsoleInfo(anotherInfo.family, anotherInfo.name, anotherInfo.patronymic, anotherInfo.datebth, anotherInfo.age);

            Console.ReadLine();
        }
    }

}
