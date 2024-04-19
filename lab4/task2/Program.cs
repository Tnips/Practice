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
			try
			{
				double x = 2.0; 
				double result = CalculateFunctionValue(x);

				Console.WriteLine($"Значение функции f при x = {x}: {result}");
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

		static double CalculateFunctionValue(double x)
		{
			if (x > 3)
			{
				return x;
			}
			else if (x > -1)
			{
				return 2 * x;
			}
			else if (x != 0) 
			{
				return -2 / x;
			}
			else
			{
				throw new Exception("Значение x не входит в допустимый диапазон.");
			}
		}
	}
}

