using System;
using System.Collections.Generic;
using ConsoleUI.OOP01.L5Namespace.Models;

namespace ConsoleUI.OOP01.L5Namespace
{
    public static class Namespace
    {
        public static void Run()
        {
            List<PersonModel3> people = new List<PersonModel3>();
            Console.WriteLine();

            PersonModel3 person = new PersonModel3();

            Calculations.Add(4, 3);

            Console.ReadLine();
        }
    }
}