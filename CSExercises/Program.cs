// C# program to calculate the area
// of a square using the concept of
// data abstraction
using System;

namespace Demoabstraction
{

    // How to find if a positive integer is a prime number or not?
    public class Solution
    {
        public static bool IsPrime(int number)
        {
            if (number == 0) return false;
            if (number == 1) return false;
            if (number % 2 == 0) return false;

            var squareRoot = (int)Math.Floor(Math.Sqrt(number));

            for(int i = 3; i < squareRoot; i+=2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            string newNumber = Console.ReadLine();
            if (IsPrime(Convert.ToInt32(newNumber)))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}