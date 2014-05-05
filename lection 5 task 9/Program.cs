
using System;

namespace program6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] c = new int[100];
			int n;
			c [0] = 0;
			c [1] = 1;
			for(n=2;n<100;n++)
			{
				c[n]=c[n-1]+c[n-2];
				Console.WriteLine (c[n]);
			}



		}
	}
}
