// C# program to calculate the area
// of a square using the concept of
// data abstraction
using System;

namespace Demoabstraction
{
    abstract class Car
    {
        public void Run()
        {
            Console.WriteLine("display");
        }


        //** A method cannot have a body which is marked as abstract. Below is the correct declaration. The class derived from it will implement the engine method which is abstract.
        //public abstract void engine()
        //{
        //    Console.WriteLine("1000 cc");
        //}


        public abstract void engine();
    }

    //** Honda class, engine method needs to have override keyword at it's in base class abstract

    class Honda : Car
    {
        public override void engine()
        {
            Console.WriteLine("1000 cc");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Honda();
            c.engine();
            c.Run();
        }
    }
}