using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random rand = new Random();
			int[,] matrix = new int[3, 4];
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] = rand.Next(1, 100); 
				}
			}

			Console.WriteLine("Исходная матрица:");
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write(matrix[i, j] + " ");
				}
				Console.WriteLine();
			}

			Console.WriteLine("\nНаименьший элемент в каждой строке:");
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				int min = matrix[i, 0];
				for (int j = 1; j < matrix.GetLength(1); j++)
				{
					if (matrix[i, j] < min)
					{
						min = matrix[i, j];
					}
				}
				Console.WriteLine("Строка " + (i + 1) + ": " + min);
				Console.ReadLine();
			}
		}
	}
}
