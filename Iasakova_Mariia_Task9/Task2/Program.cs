using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Office office = new Office();
            Person John = new Person()
            {
                Name = "Джон"
            };
            John.ComeInOffice += office.SomebodyCome;
            John.LeaveOffice += office.SomebodyLeave;

            Person Bill = new Person()
            {
                Name = "Билл"
            };
            Bill.ComeInOffice += office.SomebodyCome;
            Bill.LeaveOffice += office.SomebodyLeave;

            Person Hugo = new Person()
            {
                Name = "Хьюго"
            };
            Hugo.ComeInOffice += office.SomebodyCome;
            Hugo.LeaveOffice += office.SomebodyLeave;

            ComeInOffice(John, office);

            ComeInOffice(Bill, office);

            ComeInOffice(Hugo, office);

            LeaveOffice(John, office);

            LeaveOffice(Bill, office);

            LeaveOffice(Hugo, office);

            Console.ReadKey();
        }
        public static void ComeInOffice(Person person, Office office)
        {
            person.ComingInOffice(DateTime.Now);
            office.OnCome += person.Greeting;
            office.OnLeave += person.Farewell;
            Console.WriteLine();
        }

        public static void LeaveOffice(Person person, Office office)
        {
            office.OnLeave -= person.Farewell;
            office.OnCome -= person.Greeting;
            person.LeavingOffice();
            Console.WriteLine();
        }
    }
}
