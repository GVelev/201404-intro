//Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.
using System;

namespace program14
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter 1 for int, 2 for double or 3 for string");
			int n = int.Parse (Console.ReadLine ());
			switch(n)
			{
			case 1:
				int choice = int.Parse (Console.ReadLine());
				Console.WriteLine (choice + 1);
				break;
			case 2:
				double choice2 = double.Parse (Console.ReadLine ());
				Console.WriteLine (choice2 + 1);
				break;
			case 3:
				string choice3 = Console.ReadLine();
				Console.WriteLine (choice3 + "*");
				break;
			}
		}
	}
}
