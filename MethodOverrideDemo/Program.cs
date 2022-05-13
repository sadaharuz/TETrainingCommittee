using System;

namespace MethodOverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel
            {
                FirstName = "Tim",
                LastName = "Corey",
                Email = "tim@iamtimcorey.com"
            };

            Console.WriteLine(person);

            Console.ReadLine();
        }
    }
}