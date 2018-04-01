using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Office
    {
        public delegate void GreetingOffice(Person name, DateTime time);
        public delegate void FarewellOffice(Person name);
        public event GreetingOffice OnCome;
        public event FarewellOffice OnLeave;

        int peopleInOffice = 0;
        public void SomebodyCome(Person name, DateTime time)
        {
            Console.WriteLine("[{0} пришел в офис.]", name.Name);
            if (peopleInOffice > 0)
            {
                OnCome(name, time);
            }
            peopleInOffice++;
        }
        public void SomebodyLeave(Person name)
        {
            Console.WriteLine("[{0} ушел домой.]", name.Name);
            if (peopleInOffice > 1)
            {
                OnLeave(name);
            }
            peopleInOffice--;
        }
    }
}
