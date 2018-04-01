using System.Threading;
using Sort;

namespace Sort
{
    public class StartThread
    {
        public delegate void EndSort( int number);
        public event EndSort OnEndSort;

        public void StartThreads(SortArray sortArray, int number)
        {
            Thread t = new Thread(x => sortArray.SortArr());
            t.Start();
            t.Join();
            if (!t.IsAlive)
            {
                OnEndSort(number);
            }
        }
    }
}
