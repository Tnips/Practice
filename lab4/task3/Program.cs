using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
	internal class Program
	{
		static void Main()
		{
			try
			{
				double[] numbers = { 2.0, 3.5, -1.2, 0.0, 4.7 }; 

				for (int i = 0; i < numbers.Length; i++)
				{
					double result;
					CalculatePowerA3(numbers[i], out result);
					Console.WriteLine($"Третья степень числа {numbers[i]}: {result}");
				}
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

		static void CalculatePowerA3(double A, out double B)
		{
			B = Math.Pow(A, 3);
		}
	}
}
