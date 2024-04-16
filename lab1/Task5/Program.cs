using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите целое число N (1 <= N <= 10):");
			int N = int.Parse(Console.ReadLine());

			double sum = CalculateSum(N);
			Console.WriteLine($"Сумма: {sum}");

			Console.ReadLine();
		}

		static double CalculateSum(int N)
		{
			double sum = 0;
			for (int i = 0; i <= N; i++)
			{
				double term = Math.Pow(N + i, 2);
				sum += term;
			}
			return sum;
		}
	}
}
