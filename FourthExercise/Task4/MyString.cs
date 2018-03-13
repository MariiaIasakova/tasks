using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class MyString
    {
        char[] strArray;

        public MyString(string str0)
        {
            if (!String.IsNullOrEmpty(str0))
            {
                strArray = str0.ToCharArray();
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            MyString ms0 = obj as MyString;
            if (ms0 as MyString == null)
            {
                return false;
            }
            return ms0.strArray == this.strArray;

        }

        public override string ToString()
        {
            return new string(strArray);
        }

        public static MyString operator +(MyString ms0, MyString ms1)
        {
            string str1 = ms0.ToString();
            string str2 = ms1.ToString();
            return new MyString(str1 + str2);
        }

        public static MyString operator -(MyString ms0, MyString ms1)
        {
            string str1 = ms0.ToString();
            string str2 = ms1.ToString();
            return new MyString(str1.Replace(str2, " "));
        }

        public static bool operator ==(MyString ms0, MyString ms1)
        {
            string str1 = ms0.ToString();
            string str2 = ms1.ToString();
            return str1.Equals(str2);
        }

        public static bool operator !=(MyString ms0, MyString ms1) => !(ms0 == ms1);
    }
}
