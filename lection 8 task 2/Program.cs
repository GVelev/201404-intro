//Write a program that reads two arrays from the console and compares them element by element.
using System;

namespace lection8task2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter lenghs of first and second array");
			int n = int.Parse (Console.ReadLine ());
			int m=int.Parse(Console.ReadLine());
			int[] arr1 = new int[n];
			int[] arr2 = new int[m];
			Console.WriteLine ("enter first array");
			for (int i = 0; i < n; i++) {
				arr1 [i] = int.Parse (Console.ReadLine ());
			}
			Console.WriteLine ("enter second array");
			for (int i = 0; i < m; i++) {
				arr2 [i] = int.Parse (Console.ReadLine ());
			}
			if (n > m) {Console.WriteLine ("will compare to lenght of second array");
			}
			else {
				Console.WriteLine ("will compare to lenght of first array");
				m = n;
				}
			for (int i = 0; i < m; i++) {
			if (arr1 [i] != arr2 [i]) {
				Console.WriteLine ("elements in pos {0} are different", i);
			} else {
				Console.WriteLine ("elements in pos {0} are the same", i);
			}
			

		}
	}

}
}
