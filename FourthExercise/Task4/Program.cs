using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class MyString
    {
        public char[] strArray;

        public MyString(string str0)
        {
            if (!String.IsNullOrEmpty(str0))
            {
                strArray = str0.ToCharArray();
            }
            else
            {
                Console.WriteLine("Получено неверное значение");
            }
        }

        public override string ToString()
        {
            int i = 0;
            string str = "";
            foreach (char ch in strArray)
            {
                str += ch;
            }
            return str;
        }

        public static string operator +(MyString ms0, MyString ms1)
        {
            string finalStr = "";
            int i = 0;
            foreach (char ch in ms0.strArray)
            {
                finalStr += ms0.strArray[i];
                i++;
            }
            i = 0;
            foreach (char ch in ms1.strArray)
            {
                finalStr += ms1.strArray[i];
                i++;
            }
            return finalStr;
        }

        public static string operator -(MyString ms0, MyString ms1)
        {
            string finalStr = "";
            string str1 = ms0.ToString();
            string str2 = ms1.ToString();
            finalStr = str1.Replace(str2, " ");
            return finalStr;
        }

        public static bool operator ==(MyString ms0, MyString ms1)
        {
            bool result = false;
            for (int i = 0; i < Math.Min(ms0.strArray.Length, ms1.strArray.Length); i++)
            {
                if (ms0.strArray[i] == ms1.strArray[i])
                {
                    result = true;
                }
                else
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        public static bool operator !=(MyString ms0, MyString ms1)
        {
            bool result = false;
            for (int i = 0; i < Math.Min(ms0.strArray.Length, ms1.strArray.Length); i++)
            {
                if (ms0.strArray[i] == ms1.strArray[i])
                {
                    result = false;
                    break;
                }
                else
                {
                    result = true;
                }
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyString str0 = new MyString("привет, как дела?");
            MyString str1 = new MyString(" как");
            string str2 = str0 + str1;
            string str3 = str0 - str1;
            bool result = str0 == str1;
            str2 = str0.ToString();
        }
    }
}
