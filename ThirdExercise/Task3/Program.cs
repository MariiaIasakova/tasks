using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "en", str2 = "ru", str3 = "invariant";
            CultureInfo cultureRu = new CultureInfo("ru-RU");
            WriteData(cultureRu, str2);
            CultureInfo cultureEn = new CultureInfo("en-US");
            WriteData(cultureEn, str1);
            CultureInfo cultureInvar = CultureInfo.InvariantCulture;
            WriteData(cultureInvar, str3);
            Console.ReadKey();
        }
        static void WriteData(CultureInfo culture, string str)
        {
            double number = 21.4567;
            DateTime thisDate = DateTime.Now;
            Console.WriteLine("Дата и время, число " + str + "\n\r" + thisDate.ToString("d", culture));
            Console.WriteLine(number.ToString("F", culture));
        }
    }
}
