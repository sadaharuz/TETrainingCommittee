using System;
using AccesModifyDemoLibrary;

namespace AccessModifiersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.SavePerson();

            Console.ReadLine();
        }
    }
}