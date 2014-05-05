//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive)
using System;

namespace program2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int a, b,c=0,d;
			Console.WriteLine("Enter lowest number:");
			d = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter highest number:");
			b = int.Parse(Console.ReadLine());
			for (a=d; a <= b; a++)
			{
				if ((a % 5) == 0)
					c++;
			}
			Console.WriteLine("the number of integers is: {0}", c);
		}
	}
}
