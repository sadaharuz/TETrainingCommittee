using System;
using System.Collections.Generic;

namespace CommonSyntaxL08
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstNames = new List<string>();

            firstNames.Add("Tim");
            firstNames.Add("Sue");
            firstNames.Add("Bob");

            Console.WriteLine($"The second element is { firstNames[1] }");

            firstNames.Remove("Sue");

            Console.WriteLine($"The second element is { firstNames[1] }");

            firstNames[1] = firstNames[1].ToUpper();

            Console.WriteLine($"The second element is { firstNames[1] }");

            Console.ReadLine();
        }
    }
}