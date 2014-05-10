//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix
using System;

namespace lection9task3
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("enter matrix size");
			int row = int.Parse(Console.ReadLine());
			int col = int.Parse(Console.ReadLine());
			string[,] matrix = new string[row, col];
			int hor = 1, vert = 1, diagl = 1, diagr = 1, hormax = 1, vertmax = 1, diaglmax = 1, diagrmax = 1;
			string seq1 = " ", seq2 = " ", seq3 = " ", seq4 = " ";
			for (int i = 0; i < row; i++)
			{
				string[] words = Console.ReadLine().Split(' ');
				for (int j = 0; j < col; j++)
				{
					matrix[i, j] = words[j];
				}
			}
			for (int i = 0; i < matrix.GetLength(0) - 1; i++)
			{
				for (int j = 0; j < matrix.GetLength(1) - 1; j++)
				{
					if (matrix[i, j] == matrix[i, j + 1])
					{
						hor++;
						if (hor >= hormax)
						{
							hormax = hor;
							seq1 = matrix[i, j];
							Console.WriteLine("seq 1 " + seq1);

						}
					}
					else hor = 0;

				}
			}
			for (int j = 0; j < matrix.GetLength(1) - 1; j++)
			{
				for (int i = 0; i < matrix.GetLength(0) - 1; i++)
				{
					if (matrix[i, j] == matrix[i + 1, j])
					{
						vert++;
						if (vert >= vertmax)
						{
							vertmax = vert;
							seq2 = matrix[i, j];
							Console.WriteLine("seq 2 " + seq2);
						}

					}
					else vert = 0;

				}
			}
			if (row > col)
			{
				row = col;
			}
			else
			{
				for (int i = 0; i < row - 1; i++)
				{
					if (matrix[i, i] == matrix[i + 1, i + 1])
					{
						diagl++;
						if (diagl >= diaglmax)
						{
							diaglmax = diagl;
							seq3 = matrix[i, i];
							Console.WriteLine("seq 3 " + seq3);
						}

					}
					else diagl = 1;
				}
				for (int i = 0; i < row - 1; i++)
				{
					if (matrix[i, row - i - 1] == matrix[i + 1, row - i - 2])
					{
						diagr++;
						if (diagr >= diagrmax)
						{
							diagrmax = diagr;
							seq4 = matrix[i, row - i - 1];
							Console.WriteLine("seq 4 " + seq4);
						}

					}
					else diagr = 1;
				}

				if (hormax > vertmax && hormax > diaglmax && hormax > diagrmax)
				{
					for (int i = 0; i <= hormax; i++)
					{
						Console.Write(seq1 + " ");
					}
					Console.WriteLine();
				}
				else if (vertmax > hormax && vertmax > diaglmax && vertmax > diagrmax)
				{
					for (int i = 0; i <= vertmax; i++)
					{
						Console.Write(seq2 + " ");
					}
					Console.WriteLine();
				}
				else if (diaglmax > hormax && diaglmax > vertmax && diaglmax > diagrmax)
				{
					for (int i = 0; i <= diaglmax; i++)
					{
						Console.Write(seq3 + " ");
					}
					Console.WriteLine();
				}
				else if (diagrmax > hormax && diagrmax > vertmax && diagrmax > diaglmax)
				{
					for (int i = 0; i <= diagrmax; i++)
					{
						Console.Write(seq4 + " ");
					}
					Console.WriteLine();
				}
			}

		}
	}

}
/* 
4
5
ha ga ma da du 
ma ku ma ku ku
ba ga ma ha bu 
ba da ma ha hy
*/