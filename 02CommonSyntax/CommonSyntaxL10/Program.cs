using System;
using System.Collections.Generic;

namespace CommonSyntaxL10
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //string[] firstNames = new string[] { "John", "Sue", "Bob" };

            //for (int i = 0; i < firstNames.Length; i++)
            //{
            //    Console.WriteLine(firstNames[i]);
            //}

            List<string> lastNames = new List<string>();

            lastNames.Add("Snow");
            lastNames.Add("Smith");
            lastNames.Add("Jones");

            for (int i = 0; i < lastNames.Count; i++)
            {
                Console.WriteLine(lastNames[i]);
            }

            Console.ReadLine();
        }
    }
}