using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите HTML текст:");
            string str = Console.ReadLine();
            Console.WriteLine("Результат замены: " );
            ChangeSymbol(str);
            Console.ReadKey();
        }
        static void ChangeSymbol(string str)
        {
            string finalStr = "";
            if (!(String.IsNullOrEmpty(str)))
            {
                string[] strArray = str.Split(' ');
                string pattern = "<[^>]+>";
                foreach (string pstr in strArray)
                    Console.Write(Regex.Replace(pstr, pattern, "_"));
            }
        }
    }
}
