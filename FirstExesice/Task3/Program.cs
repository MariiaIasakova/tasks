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
            var sum=0;
            for (int i=0; i<1000; i++)
            {
                var value1 = i%3;
                var value2 = i%5;
                if (value1==0 || value2==0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
