//Write a program to calculate the Nth Catalan number by given N.
using System;

namespace lection7task9
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("enter n");
			int n = int.Parse (Console.ReadLine ());
			int factN=1, fact2N=1, N=1;
			if (n >= 0) {
				for (int i = 1; i <= n; i++) {
					factN *= i;
				}
				for (int i = 1; i <= 2 * n; i++) {
					fact2N *= i;
				}
				N = factN * (n + 1);
				Console.WriteLine ("catalan number is {0}", fact2N / (N * factN));
			}
			else
				Console.WriteLine ("error");

		}
	}
}
