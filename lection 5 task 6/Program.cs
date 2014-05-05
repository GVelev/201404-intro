//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).
using System;

namespace program3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int a, b, c, d;


			Console.WriteLine("enter A");
			a= int.Parse(Console.ReadLine());
			Console.WriteLine("enter B");
			b = int.Parse(Console.ReadLine());
			Console.WriteLine("enter C");
			c = int.Parse(Console.ReadLine());
			d = b * b  -4 * a * c;
			if (d>0)

			{
				Console.WriteLine("x1={0}, x2= {1}", ((-b + Math.Sqrt(d)) / (2*a)), ((-b - Math.Sqrt(d)) / (2*a)));
			}

			else if(d==0)

			{
				Console.WriteLine("x1=x2={0}", ((-b / (2*a))));
			}
			else Console.WriteLine("nrk");
		}
	}
}
