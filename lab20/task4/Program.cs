using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double A = 0;
			double B = 10;
			int N = 1000; 
			double step = (B - A) / N;

			double[] results = new double[N];

			Parallel.For(0, N, i =>
			{
				double x = A + i * step;
				results[i] = x - Math.Sin(x);
			});

			for (int i = 0; i < N; i++)
			{
				Console.WriteLine($"x = {A + i * step}, f(x) = {results[i]}");
			}
			Console.ReadLine();
		}
	}
}
