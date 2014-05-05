//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum.
using System;

namespace program4
{
	class MainClass
	{
		public static void Main (string[] args)
		{ int n,i,k,sum=0;
			Console.WriteLine ("Enter number of numbers");
			n = int.Parse (Console.ReadLine());
			Console.WriteLine ("Enter {0} numbers",n);
			for(i=0;i<n;i++)
			{
				k = int.Parse(Console.ReadLine());
				sum+=k;

			}
			Console.WriteLine ("the sum is {0}",sum);

		}
	}
}
