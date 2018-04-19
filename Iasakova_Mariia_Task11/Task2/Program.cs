using System;
using System.Collections.Generic;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string mainPath = "C:\\Users\\user\\Desktop\\repos\\tasks\\Iasakova_Mariia_Task11";
            string path = "C:\\Users\\user\\Desktop\\repos\\tasks\\Iasakova_Mariia_Task11\\Editable folder";
            Console.WriteLine("Watch the folder / rollback changes? 1/2");
            var observe = new Observation(mainPath, path);
            char key;
            do
            {
                key = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (key)
                {
                    case '1':
                        observe.StartObservation();
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        observe.EndObservation();
                        break;
                    case '2':
                        List<string> dateTimes = observe.WriteCopies();
                        foreach (var items in dateTimes)
                        {
                            Console.WriteLine(items);
                        }
                        var dateAndTimeOfNeedChange = TestValue(mainPath);
                        observe.RollbackChanges(dateAndTimeOfNeedChange);
                        break;
                    default:
                        throw new ArgumentException("Entered the wrong value");
                }

                Console.WriteLine();
                Console.WriteLine("Watch the folder / rollback changes? 1/2");

            } while (key != 'q');
        }

        public static string TestValue(string mainPath)
        {
            Console.WriteLine("Enter the date and time of change as displayed");
            var dateAndTimeOfNeedChange = Console.ReadLine().Trim();
            var pathDir = Path.Combine(mainPath, dateAndTimeOfNeedChange);
            if (Directory.Exists(pathDir))
            {
                Console.WriteLine("Entered the wrong value");
                TestValue(mainPath);
            }
            return dateAndTimeOfNeedChange;
        }
    }
}
