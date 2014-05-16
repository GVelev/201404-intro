//Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains the size of matrix N. Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file. Example:
using System;
using System.IO;

namespace textfiles_task5
{
	class MainClass


	{
		static int [,] readmatrix(string InputFile)
		{
			StreamReader inputStream = new StreamReader (InputFile);
			int size = 0;
			using (inputStream)
			{
				string line = inputStream.ReadLine();
				size = int.Parse (line);
				int[,] matrix = new int[size, size];

				for (int i = 0; i < size; i++) {
					line = inputStream.ReadLine();
					string[] element = line.Split(' ');
					for (int j = 0; j < size; j++) {
						matrix [i, j] = int.Parse (element [j]);
					}

				}return matrix;
			}

		}
		static int MaxSum(int[,] matrix)
		{
			int sum = 0,maxsum=0;
			for (int i = 0; i < matrix.GetLength(0)-1; i++) {
				for (int j = 0; j < matrix.GetLength(1)-1; j++) {
					sum = matrix [i, j] + matrix [i, j + 1] + matrix [i + 1, j] + matrix [i + 1, j + 1];
					if (sum >= maxsum) {
						maxsum = sum;
						}
				
				}
			} return maxsum;
		}
		public static void Main (string[] args)
		{
			const string InputFile = @"input.txt";
			const string OutputFile = @"output.txt";
			StreamWriter OutputStream = new StreamWriter (OutputFile);
			int[,] matrix = readmatrix (InputFile);
			int maxsum = MaxSum (matrix);
			OutputStream.WriteLine ("maximal 2x2 sum is " + maxsum);
			OutputStream.Close ();


		}
	}
}
		
