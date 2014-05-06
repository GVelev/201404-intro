//Write a program that finds the maximal increasing sequence in an array.
using System;

namespace lection8task5
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
			int current = 1, biggest = 1,number = 0;
			for (int i = 1; i < n; i++) {
				if ((arr [i] - arr [i-1])== 1) {
					current++;
	
					if (current > biggest) {
						biggest = current;
						number = i-biggest;
					}
				} else {

					current = 1;
				}
			}
			for (int i = number+1; i <=number+biggest; i++) {
				Console.Write ("{0} ", arr[i]);
			}
		}

}}
