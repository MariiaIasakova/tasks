using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTestValues
{
    public static class TestValues
    {
        public static double TestZeroAndEmpty(double value)
        {
            if (value != 0 & !Double.IsNaN(value))
            {
                return value;
            }
            else
            {
                throw new ArgumentException("value of b cannot be zero or empty");
            }
        }
        public static int TestZero(int value)
        {
            if (value != 0)
            {
                return value;
            }
            else
            {
                throw new ArgumentException("number of members cannot be zero");
            }
        }
    }
}
