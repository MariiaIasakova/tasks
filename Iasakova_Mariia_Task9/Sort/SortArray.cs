using System;
using System.Linq;

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
            if (a != "a" && a != "d")
            {
                throw new ArgumentException("the value may be only a or d");
            }
            else if (a == "d")
            {
                compare = new CompareValue(CompareDscByAlfabet);
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
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static bool CompareAscByAlfabet(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return (s1.Length > s2.Length);
            }
            else
            {
                return (string.Compare(s1, s2) > 0);
            }
        }

        static bool CompareDscByAlfabet(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return (s1.Length < s2.Length);
            }
            else
            {
                return (string.Compare(s1, s2) < 0);
            }
        }
        public void EndSort(int number)
        {
            Console.WriteLine("The end of sort thread {0}", number);

        }
    }
}
