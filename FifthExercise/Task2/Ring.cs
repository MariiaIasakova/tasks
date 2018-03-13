using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Ring : Round
    {
        private double innerR, centerX, centerY;
        public Ring(double innerR) : base(x, y)
        {
            InnerR = innerR;
        }
        public double InnerR
        {
            get
            {
                return innerR;
            }
            set
            {
                if (value < r & !Double.IsNaN(value))
                {
                    innerR = value;
                }
                else
                {
                    throw new ArgumentException("inner radius cannot be less then outside or be empty");
                }
            }
        }
        public double SqrRing
        {
            get
            {
                return Math.PI * (r * r - innerR * innerR);
            }
        }
        public double SumLength
        {
            get
            {
                return LongRound + (Math.PI * innerR * 2);
            }
        }
    }
}
