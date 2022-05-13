using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Congratulations!");
            Console.Write(" ");
            Console.WriteLine("You wrote your first lines of code!");
            int number = 1;
            string text1 = "hello";
            string text2 = "world";
            double price = 1.00;
            float price2 = 1f;
            decimal price3 = 1.00M;

            double d = 0.42e2;
            Console.WriteLine(d);  // output 42

            float f = 134.45E-2f;
            Console.WriteLine(f);  // output: 1.3445

            decimal m = 1.5E6m;
            Console.WriteLine(m);  // output: 1500000

            Console.WriteLine($"{text1} {text2}!");
            var text3 = "one";
            //text3 = 1;
            dynamic text4 = "two";
            text4 = 2;
            object text5 = "three";
            text5 = 3;
            text5 = 1.00;
            // You need to do an explicit type casting every time you want to get the value back and forth.
            object a = "Ratakarn";
            string a1 = a.ToString();
            string c = "Ratakarn";
            object c1 = c;
            // this line is error cannot convert 'string' to 'int'
            //int d = (int)c1;

            //  In a dynamic variable, the compiler doesn't have any information about the type of variable.
            dynamic b = "Ratakarn";
            string b1 = b;

            //String interpolation
            ///summary
            Console.WriteLine($"{text3.GetType()} {text3}!");
            Console.WriteLine($"{text4.GetType()} {text4}!");
            Console.WriteLine($"{text5.GetType()} {text5}!");

            int counter = 100;
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine($"Count counter: {i}");
            }
            int[] percentage = Enumerable.Range(0, 100).ToArray();
            foreach (var i in percentage)
            {
                Console.WriteLine($"Count percentage: {i}");
            }

        }
    }
}
