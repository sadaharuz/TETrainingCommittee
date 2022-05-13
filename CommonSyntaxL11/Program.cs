using System;
using System.Collections.Generic;

namespace CommonSyntaxL11
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> firstNames = new List<string>();

            //firstNames.Add("Tim");
            //firstNames.Add("Sue");
            //firstNames.Add("Bob");
            //firstNames.Add("Dan");

            //foreach (string name in firstNames)
            //{
            //    Console.WriteLine(name);
            //}

            Dictionary<int, string> importantYears = new Dictionary<int, string>();

            importantYears.Add(1492, "Columbus arrives in Central America");
            importantYears.Add(1969, "Man walks on the moon");
            importantYears.Add(1978, "Tim is born");

            foreach (var year in importantYears)
            {
                Console.WriteLine($"{ year.Key }: { year.Value }");
            }

            Console.ReadLine();
        }
    }
}