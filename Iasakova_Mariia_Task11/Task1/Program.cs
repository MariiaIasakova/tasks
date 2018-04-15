using System;
using System.Collections.Generic;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = "C:/Users/user/Desktop/repos/Iasakova_Mariia_Task11/disposable_task_file.txt";
            List<string> strList = new List<string>();
            try
            {
                using (StreamReader fileRead = File.OpenText(@path))
                {
                    while (fileRead.Peek() >= 0)
                    {
                        strList.Add(fileRead.ReadLine());
                    }
                }
                string[] strArray = strList.ToArray();
                int[] intArray = Increase(strArray);
                using (StreamWriter fileWrite = new StreamWriter(@path))
                {
                    foreach (int value in intArray)
                    {
                        // fileWrite.Write(value + "\r\n");
                        fileWrite.WriteLine(value);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }
        static int[] Increase(string[] strArray)
        {
            int[] intArray = new int[strArray.Length];
            int i = 0;
            foreach (string value in strArray)
            {
                if (int.TryParse(value, out int a))
                {
                    intArray[i] = a * a;
                    i++;
                }
            }
            return intArray;
        }
    }
}
