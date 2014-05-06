//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
using System;

namespace lection7task5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int Nfact=1, Kfact=1,NKfact=1,i;
			Console.WriteLine ("Enter N and K (1<K<N)");
			int n = int.Parse (Console.ReadLine ());
			int k = int.Parse (Console.ReadLine ());
			if (1 < n && n < k) 
			{
				for (i = 1; i <= n; i++) {
					Nfact *= i;
				}
				for (i = 1; i <= k; i++) {
					Kfact *= i;
				}
				for (i=1;i<=(k-n);i++){
					NKfact*=i;
				}

				Console.WriteLine ((Nfact*Kfact)/NKfact);
			}
			else
				Console.WriteLine ("error");
		}
	}
}
