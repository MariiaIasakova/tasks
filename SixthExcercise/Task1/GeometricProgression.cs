using System;
using LibraryTestValues;


namespace Task1
{
    class GeometricProgression : ISeries
    { 
        private double b, q;
        public int currentIndex;

        public GeometricProgression( double b, double q)
        {
            B = b;
            Q = q;
            this.currentIndex = 1;
        }
        public double B
        {
            set => b = TestValues.TestZeroAndEmpty(value);
        }
        public double Q
        {
            set => q = TestValues.TestZeroAndEmpty(value);
        }
        public double GetCurrent()
        {
            return (b * (Math.Pow(q, currentIndex - 1)));

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
    }
}
