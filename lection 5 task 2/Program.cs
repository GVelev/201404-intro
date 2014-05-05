//Write a program that reads the radius r of a circle and prints its perimeter and area.
using System;

namespace program1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int radius;
			Console.WriteLine("Enter raduis:");
			radius=int.Parse(Console.ReadLine());
			Console.WriteLine ("perimeter: {0}, area: {1}", 3.14 * 2 * radius, radius * radius * 3.14);
		}
	}
}
