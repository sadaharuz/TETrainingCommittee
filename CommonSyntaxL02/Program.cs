using System;

namespace CommonSyntaxL02
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string lastName = "";
            string fullName = "";

            firstName = "John";
            lastName = "Snow";

            // $ is for string interpolation
            fullName = $"{ firstName } { lastName }";

            string fileName = "";

            // @ is for string literals
            fileName = @"C:\Temp\Test.txt";

            // Whole number
            int age = 0;

            age = 10;
            age = 20;
            age = -23;

            int numberOfApplesTotal = 450;
            int numberOfApplesIAte = 50;

            Console.WriteLine(numberOfApplesTotal - numberOfApplesIAte);

            string zipCode = "00411-4125";

            Console.WriteLine(zipCode);

            // Use double for all numbers that include fractions except for money
            double averageWordsPerMinute = 34.24;

            // Use decimal for money
            decimal costPerContainer = 43.85M;

            // Stores only true or false
            bool isAlive = false;

            //Console.WriteLine(fullName);

            Console.ReadLine();
        }
    }
}