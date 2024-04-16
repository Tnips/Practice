using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double A = 0; 
			double B = Math.PI / 2; 
			int M = 10;
			double H = (B - A) / M; 

			Console.WriteLine("Значения функции x - sin(x) на отрезке [0; π/2]:");
			TabulateFunction(A, B, H);

			Console.ReadLine();
		}

		static void TabulateFunction(double A, double B, double H)
		{
			for (double x = A; x <= B; x += H)
			{
				double result = x - Math.Sin(x);
				Console.WriteLine($"x = {x}, F(x) = {result}");
			}
		}
	}
}
