using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of people:");
            Int32.TryParse(Console.ReadLine(), out int number);

            var list2 = new LinkedList<int>();
            AddItem(list2, number);
            RemoveEachSecondItem(list2);

            var list1 = new List<int>();
            AddItem(list1, number);
            RemoveEachSecondItem(list1);

            Console.ReadKey();
        }

        public static void AddItem(ICollection<int> list, int number)
        {
            for (int i = 1; i <= number; i++)
            {
                list.Add(i);
            }
        }

        public static void RemoveEachSecondItem<T>(ICollection<T> list)
        {
            bool delete = false;
            int prom = 0;
            int iter = 0;
            while (list.Count > 1)
            {
                int j = 0;
                List<T> arr = new List<T>();
                if (iter != 0)
                {
                    if (prom % 2 == 0)
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (i % 2 == 0 || i == 0)
                            {
                                arr.Add(list.ElementAt(i));
                                j++;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (i % 2 != 0 || i != 0)
                            {
                                arr.Add(list.ElementAt(i));
                                j++;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i % 2 != 0)
                        {
                            arr.Add(list.ElementAt(i));
                            j++;
                        }
                    }
                }
                prom = j - 1;
                j = 0;
                for (int i = 0; i < list.Count;)
                {
                    if (delete)
                    {
                        list.Remove(arr[j]);
                        j++;
                    }
                    else
                    {
                        i++;
                    }
                    delete = !delete;
                }
                iter++;
            }
        }
    }
}
