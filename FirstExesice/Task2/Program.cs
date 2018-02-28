using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВВедите количество строк: ");
            var num = int.Parse(Console.ReadLine());
            var number = 1;
            for (int j = 0; j < num; j++)
            {
                for (int i = 0; i<number ; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
                number++;   
            }
            Console.ReadKey();
        }
    }
}
