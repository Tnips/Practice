using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	internal class Program
	{
		static void Main()
		{
			Console.Write("Введите размер матрицы N (N < 10): ");
			int N = int.Parse(Console.ReadLine());

			Console.Write("Введите нижнюю границу диапазона (a): ");
			int a = int.Parse(Console.ReadLine());

			Console.Write("Введите верхнюю границу диапазона (b): ");
			int b = int.Parse(Console.ReadLine());

			int[,] matrix = new int[N, N];
			Random random = new Random();

			for (int i = 0; i < N; i++)
			{
				for (int j = 0; j < N; j++)
				{
					matrix[i, j] = random.Next(a, b + 1);
				}
			}

			Console.WriteLine("Исходная матрица:");
			for (int i = 0; i < N; i++)
			{
				for (int j = 0; j < N; j++)
				{
					Console.Write(matrix[i, j] + "\t");
				}
				Console.WriteLine();
			}

			int positiveCount = 0;
			for (int i = 0; i < N; i++)
			{
				int rowSum = 0;
				for (int j = 0; j < N; j++)
				{
					if (matrix[i, j] > 0)
					{
						positiveCount++;
					}
					rowSum += matrix[i, j];
				}
				Console.WriteLine($"Сумма элементов в строке {i + 1}: {rowSum}");
			}

			Console.WriteLine($"Количество положительных чисел: {positiveCount}");
			Console.ReadLine();
		}
	}
}
