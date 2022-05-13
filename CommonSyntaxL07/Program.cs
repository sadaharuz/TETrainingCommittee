using System;

namespace CommonSyntaxL07
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] firstNames = new string[5]; // 0, 1, 2, 3, 4

            //firstNames[0] = "Tim";
            //firstNames[1] = "Sue";
            //firstNames[2] = "Bob";
            //firstNames[4] = "Carl";

            //Console.WriteLine($"My array has { firstNames[0] }, { firstNames[1] }, { firstNames[2] }, { firstNames[4] }");

            //string data = "Tim,Sue,Bob,Frank,Sandra,Molly";
            //string[] firstNames = data.Split(',');

            //Console.WriteLine($"The seventh first name is { firstNames[6] }");

            //int[] ages = new int[3];
            //ages[0] = 4;
            //ages[1] = 5;
            //ages[2] = 54;

            string[] lastNames = new string[] { "Corey", "Smith", "Jones" };

            lastNames[1] = "Malcome";

            Console.ReadLine();
        }
    }
}