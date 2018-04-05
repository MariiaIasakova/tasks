using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class TwoDPointWithHash : TwoDPoint
    {
        public TwoDPointWithHash(int x, int y) : base(x, y)
        { }

        public override int GetHashCode()
        {
            return ShiftAndWrap(x.GetHashCode(), 2) ^ y.GetHashCode();
        }

        public int ShiftAndWrap(int value, int positions)
        {
            positions = positions & 0x1F;

            uint number = BitConverter.ToUInt32(BitConverter.GetBytes(value), 0);

            uint wrapped = number >> (32 - positions);

            return BitConverter.ToInt32(BitConverter.GetBytes((number << positions) | wrapped), 0);
        }
    }
}
