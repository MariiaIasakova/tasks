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
            var hash = new List<int>();
            for (var i = 0; i < 1000; i++)
            {
                for (var j = 0; j < 1000; j++)
                {
                    var point = new TwoDPointWithHash(i, j);
                    hash.Add(point.GetHashCode());
                }
            }

            Console.WriteLine($"All count {hash.Count}");
            var unique = hash.Distinct().ToList();
            Console.WriteLine($"Unique count {unique.Count}");
            var theSameCount = hash.Count - unique.Count;
            Console.WriteLine($"The same count {theSameCount}");
            Console.WriteLine($"percent {(double)((double)theSameCount * 100 / (double)hash.Count)}");

            Console.ReadKey();
        }
    }
}
