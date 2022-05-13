﻿using System;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = RequestData.GetAString("What is your first name: ");

            UserMessages.ApplicationStartMessage(firstName);

            double x = RequestData.GetADouble("Please enter your first number: ");
            double y = RequestData.GetADouble("Please enter your second number: ");

            double result = CalculateData.Add(x, y);

            UserMessages.PrintResultMessage($"The sum of { x } and { y } is { result }");

            Console.ReadLine();
        }
    }
}