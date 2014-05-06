//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.
using System;

namespace lection7task3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int i;
			Console.WriteLine ("enter number of integers");
			int n = int.Parse (Console.ReadLine ());
			int[] arr = new int[n];
			for (i = 0; i < n; i++) {
				arr [i] = int.Parse (Console.ReadLine ());
			}
			Array.Sort (arr);
			Console.WriteLine ("min e {0}, max e {1}",arr[0],arr[n-1]);
		}
	}
}
