using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Task1
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            int[] array = new int[10];
            FillArray(array);
            int max = SearchMax(array);
            Console.WriteLine("Максимальное значение: " + max); 
            int min = SearchMin(array);
            Console.WriteLine("Минимальное значение:" + min);
            SortArray(array);
            WriteArray(array);

            Console.ReadKey();
        }
        static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                    array[i] = random.Next(-50,50);
            }
        }
        static int SearchMax(int[] array)
        {
            int value = 0;
            for (int i = 0; i < array.Length; i++)
            {
                    if (value <= array[i])
                    {
                        value = array[i];
                    } 
            }
            return value;
        }
        static int SearchMin(int[] array)
        {
            int value = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                    if (value >= array[i])
                    {
                        value = array[i];
                    }
            }
            return value;
        }
        static void SortArray(int[] array)
        {
            int value = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                for(int j = i + 1 ; j < array.Length; j++ )
                {
                    if (array[i] > array[j])
                    {
                        value = array[i];
                        array[i] = array[j];
                        array[j] = value;
                    }
                }
                
            }
        }
        static void WriteArray(int[] array)
        {
            foreach(int value in array)
            {
                Console.Write(" " + value);
            }
        }

    }
}
