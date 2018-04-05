using System;
using ClassLibrary;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value for factorial:");
            var fact = int.Parse(Console.ReadLine());
            MathClass.Factorial(fact);
            Console.WriteLine("Enter the value for power:");
            var valPow = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the power:");
            var pow = int.Parse(Console.ReadLine());
            MathClass.Power(valPow, pow);
            Console.ReadKey();
        }
    }
}
