﻿using System;

namespace StaticClasses
{
    public static class UserMessages
    {
        public static void ApplicationStartMessage(string firstName)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Static Class Demo App");

            int hourOfDay = Datetime.Now.Hour;

            if (hourOfDay < 12)
            {
                Console.WriteLine($"Good morning { firstName }!");
            }
            else if (hourOfDay < 19)
            {
                Console.WriteLine($"Good afternoon { firstName }!");
            }
            else
            {
                Console.WriteLine($"Good evening { firstName }!");
            }
        }

        public static void PrintResultMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine("Thank you for using our app to caluclate for you.");
        }
    }
}