// C# program to calculate the area
// of a square using the concept of
// data abstraction
using System;

namespace Demoabstraction
{
    abstract class Customer
    {
        public void Print()
        {
            Console.WriteLine("Print Method");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer(); // ** We can't create an instance of the abstract class!
            c.Print();

        }
    }
}