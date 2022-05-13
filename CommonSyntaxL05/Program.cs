using System;

namespace CommonSyntaxL05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for the user's first name
            Console.Write("What is your first name: ");
            string firstName = Console.ReadLine();

            //Ask the user for their age(numeric value)
            Console.Write("What is your age: ");
            string ageText = Console.ReadLine();

            //Convert ageText to age(string to int)
            bool isValidAge = int.TryParse(ageText, out int age);

            if (isValidAge == false)
            {
                Console.WriteLine("That was not a valid age.");
                Console.ReadLine();
                return;
            }

            string formattedName = "";

            if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
            {
                formattedName = $"Professor { firstName }";
            }
            else
            {
                formattedName = firstName;
            }

            if (age < 21)
            {
                Console.WriteLine($"I recommend you wait { 21 - age } years to start this class { formattedName }");
            }
            else
            {
                Console.WriteLine($"Welcome to class { formattedName }");
            }

            Console.ReadLine();
        }
    }
}