//Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.
using System;

namespace lection7task2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int i;
			Console.WriteLine ("enter n");
			int n = int.Parse (Console.ReadLine ());
			for (i = 1; i <= n; i++) {
				if (i % 3 != 0 || i % 7 != 0) {
					Console.WriteLine (	i);
				}
			}
		}
	}
}
