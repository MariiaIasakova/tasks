using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        private double a, b, c;
        public Triangle(double a, double b, double c)
        {
            if (a+b > c && a+c > b && b+c > a)
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                throw new ArgumentException("incorrect value of the side");
            }
        }
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public double SqrTringle()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double PerTringle()
        {
            return a + b + c;
        }
    }
}
