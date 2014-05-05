//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
using System;

namespace program5
{
	class MainClass
	{
		public static void Main (string[] args)
		{	int n,i;
			Console.WriteLine ("Enter number");
			n= int.Parse(Console.ReadLine ());
			for (i=1; i<=n; i++) 
			{
				Console.WriteLine (i);
			}
		}
	}
}
