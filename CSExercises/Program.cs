// C# program to calculate the area
// of a square using the concept of
// data abstraction
using System;

namespace Demoabstraction
{

    // How to count the occurrence of each character in a string?
    public class Solution
    {

        public static void CharacterOccurrence(string p)
        {
            Dictionary<char, int> CharacterCounter = new Dictionary<char, int>();

            foreach (var character in p)
            {
                if (character != ' ')
                {
                    if (!CharacterCounter.ContainsKey(character))
                    {
                        CharacterCounter.Add(character, 1);
                    }
                    else
                    {
                        CharacterCounter[character]++;
                    }
                }
            }

            foreach (var character in CharacterCounter)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter string: ");
            string newString = Console.ReadLine();
            CharacterOccurrence(newString);
        }
    }
}