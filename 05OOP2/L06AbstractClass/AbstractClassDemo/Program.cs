using System;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            

            Console.ReadLine();
        }
    }
    public abstract class Vehicle
    {
        public string VIN { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearManufactured { get; set; }
    }

    public class Car : Vehicle
    {
        public int NumberOfWheels { get; set; } = 4;
    }
}