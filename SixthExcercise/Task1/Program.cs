using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ISeries progression = new GeometricProgression(1,2);
            Console.WriteLine("Progression:");
            PrintSeries(progression);
            Console.ReadKey();
        }

        private static void PrintSeries(ISeries progression)
        {
            progression.Reset();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(progression.GetCurrent());
                progression.MoveNext();
            }
        }
    }
}
