//Write a program that calculates N!/K! for given N and K (1<K<N).
using System;

namespace lection7task4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int Nfact=1, Kfact=1,i;
			Console.WriteLine ("Enter N and K (1<K<N)");
			int n = int.Parse (Console.ReadLine ());
			int k = int.Parse (Console.ReadLine ());
			if (1 < k && k < n) 
			{
				for (i = 1; i <= n; i++) {
					Nfact *= i;
				}
				for (i = 1; i <= k; i++) {
					Kfact *= i;
				}
				Console.WriteLine (Nfact/Kfact);
			}
			else
				Console.WriteLine ("error");
		}
	}
}
