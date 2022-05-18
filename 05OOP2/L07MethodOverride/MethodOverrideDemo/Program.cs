using System;

namespace MethodOverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel
            {
                FirstName = "John",
                LastName = "Snow",
                Email = "John.bunt@gmail.com"
            };

            Console.WriteLine(person);

            Console.ReadLine();
        }
    }
}