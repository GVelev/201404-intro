//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;

namespace methods7
{
	class MainClass
	{
		static int[] ReadArray()
		{
			Console.WriteLine("enter number");
			string s = Console.ReadLine();
			char[] d = s.ToCharArray();
			int[] array = new int[s.Length];
			for (int i = 0; i < s.Length; i++)
			{
				array[i] = (d[i]-'0');

			}
			Array.Reverse(array);
			Console.WriteLine();
			return array;
		}
		static List<int> SumArrays(int[]arrayA,int[]arrayB)
		{
			int length=0,sum=0;
			List<int> list = new List<int> ();
			if (arrayA.Length > arrayB.Length) {
				length = arrayB.Length;
			} else
				length = arrayA.Length;

			for (int i = 0; i < length; i++) {
				sum = arrayA [i] + arrayB [i];
				if (sum > 9) {
					list.Add (1);
					list.Add (sum /= 10);
				} else
					list.Add (sum);

			}
			return list;
		}
		static void Printlist(List<int> list)
		{
			foreach (var item in list) {
				Console.Write(item);
			}
		}

		public static void Main(string[] args)
		{
			int [] numberOne =ReadArray();
			int [] numberTwo =ReadArray();
			List<int> list=SumArrays (numberOne, numberTwo);
			Printlist (list);

		}
	}
}

