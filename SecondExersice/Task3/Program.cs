using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            int[] array = new int[10];
            FillArray(array);
            int sum = SearchElements(array);
            Console.WriteLine("Cумма неотрицательных элементов:" + sum);
            Console.ReadKey();
        }
        static int SearchElements(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                if (i<0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 50);
            }
        }
    }
}
