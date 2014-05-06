//Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm
using System;

namespace lection7task8
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("enter two numbers");
			int a = int.Parse (Console.ReadLine ());
			int b = int.Parse (Console.ReadLine ());
			int temp;
			if (b > a) {
				temp = a;
				a = b;
				b = temp;			
			} else {
				do {
					temp = a % b;
					if(temp==0)
					{
						Console.WriteLine ("GCD is {0}",b);
					}
					a = b;
					b = temp;
				
				} while(b != 0);
					
			}

		}
	}
}
