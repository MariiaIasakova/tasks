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
            Console.WriteLine("Введите первую строку:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку:");
            string str2 = Console.ReadLine();
            string str3 = AnalisString(str1, str2);
            Console.WriteLine("Результирующая строка: \n\r"+str3);
            Console.ReadKey();
        }

        private static string AnalisString(string str1, string str2)
        {
            string str3 = "";
            if (!(String.IsNullOrEmpty(str1) || String.IsNullOrEmpty(str2)))
            {
                foreach (char symbol in str1)
                {
                    if (!(str2.Contains(symbol)))
                    {
                        str3 += symbol;
                    }
                    else
                    {
                        str3 += symbol;
                        str3 += symbol;
                    }
                }
            }
            return str3;
        }
    }
}
