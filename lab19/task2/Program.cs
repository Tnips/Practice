using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	/// <summary>
	/// Главный класс программы.
	/// </summary>
	internal class Program
	{
		/// <summary>
		/// Вычисляет третью степень числа.
		/// </summary>
		/// <param name="A">Входное число.</param>
		/// <param name="B">Выходное число, равное A в третьей степени.</param>
		static void PowerA3(double A, out double B)
		{
			B = Math.Pow(A, 3);
		}

		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
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
