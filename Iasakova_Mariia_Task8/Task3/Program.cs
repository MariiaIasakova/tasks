using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "The VisuAl Studio interactive the sual development environment (IDE) is a " +
                "creative launching pad that you can use to view and edit nearly" +
                " any kind of code, and then debug, build, and publish apps for Android, iOS, Windows," +
                " the web, and the cloud. There are versions  available for Mac and Windows. This topic " +
                "introduces you to the features of the Visual Studio IDE." +
                " We'll walk through some things you can do with Visual Studio " +
                "and how to install and Use it, create a simple project," +
                " get pointers on debugging and deploying code, and take a tour " +
                "of the various tool windows";
            text = text.ToLower();
            Regex rgx1 = new Regex("[\\s\\p{P}]+", RegexOptions.IgnorePatternWhitespace);
            string[] strArray = rgx1.Split(text);
            strArray = strArray.Distinct(StringComparer.CurrentCultureIgnoreCase).ToArray();
            for ( int i = 0; i < strArray.Length; i++)
            {
                Regex rgx = new Regex("\\b" + @strArray[i] +"\\b");
                MatchCollection mach = rgx.Matches(text);

                Console.WriteLine("Найдено совпадений со словом {0}: {1}", strArray[i], mach.Count);
            }
            Console.ReadKey();
        }
    }
}
