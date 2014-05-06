//Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.
using System;

namespace lection8task6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter n and k");
			int n = int.Parse (Console.ReadLine ());
			int k = int.Parse (Console.ReadLine ());
			int[] arr = new int[n];
			int sum = 0;
			Console.WriteLine ("enter array");
			for (int i = 0; i < n; i++) {
				arr [i] = int.Parse (Console.ReadLine ());
			}
			Array.Sort (arr);
			for (int i = 0; i < n; i++) {
				Console.Write("{0} ",arr[i]	);
			}
			for (int i = n-1; i >= n-k; i--)
			{sum += arr [i];
		}
			Console.WriteLine (sum);
		}
	}
}
