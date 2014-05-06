//Write a program that compares two char arrays lexicographically
using System;

namespace lection8task3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("enter lengths of fisr and second array");
			int n = int.Parse (Console.ReadLine ());
			int m = int.Parse (Console.ReadLine ());
			char[] arr1 = new char[n];
			char[] arr2 = new char[m];
			Console.WriteLine ("enter first array");
			for (int i = 0; i < n; i++) {
				arr1 [i] = char.Parse (Console.ReadLine ());
			}
			Console.WriteLine ("enter second array");
			for (int i = 0; i < m; i++) {
				arr2 [i] = char.Parse (Console.ReadLine ());
			}

			if (m>n) {
				m = n;
				}
			for (int i = 0; i < m; i++) 
			{
				if (arr1 [i] < arr2 [i]) {
					Console.WriteLine ("the first array is before the second");
					break;
				} else if (arr1 [i] > arr2 [i]) {
					Console.WriteLine ("the second array is before the first");
					break;
				}
			}
		}
	}
}