using System;
using Sort;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var strArray = new string[] { "saad", "av", "ad", "lds", "kdjfhgvn", "saab", "sjdcgs" };
            var strArray1 = new string[] { "saad", "av", "ad", "kdjfhgvn", "saab", "sjdcgs", "lslkdg" };
            Console.WriteLine("Sort by ascending or descending? a/d");
            string a = Console.ReadLine().Trim();
            SortArray sortArray1 = new SortArray(strArray, a);
            SortArray sortArray2 = new SortArray(strArray1, a);

            StartThread t1 = new StartThread();
            t1.OnEndSort += sortArray1.EndSort;
            t1.StartThreads(sortArray1, 1);
            StartThread t2 = new StartThread();
            t2.OnEndSort += sortArray2.EndSort;
            t2.StartThreads(sortArray2, 2);
            Console.ReadKey();
        }
    }
}
