using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	internal class Program
	{
		public delegate double MathOperation(double a, double b);

		static double Add(double a, double b)
		{
			return a + b;
		}

		static double Subtract(double a, double b)
		{
			return a - b;
		}

		static double Divide(double a, double b)
		{
			if (b == 0)
			{
				throw new DivideByZeroException("Деление на ноль недопустимо");
			}
			return a / b;
		}

		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Введите первое число:");
				double num1 = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("Введите второе число:");
				double num2 = Convert.ToDouble(Console.ReadLine());

				MathOperation op = Add;
				Console.WriteLine($"Сумма: {op(num1, num2)}");

				op = Subtract;
				Console.WriteLine($"Разность: {op(num1, num2)}");

				op = Divide;
				Console.WriteLine($"Частное: {op(num1, num2)}");
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine(ex.Message);
			}
			catch (FormatException ex)
			{
				Console.WriteLine("Введено некорректное число");
			}
			Console.ReadLine();
		}
	}
}
