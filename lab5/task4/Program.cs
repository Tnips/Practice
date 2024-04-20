using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
	internal class Program
	{
		static void Main()
		{
			const int N = 5; 
			int[,] array = new int[N, N];
			Random random = new Random();

			for (int i = 0; i < N; i++)
			{
				for (int j = 0; j < N; j++)
				{
					array[i, j] = random.Next(1, 10); 
				}
			}

			Console.WriteLine("Исходный массив:");
			for (int i = 0; i < N; i++)
			{
				for (int j = 0; j < N; j++)
				{
					Console.Write(array[i, j] + "\t");
				}
				Console.WriteLine();
			}

			int product = 1;
			for (int i = 0; i < N; i++)
			{
				product *= array[i, 1]; 
			}

			if (product >= 100 && product <= 999)
			{
				Console.WriteLine($"Произведение элементов второго столбца ({product}) является трехзначным числом.");
			}
			else
			{
				Console.WriteLine($"Произведение элементов второго столбца ({product}) не является трехзначным числом.");
			}
			Console.ReadLine();
		}
	}
}
