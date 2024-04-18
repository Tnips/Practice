using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	internal class Program
	{
		static void PowerA3(double A, out double B)
		{
			B = Math.Pow(A, 3);
		}

		static void Main()
		{
			double[] numbers = { 2.5, 1.8, 3.0, 4.2, 0.9 };

			Console.WriteLine("Третьи степени чисел:");
			foreach (double num in numbers)
			{
				double result;
				PowerA3(num, out result);
				Console.WriteLine($"Число {num} в третьей степени: {result}");
			}

			Console.ReadLine();
		}
	}
}