using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sort
{
    delegate bool CompareValue(string a, string b);

    public class SortArray
    {
        private string[] arr;
        string a;

        public SortArray(string[] _arr, string _a)
        {
            arr = _arr;
            a = _a;
        }

        public void SortArr()
        {
            CompareValue compare = new CompareValue(CompareAscByAlfabet);
            if (a == "a")
            {
                arr = arr.OrderBy(item => item.Length).ToArray();
            }
            else if (a == "d")
            {
                arr = arr.OrderByDescending(item => item.Length).ToArray();
                compare = new CompareValue(CompareDscByAlfabet);
            }
            else
            {
                throw new ArgumentException("the value may be only a or d");
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (compare(arr[j], arr[j + 1]))
                    {
                        string s = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = s;
                    }
                }
            }
        }

        static bool CompareAscByAlfabet(string s1, string s2)
        {
            if (s1.Length == s2.Length)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] < s2[i])
                    {
                        return false;
                    }
                    if (s1[i] > s2[i])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static bool CompareDscByAlfabet(string s1, string s2)
        {
            if (s1.Length == s2.Length)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1.ToCharArray()[i] < s2.ToCharArray()[i])
                    {
                        return true;
                    }
                    if (s1.ToCharArray()[i] > s2.ToCharArray()[i])
                    {
                        return false;
                    }
                }
            }
            return false;
        }
        public void EndSort(int number)
        {
            Console.WriteLine("The end of sort thread {0}", number);
        }
    }
}
