using System;

namespace CommonSyntaxL06
{
    class Program
    {
        static void Main(string[] args)
        {
            //string continueResult = "";

            //do // One or more times
            //{
            //    Console.Write("What is your first name: ");
            //    string firstName = Console.ReadLine();

            //    Console.WriteLine($"Hello { firstName }");

            //    Console.Write("Do you want to continue (yes/no): ");
            //    continueResult = Console.ReadLine();
            //} while (continueResult.ToLower() == "yes");

            Console.Write("What is your age: ");
            string ageText = Console.ReadLine();

            bool isValidAge = int.TryParse(ageText, out int age);

            while (isValidAge == false) // Runs 0 or more times
            {
                Console.WriteLine("That was an invalid age. Please try again.");

                Console.Write("What is your age: ");
                ageText = Console.ReadLine();

                isValidAge = int.TryParse(ageText, out age);
            }

            Console.WriteLine($"Your age in 10 years will be { age + 10}");

            Console.ReadLine();
        }
    }
}