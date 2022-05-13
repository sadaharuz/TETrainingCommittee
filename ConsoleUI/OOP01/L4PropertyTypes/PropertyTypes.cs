using System;

namespace ConsoleUI.OOP01.L4PropertyTypes
{
    public static class PropertyTypes
    {
        public static void Run()
        {
            PersonModel2 person = new PersonModel2("Corey");

            person.FirstName = "Tim";
            //person.LastName = "Corey";
            person.Age = 40;
            person.SSN = "123-45-6789";

            Console.WriteLine(person.FullName);
            Console.WriteLine(person.SSN);

            Console.ReadLine();
        }
    }
}