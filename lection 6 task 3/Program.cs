//Write a program that finds the biggest of three integers using nested if statements.
using System;

namespace program11
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
			if (a > b)
			{

				if (b > c)
				{
					Console.WriteLine("the biggest is {0}",a);
				}
				else 
				{
					if (a > c)
					{
						Console.WriteLine("the biggest is {0}",a);
					}
					else 
					{
						Console.WriteLine("the biggest is {0}",c);
					}
				}
			}
			else 
			{
				if (b < c)
				{
					Console.WriteLine("the biggest is {0}",c);
				}
				else
				{
					Console.WriteLine("the biggest is {0}",b);
				}
			}


				

		}
	}
}
