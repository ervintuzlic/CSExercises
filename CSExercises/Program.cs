// C# program to calculate the area
// of a square using the concept of
// data abstraction
using System;

namespace Demoabstraction
{

    // How to find if the given string is a palindrome or not?
    public class Solution
    {

        public static bool IsPalindrome(string p)
        {
            string newString = null;

            for(int i = p.Length-1; i >= 0; i--)
            {
                newString += p[i];
            }

            if (newString == p)
                return true;
            else 
                return false;
        }

        static void Main()
        {
            Console.WriteLine("Input a string: ");
            string palindrom = Console.ReadLine();
            if (IsPalindrome(palindrom))
                Console.WriteLine("It is palindrom");
            else
                Console.WriteLine("It isn't palindrom");
        }
    }
}