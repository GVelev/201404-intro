//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.
using System;

namespace program10
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int a, b, c;
			Console.WriteLine ("enter a,b,c");
			a = int.Parse (Console.ReadLine ());
			b = int.Parse (Console.ReadLine ());
			c = int.Parse (Console.ReadLine ());
			if (a < 0 && b < 0 && c < 0) 
			{
				Console.WriteLine ("the sign will be -");
			} 
			else if (a < 0 && b > 0 && c > 0)
			{
				Console.WriteLine ("the sign will be -");
			}
			else if(b<0 &&a>0&&c>0)
			{
				Console.WriteLine ("the sign will be -");
			}
			else if (c<0 &&a>0&&b>0)
			         {
				Console.WriteLine ("the sign will be -");
			}

			else {
				Console.WriteLine ("the sign will be +");
			}
		}
	}
}
