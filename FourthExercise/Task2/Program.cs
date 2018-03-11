using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Round
    {
        public double x = 12, y = 15, r = 10;
        public double SqrRound()
        {
            return Math.PI * r * r;
        }

        public double LongRound()
        {
            return 2 * Math.PI * r;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            Console.WriteLine("Вычислить площадь или длину окружности? s/l:");
            s = Console.ReadLine();
            s = s.ToLower();
            WriteResult(s);
            Console.ReadKey();
        }
        public static void WriteResult(string s)
        {
            Round round = new Round();
            if (s == "s")
            {
                Console.WriteLine("Площадь круга равна {0}", round.SqrRound());
            }
            else if (s == "l")
            {
                Console.WriteLine("Длина окружности равна {0}", round.LongRound());
            }
            else
            {
                Console.WriteLine("Неверный символ");
            }
        }
    }
}
