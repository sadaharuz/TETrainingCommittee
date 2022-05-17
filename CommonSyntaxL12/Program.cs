using System;

namespace CommonSyntaxL12
{
    class Program
    {
        static void Main(string[] args)
        {
            SayAuthor();

            //WelcomeUser("John");

            string firstName = GetUsersName("What is your first name: ");
            string lastName = GetUsersName("What is your last name: ");

            WelcomeUser(firstName, lastName);

            Console.ReadLine();
        }
        private static void SayAuthor()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("Writen by: John Snow");
            Console.WriteLine("for the Foundation in C# course.");
            Console.WriteLine("*************************");
        }

        private static void WelcomeUser(string firstName, string lastName)
        {
            Console.WriteLine($"Hello { firstName } { lastName }");
        }

        private static string GetUsersName(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();

            return output;
        }
    }
}