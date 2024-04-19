using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	internal class Program
	{
		static void Main()
		{
			try
			{
				double x = 2.0;
				double resultA = CalculateExpressionA(x);
				double resultB = CalculateExpressionB(x);

				Console.WriteLine($"Значение выражения a при x = {x}: {resultA}");
				Console.WriteLine($"Значение выражения b при x = {x}: {resultB}");
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Ошибка: Деление на ноль.");
			}
			catch (FormatException)
			{
				Console.WriteLine("Ошибка: Неверный формат числа.");
			}
			Console.ReadLine();
		}

		static double CalculateExpressionA(double x)
		{
			return Math.Cos(Math.Pow(x, 2)) / (9 * x - 9) + Math.Pow(Math.Sin(x), 3);
		}

		static double CalculateExpressionB(double x)
		{
			return Math.Pow(Math.Sin(x), 3) / Math.Pow(x, 3);
		}
	}
}
