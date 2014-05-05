//Write a program that applies bonus scores to given scores in the range [1..9]. The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000. If it is zero or if the value is not a digit, the program must report an error.
using System;

namespace program15
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n;
			Console.WriteLine ("enter digit between 1 and 9");
			if (int.TryParse (Console.ReadLine (), out n))
				switch (n) {case 1:
				case 2:
				case 3:
					Console.WriteLine (n * 10);
					break;
				case 4:
				case 5:
				case 6:
					Console.WriteLine (n * 100);
					break;
				case 7:
				case 8:
				case 9 :	Console.WriteLine (n*1000);
				break;
				default:
					Console.WriteLine ("error");
					break;


				}

			else
				Console.WriteLine ("not a number");
		}
	}
}
