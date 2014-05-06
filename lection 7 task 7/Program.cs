//Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
using System;

namespace lection7task7
{
	class MainClass
	{
		public static void Main (string[] args)
		{


			Console.WriteLine ("enter number of members");
			int n = int.Parse (Console.ReadLine ());;
			int[] c = new int[n];
			int sum=1;
			c [0] = 0;
			c [1] = 1;
			for (int i = 2; i < n; i++) {
				c [i] = c [i - 1] + c [i - 2];
				sum += c [i];
			}
			Console.WriteLine (sum);
		}
	}
}
