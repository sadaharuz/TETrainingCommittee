using System;

namespace CommonSyntaxL03
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";

            Console.Write("What is your first name: ");
            firstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            string lastName = Console.ReadLine();

            //if (firstName.ToLower() == "John")
            //{
            //    Console.WriteLine("Welcome Mr. Snow");
            //}

            //if (firstName.ToLower() == "John")
            //{
            //    Console.WriteLine("Hello Mr. Snow");
            //}
            //else
            //{
            //    Console.WriteLine("Hello other person.");
            //}

            //if (firstName.ToLower() == "John")
            //{
            //    Console.WriteLine("Hello Mr. Snow");
            //}
            //else if (firstName.ToLower() == "sue")
            //{
            //    Console.WriteLine("Hello Mrs. Smith");
            //}
            //else
            //{
            //    Console.WriteLine("I don't know who you are.");
            //}

            //if (firstName.ToLower() == "John" && lastName.ToLower() == "Snow")
            //{
            //    Console.WriteLine("Hello professor");
            //}
            //else if (firstName.ToLower() == "John")
            //{
            //    Console.WriteLine("Hello other John");
            //}

            //if (firstName.ToLower() == "John" || firstName.ToLower() == "sue")
            //{
            //    Console.WriteLine($"Hello Professor { firstName }");
            //}
            //else
            //{
            //    Console.WriteLine("Hello Student");
            //}

            //if ((firstName.ToLower() == "John" && lastName.ToLower() == "Snow") 
            //    || (firstName.ToLower() == "sue" && lastName.ToLower() == "storm"))
            //{
            //    Console.WriteLine($"Hello Professor { lastName }");
            //}

            //if (firstName.ToLower() != "John")
            //{

            //}

            //int age = 39;

            //if (age > 40)
            //{

            //}

            //if (age < 18)
            //{

            //}

            //if (age >= 21)
            //{

            //}

            //if (age <= 12)
            //{

            //}

            //switch (firstName.ToLower())
            //{
            //    case "John":
            //        Console.WriteLine("Hello Professor");
            //        break;
            //    case "sue":
            //        Console.WriteLine("Hello Professor Storm");
            //        break;
            //    default:
            //        Console.WriteLine("Hello student");
            //        break;
            //}

            Console.WriteLine("Application Done");

            Console.ReadLine();
        }
    }
}