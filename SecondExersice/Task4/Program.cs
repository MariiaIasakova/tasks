using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            int[,] array = new int[2, 2];
            FillArray(array);
            int sum = AdditionElements(array);
            Console.ReadKey();
        }

        private static int AdditionElements(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    {
                        if ((i+j)%2 == 0)
                        {
                            sum += array[i, j];
                        }
                    }
                }
            }
            return sum;
        }

        static void FillArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    {
                        array[i, j] = random.Next(10);
                    }
                }
            }

        }
    }
}
