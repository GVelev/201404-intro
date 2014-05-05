//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
using System;

namespace program7
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			double i,sum =1;
			Console.WriteLine ("enter limit");
			int n = int.Parse (Console.ReadLine ());
			for (i = 2; i <=n; i++) {
				if ((i % 2) == 0) {
					sum += Math.Round (1 / i, 3);
				} else {
					sum -= Math.Round (1 / i, 3);
				}
			}
			Console.WriteLine (sum);
		}
	}
}
