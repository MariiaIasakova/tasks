using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public static class TestValues
    {
        public static string TestNullOrEmpty(string value)
        {
            value = value.Trim();
            if (!String.IsNullOrEmpty(value))
            {
                return value;
            }
            else
            {
                throw new ArgumentException("marked fields cannot be empty");
            }
        }
        public static DateTime TestMoreOrEmpty (DateTime value)
        {
            if (value < DateTime.Now || value != default(DateTime))
            {
                return value;
            }
            else
            {
                throw new ArgumentException("date cannot be empty or more than today's date");
            }
        }
        public static double TestDayAndMonth (DateTime date)
        {
            DateTime dateNow = DateTime.Now;
            if (date != null)
            {
                if (date.Month > dateNow.Month || date.Month == dateNow.Month && date.Day > dateNow.Day)
                {
                    return dateNow.Year - date.Year - 1;
                }
                else
                {
                    return dateNow.Year - date.Year;
                }
            }
            else
            {
                throw new ArgumentException("feild of date cannot be get");
            }
        }
        public static double TestNan (double value)
        {
            if (!Double.IsNaN(value))
            {
                return value;
            }
            else
            {
                throw new ArgumentException("field cannot be empty");
            }
        }
    }
}
