using System;
using System.Collections.Generic;

namespace CommonSyntaxL09
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> importantYears = new Dictionary<int, string>();

            importantYears[1492] = "Columbus dicovered the new world.";
            importantYears[1978] = "Tim is born.";
            importantYears[1969] = "Man walks on the moon.";

            Console.WriteLine($"In the year 1978, this happened: { importantYears[1978] }");

            Console.ReadLine();
        }
    }
}