using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВВедите количество строк: ");
            var num = int.Parse(Console.ReadLine());
            var number = (num - 1) / 2;
            for (int j = 0; j < num; j++)
            {
                for (int i = 0; i < num; i++)
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
