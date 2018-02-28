using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("ВВедите количество строк: ");
                var size = int.Parse(Console.ReadLine());
                WhithdrawPiramid(size);
                Console.ReadKey();
        }

        private static void WhithdrawPiramid(int quantity)
        {
            for (int i=0; i<quantity; i++)
            {
                var NumberChar = 1;
                var NumberSpace = quantity / 2 + 1;
                for (int j = 0; j <= i; j++)
                {
                  string str1 = new string('*', NumberChar);
                  string str2 = new string(' ', NumberSpace);
                  Console.WriteLine("{0}{1}\n", str2, str1);
                  NumberChar += 2;
                    if (NumberSpace > 0)
                    {
                        NumberSpace--;
                    }
                }
            }
        }
    }
}
