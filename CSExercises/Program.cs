// C# program to calculate the area
// of a square using the concept of
// data abstraction
using System;

namespace Demoabstraction
{

    // How to reverse the order of words in a given string?
    public class Solution
    {

        public static string ReverseWord(string p)
        {
            string newWord = null;

            for(int i = p.Length - 1; i >= 0; i--)
            {
                newWord += p[i];
            }

            return newWord;
        }

        static void Main()
        {
            Console.WriteLine("Input a string: ");
            string Word = Console.ReadLine();
            string newWord = ReverseWord(Word);
            Console.WriteLine("This is the reversed word: " + newWord);

        }
    }
}