using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person John = new Person()
            {
                Name = "Джон"
            };
            Person Bill = new Person()
            {
                Name = "Билл"
            };
            Person Hugo = new Person()
            {
                Name = "Хьюго"
            };

            Office office = new Office();
            office.SomebodyCome(John, DateTime.Now);
            office.OnCome += John.Greeting;
            Console.WriteLine();

            office.SomebodyCome(Bill, DateTime.Now);
            office.OnCome += Bill.Greeting;
            office.OnLeave += Bill.Farewell;
            Console.WriteLine();

            office.SomebodyCome(Hugo, DateTime.Now);
            office.OnCome += Hugo.Greeting;
            office.OnLeave += Hugo.Farewell;
            Console.WriteLine();

            office.OnLeave -= John.Farewell;
            office.SomebodyLeave(John);
            Console.WriteLine();

            office.OnLeave -= Bill.Farewell;
            office.SomebodyLeave(Bill);
            Console.WriteLine();

            office.OnLeave -= Hugo.Farewell;
            office.SomebodyLeave(Hugo);

            Console.ReadKey();
        }
    }
}
