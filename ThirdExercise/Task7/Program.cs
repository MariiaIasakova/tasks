using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();
            int i = AnalisText(text);
            Console.WriteLine("Время в тексте присутствует" + i + "раз");
        }

        private static int AnalisText(string text)
        {
            int i = 1;
            if (!String.IsNullOrEmpty(text))
            {
                Regex regex = new Regex("(([0,1][0-9])|(2[0-3])):[0-5][0-9]");
                if (regex.IsMatch(text))
                {
                    i++;
                }
                return i;
            }
            else
            {
                return 0;
            }
        }
    }
}
