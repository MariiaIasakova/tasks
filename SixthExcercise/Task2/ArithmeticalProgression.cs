using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ArithmeticalProgression : IIndexableSeries
    {
        double start, step;
        int currentIndex;

        public ArithmeticalProgression(double start, double step)
        {
            this.start = start;
            this.step = step;
            this.currentIndex = 1;
        }

        public double GetCurrent()
        {
            return start + step * currentIndex;
        }

        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 1;
        }

        public double this[int index]
        {
            get
            {
                return start + step * index;
            }
        }
    }
}
