using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            int N=0;
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Введите количество итераций");
            N = Int32.Parse(Console.ReadLine());

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            stopWatch.Stop();
            TimeSpan ts1 = stopWatch.Elapsed;
            Console.WriteLine("Время работы String: " + ts1);
            stopWatch.Restart();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            stopWatch.Stop();
            TimeSpan ts2 = stopWatch.Elapsed;
            Console.WriteLine("Время работы StringBuilder: " + ts2);
            Console.ReadKey();
        }
    }
}
