using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var formCount = 1;
            string mainPath = "C:\Users\user\Desktop\repos\tasks\Iasakova_Mariia_Task11";
            string path = "C:\Users\user\Desktop\repos\tasks\Iasakova_Mariia_Task11\Editable folder";
            Console.WriteLine("Watch the folder / rollback changes / end watching ? 1/2/3");
            var value = Console.ReadLine().Trim();
            var observe = new Observation(mainPath, path, formCount);
            switch (value)
            {
                case "1":
                    observe.StartObservation();
                    formCount++;
                    break;
                case "2":
                    List<DateTime> dateTimes = observe.WriteCopies();
                    foreach (var items in dateTimes)
                    {
                        Console.WriteLine(items);
                    }
                    var dateAndTimeOfNeedChange = TestValue();
                    observe.RollbackChanges(dateAndTimeOfNeedChange);
                    break;
                case "3":
                    Console.WriteLine("Delete all versions with changes? Y/N");
                    var value1 = Console.ReadLine().Trim();
                    observe.EndObservation(value1);
                    break;
                default:
                    throw new ArgumentException("Entered the wrong value");
            }

            Main(args);
        }

        public static DateTime TestValue()
        {
            Console.WriteLine("Enter the date and time of change as displayed");
            if (!DateTime.TryParse(Console.ReadLine().Trim(), out DateTime dateAndTimeOfNeedChange))
            {
                Console.WriteLine("Entered the wrong value");
                TestValue();
            }
            return dateAndTimeOfNeedChange;
        }
    }
}
