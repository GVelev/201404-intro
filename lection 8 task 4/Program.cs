//Write a program that finds the maximal sequence of equal elements in an array.
using System;

namespace lection8task4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("enter array lenght");
			int n = int.Parse (Console.ReadLine ());
			int[] arr = new int[n];

			Console.WriteLine ("enter array");
			for (int i = 0; i < n; i++) {
				arr [i] = int.Parse (Console.ReadLine ());
			}
			int current = 1, biggest = 1,number =0;
			for (int i = 1; i < n; i++) {
				if (arr[i-1] == arr [i]) {
					current++;
					if (current >= biggest) {
						biggest = current;
						number = arr [i-1];}}
				else {

					current = 1;}
			}
			for (int i = 0; i < biggest; i++) {
				Console.Write ("{0} ", number);
			}
		}
	}
}
