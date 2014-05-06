//Write a program that finds the most frequent number in an array.
using System;

namespace lection8task7
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("enter n");
			int n=int.Parse(Console.ReadLine());
			int[] arr = new int[n];
			Console.WriteLine ("enter array");
			for (int i = 0; i < n; i++) {
				arr [i] = int.Parse (Console.ReadLine ());
			}
			int number = 0, count = 1,bestcount = 1;
			Array.Sort (arr);
			for (int i = 1; i < n; i++) {
				if (arr [i - 1] == arr [i])
				{count++;
			
					if (count > bestcount) {
						bestcount = count;
						number = arr [i];
					} else
						count = 1;
				}

				}
			Console.WriteLine ("most common number is {0}, seen {1} times",number,bestcount);
	}
	}}
