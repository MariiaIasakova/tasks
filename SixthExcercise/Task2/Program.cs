using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public interface IIndexable
    {
        double this[int index] { get; }
    }

    public interface ISeries
    {
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }

    interface IIndexableSeries : ISeries, IIndexable
    {
    }

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
