using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	public class Matrix
	{
		private int[,] data; 

		public Matrix(int rows, int columns)
		{
			data = new int[rows, columns];
		}

		public int this[int row, int column]
		{
			get => data[row, column];
			set => data[row, column] = value;
		}

		public void Print()
		{
			for (int i = 0; i < data.GetLength(0); i++)
			{
				for (int j = 0; j < data.GetLength(1); j++)
				{
					Console.Write($"{data[i, j]} ");
				}
				Console.WriteLine();
			}
		}

		public void PrintSubmatrix(int startRow, int startColumn, int numRows, int numColumns)
		{
			for (int i = startRow; i < startRow + numRows; i++)
			{
				for (int j = startColumn; j < startColumn + numColumns; j++)
				{
					Console.Write($"{data[i, j]} ");
				}
				Console.WriteLine();
			}
		}
	}

	internal class program
	{
		static void Main()
		{
			var matrix = new Matrix(3, 3);
			matrix[0, 0] = 1;
			matrix[0, 1] = 2;
			matrix[0, 2] = 3;
			matrix[1, 0] = 4;
			matrix[1, 1] = 5;
			matrix[1, 2] = 6;
			matrix[2, 0] = 7;
			matrix[2, 1] = 8;
			matrix[2, 2] = 9;

			Console.WriteLine("Вся матрица:");
			matrix.Print();

			Console.WriteLine("\nПодматрица 2x2:");
			matrix.PrintSubmatrix(1, 0, 2, 2);
			Console.ReadLine();
		}
	}
}
