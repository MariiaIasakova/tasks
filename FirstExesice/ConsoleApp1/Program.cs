using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВВедите значение стороны a:");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("ВВедите значение стороны b:");
            var b = int.Parse(Console.ReadLine());
            if (a<=0||b<=0)
            {
                Console.WriteLine("Введены некорректные числа");

            }
            else
            {
                var sum = a * b;
                Console.WriteLine("Площадь: {0}", sum);
            }
            Console.ReadKey();

        }
    }
}
