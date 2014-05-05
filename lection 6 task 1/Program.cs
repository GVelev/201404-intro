//Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one
using System;

namespace program9
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int a, b, temp;
			Console.WriteLine ("enter a and b");
			a = int.Parse (Console.ReadLine ());
			b = int.Parse (Console.ReadLine ());
			if (a > b) 
			{
				temp = b;
				b = a;
				a = temp;
			
			}
			Console.WriteLine ("{0} {1}",a,b);

		}
	}
}
