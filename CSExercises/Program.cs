// C# program to calculate the area
// of a square using the concept of
// data abstraction
using System;

namespace Demoabstraction
{

	//   Find Sum of Digits of a Number
	public class Solution
	{
		public static void Main()
		{
			int inputNumber = 9845;

			Console.WriteLine("Input Numb : " + inputNumber);
			Console.WriteLine("Sum of Digits : " + SumOfDigits(inputNumber));
			Console.WriteLine("Sum of Digits using Recursion: " + DigitSumRecursion(inputNumber));
		}

		public static int SumOfDigits(int inputNumber)
		{
			int sum = 0;
			while (inputNumber > 0)
			{
				sum += inputNumber % 10;
				inputNumber /= 10;
			}
			return sum;
		}

		public static int DigitSumRecursion(int inputNumber)
		{
			if (inputNumber != 0)
			{
				return (inputNumber % 10 + DigitSumRecursion(inputNumber / 10));
			}
			else
			{
				return 0;
			}
		}
	}
}