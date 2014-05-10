//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 
using System;

namespace lection9task4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("enter array limit and number k");
			int n = int.Parse (Console.ReadLine ());
			int k = int.Parse (Console.ReadLine ());
			int[] array = new int[n];
			int result = 0;
			Console.WriteLine ("enter array of "+ n +" elements");
			string[] numbers = Console.ReadLine ().Split(' ');
			for (int i = 0; i < n; i++) {
				array [i] = int.Parse (numbers[i]);

			}
			Array.Sort (array);
			if (array [0] > k) {
				Console.WriteLine ("no number is less then k");
			} else {
				int index = Array.BinarySearch (array, k);
				if (index >= 0) {
					result = array [index];
				} else {
					result = array [~index - 1];
				}
				Console.WriteLine(result);
			}
		}
	}
}
/*
8
6
1 3 4 2 7 8 9 5
*/
