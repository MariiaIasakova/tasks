using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Round
    {
        protected static double x, y;
        protected double r = 10;
        public Round(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                if (!Double.IsNaN(value))
                {
                    x = value;
                }
                else
                {
                    throw new ArgumentException("field cannot be empty");
                }
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                if (!Double.IsNaN(value))
                {
                    x = value;
                }
                else
                {
                    throw new ArgumentException("field cannot be empty");
                }
            }
        }
        public double SqrRound
        {
            get
            {
                return Math.PI * r * r;
            }
        }

        public double LongRound
        {
            get
            {
                return 2 * Math.PI * r;
            }
        }

    }
}
