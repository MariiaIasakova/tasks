using System;


namespace Task2
{
    class Program
    {

        static void Main(string[] args)
        {
            IIndexableSeries progression = new ArithmeticalProgression(2, 2);
            Console.WriteLine("Progression:");
            PrintSeries(progression);

            IIndexableSeries list = new List(new double[] { 5, 8, 6, 3, 1 });
            Console.WriteLine("List:");
            PrintSeries(list);

            Console.ReadKey();
        }

        private static void PrintSeries(IIndexableSeries progression)
        {
            progression.Reset();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(progression[i]);
            }
        }
    }
}
