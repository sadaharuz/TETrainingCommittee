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

            //if (firstName.ToLower() == "tim")
            //{
            //    Console.WriteLine("Welcome Mr. Corey");
            //}

            //if (firstName.ToLower() == "tim")
            //{
            //    Console.WriteLine("Hello Mr. Corey");
            //}
            //else
            //{
            //    Console.WriteLine("Hello other person.");
            //}

            //if (firstName.ToLower() == "tim")
            //{
            //    Console.WriteLine("Hello Mr. Corey");
            //}
            //else if (firstName.ToLower() == "sue")
            //{
            //    Console.WriteLine("Hello Mrs. Smith");
            //}
            //else
            //{
            //    Console.WriteLine("I don't know who you are.");
            //}

            //if (firstName.ToLower() == "tim" && lastName.ToLower() == "corey")
            //{
            //    Console.WriteLine("Hello professor");
            //}
            //else if (firstName.ToLower() == "tim")
            //{
            //    Console.WriteLine("Hello other Tim");
            //}

            //if (firstName.ToLower() == "tim" || firstName.ToLower() == "sue")
            //{
            //    Console.WriteLine($"Hello Professor { firstName }");
            //}
            //else
            //{
            //    Console.WriteLine("Hello Student");
            //}

            //if ((firstName.ToLower() == "tim" && lastName.ToLower() == "corey") 
            //    || (firstName.ToLower() == "sue" && lastName.ToLower() == "storm"))
            //{
            //    Console.WriteLine($"Hello Professor { lastName }");
            //}

            //if (firstName.ToLower() != "tim")
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
            //    case "tim":
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