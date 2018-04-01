using System;

namespace Task2
{
    public class Person
    {
        string name;

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
                    throw new ArgumentException("the name cannot be empty");
                }
            }
        }

        public void Greeting(Person _name, DateTime time)
        {
            if (_name.Name == null)
            {
                throw new ArgumentException("the name cannot be empty");
            }

            if (time.Hour < 12 )
            {
                Console.Write("Доброе утро, {0}!", _name.Name);
            }
            else if (12 <= time.Hour & time.Hour < 17)
            {
                Console.Write("Добрый день, {0}!", _name.Name);
            }
            else
            {
                Console.Write("Добрый вечер, {0}!", _name.Name);
            }
            Console.WriteLine(" - сказал {0}.", name);   
        }

        public void Farewell(Person _name)
        {
            Console.WriteLine("До свидания, {0}! - сказал {1}.", _name.Name, name);
        }

        
    }
}
