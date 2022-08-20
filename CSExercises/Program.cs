// C# program to calculate the area
// of a square using the concept of
// data abstraction
using System;

namespace Demoabstraction
{
    abstract class Database
    {
        public virtual void connect()
        {
            Console.WriteLine("Connect");
        }
        public abstract void configure();

    }

    class SQLServer : Database
    {

        //** Missing override 
        public override void connect()
        {
            Console.WriteLine("Connect SQL Server");
        }

        public override void configure()
        {
            Console.WriteLine("Configure database");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Database db = new SQLServer();
            db.configure();
            db.connect();

        }
    }
}