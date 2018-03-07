using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            char[] charArray = new char[] {',',' ','-','.','(',')','!','?','>','<','/','|','+','=','_',';', ':' };
            string[] strArray = str.Split(charArray, StringSplitOptions.RemoveEmptyEntries);
            int averegeLength1 = SearchAveregeLength(strArray);
            int averegeLength2 = strArray.Aggregate(0, (count, nextValue) => count += nextValue.Length) / strArray.Length;
            Console.WriteLine("Средняя длина слова в строке: " + averegeLength1);
            Console.WriteLine("Средняя длина слова в строке: " + averegeLength2);
            Console.ReadKey();
        }
        static int SearchAveregeLength (string[] strArray)
        {
            int i = 0, x = 0;
            foreach (string str in strArray)
            {
                x += str.Length;
                i++;
            }
            return x / strArray.Length;
        }
    }
}
