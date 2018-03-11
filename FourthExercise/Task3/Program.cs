using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        public double a, b, c;

        public double SqrTringle()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double PerTringle()
        {
            return a + b + c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle triangle = new Triangle();
                string s = "";
                Console.WriteLine("Введите длину стороны a:");
                triangle.a = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введите длину стороны b:");
                triangle.b = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введите длину стороны c:");
                triangle.c = Double.Parse(Console.ReadLine());
                Console.WriteLine("Вычислить площадь или периметр треугольника? s/p:");
                s = Console.ReadLine();
                s = s.ToLower();
                WriteResult(triangle, s);
                Console.ReadKey();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Не заполнено поле");
            }
            catch (FormatException)
            {
                Console.WriteLine("Не верно заполнено поле");
            }
        }

        public static void WriteResult(Triangle triangle, string s)
        {
            if (s == "s")
            {
                Console.WriteLine("Площадь треугольника равен {0}", triangle.SqrTringle());
            }
            else if (s == "p")
            {
                Console.WriteLine("Периметр равен {0}", triangle.PerTringle());
            }
            else
            {
                Console.WriteLine("Неверный символ");
            }
        }
    }
}
