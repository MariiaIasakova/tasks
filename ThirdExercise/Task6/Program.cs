using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string number = Console.ReadLine();
            AnalisNumber(number);
            Console.ReadKey();
        }

        private static void AnalisNumber(string number)
        {
            if (!String.IsNullOrEmpty(number))
            {
                try
                {
                    double nmb = Double.Parse(number);
                    Regex regex = new Regex("e");
                    if (regex.IsMatch(number))
                    {
                        Console.WriteLine("Это число в научной нотации");
                    }
                    else
                    {
                        Console.WriteLine("Это число в обычной нотациии");
                    }
                }
                catch
                {
                    Console.WriteLine("Это не число!");
                }

            }
        }
    }
}
