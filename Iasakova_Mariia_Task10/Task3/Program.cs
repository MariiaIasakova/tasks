using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoDPoint point1 = new TwoDPoint(1, 10);
            TwoDPoint point2 = new TwoDPoint(1, 10);

            Console.WriteLine("Hash for point1: {0}\tHash for point2: {1}", point1.GetHashCode(), point2.GetHashCode());

            TwoDPointWithHash newPoint1 = new TwoDPointWithHash(1, 1);
            TwoDPointWithHash newPoint2 = new TwoDPointWithHash(10, 10);

            Console.WriteLine("Hash for point1: {0}\tHash for point2: {1}", newPoint1.GetHashCode(), newPoint2.GetHashCode());

            // уникальных точек будет 2, хотя координаты их одинаковы
            Console.WriteLine("TwoDPointWithHash:");

            var twoDPointList = new List<TwoDPoint> { point1, point2 };
            var distinctTwoDPointList = twoDPointList.Distinct();
            foreach (var point in distinctTwoDPointList)
            {
                Console.WriteLine("Distinct point: {0}", point);
            }

            // одна уникальная точка
            Console.WriteLine("TwoDPointWithHash:");

            var twoDPointWithHashList = new List<TwoDPointWithHash> { newPoint1, newPoint2 };
            var distinctTwoDPointWithHashList = twoDPointWithHashList.Distinct();
            foreach (var point in distinctTwoDPointWithHashList)
            {
                Console.WriteLine("Distinct point: {0}", point);
            }

            Console.ReadKey();
        }
    }
}
