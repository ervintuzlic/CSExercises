// C# program to calculate the area
// of a square using the concept of
// data abstraction
using System;

namespace Demoabstraction
{

    //  Program To Find the No of Word in a String
    public class Solution
    {
        public static void Main()
        {
            Console.WriteLine("Input a string");
            string inputString = Console.ReadLine();

            Console.WriteLine("Word Counts With Split Function : " + WordCount(inputString));
            Console.WriteLine("Word Counts Without Split Function : " + WordCountWithoutSplitFunction(inputString));

        }

        public static int WordCount(string inputString)
        {
            string[] words = inputString.Split(' ');
            return words.Length;
        }

        public static int WordCountWithoutSplitFunction(string inputString)
        {
            int wordCount = 1;
            char[] charArray = inputString.Trim().ToCharArray();

            foreach (char item in charArray)
            {
                if (item == ' ')
                    wordCount = wordCount + 1;
            }
            return wordCount;
        }
    }
}