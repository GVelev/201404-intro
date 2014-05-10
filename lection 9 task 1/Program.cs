//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
using System;

namespace lection9task1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("enter size of matrix");
			int row = int.Parse (Console.ReadLine ());
			int col = int.Parse (Console.ReadLine ());
			int[,] matrix = new int[row,col];
			int sum = 0,currentsum=0;
			for (int i = 0; i < row; i++) {
				string[] numbers = Console.ReadLine ().Split (' ');
				for (int j = 0; j < col; j++) {
					matrix [i, j] = int.Parse(numbers [j]);
				}
				
			}
			if (row >= 3 && col >= 3) {
				for (int i = 0; i < row-2; i++) {
					for (int j = 0; j < col - 2; j++) {
						currentsum += matrix [i, j] + matrix [i, j + 1] + matrix [i, j + 2] + 
						              matrix [i + 1, j] + matrix [i + 2, j] + matrix [i + 1, j + 1] + 
						              matrix [i + 2, j + 2]+ matrix[i+1,j+2]+matrix[i+2,j+1];

						if (currentsum >= sum) {
							sum = currentsum;

						}
						currentsum = 0;

					}
					}
				}
			 else {
				Console.WriteLine (	"error");}

			Console.WriteLine ("the max sum is:" +sum);


		}
	}
}
/*
6
5
1 2 3 100 7
50 5 6 7 8
3 5 6 7 8 
3 5 6 7 700
1 2 3 4 5 
1 2 3 4 5 
*/