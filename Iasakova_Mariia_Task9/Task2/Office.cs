using System;

namespace Task2
{
    class PersonEventArgs : EventArgs
    {
        public DateTime Time { get; set; }



        public PersonEventArgs(DateTime time)
        {
            Time = time;
        }
    }
    class Office
    {
        //public delegate void GreetingOffice2(Person name, PersonEventArgs args);
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
                //OnCome2(name, new PersonEventArgs(DateTime.Now));
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
