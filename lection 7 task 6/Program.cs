//Write a program that, for a given two integer numbers N and X, calculates the sum S = 1 + 1!/X + 2!/X2 + … + N!/XN
    using System;

namespace lection7task6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("enter N and X");
			int n = int.Parse(Console.ReadLine());
			int x = int.Parse(Console.ReadLine());
			double powX = 1,factN = 1, sum = 1;
			for (int i = 1; i <= n; i++)
			{
				factN *= i;
				powX *= x;
				sum += (factN / powX);
			}
			Console.WriteLine(sum);
		}
	}
}