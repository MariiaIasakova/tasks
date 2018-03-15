using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class List : IIndexableSeries
    {
        private double[] series;
        private int currentIndex;

        public List(double[] series)
        {
            this.series = series;
            currentIndex = 0;
        }

        public double GetCurrent()
        {
            return series[currentIndex];
        }

        public bool MoveNext()
        {
            currentIndex = currentIndex < series.Length - 1 ? currentIndex + 1 : 0;
            return true;
        }

        public void Reset()
        {
            currentIndex = 0;
        }

        public double this[int index]
		{
			get{
                if (index <= series.Length - 1)
                {
                    return series[index];
                }
                else
                {
                    return 0;
                }
            }
		}
    }
}
