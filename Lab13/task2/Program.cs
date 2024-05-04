using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
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

		static void ExecuteOperation(MathOperation op, double a, double b)
		{
			try
			{
				Console.WriteLine($"Результат: {op(a, b)}");
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Введите первое число:");
				double num1 = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("Введите второе число:");
				double num2 = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("Сумма:");
				ExecuteOperation(Add, num1, num2);

				Console.WriteLine("Разность:");
				ExecuteOperation(Subtract, num1, num2);

				Console.WriteLine("Частное:");
				ExecuteOperation(Divide, num1, num2);
			}
			catch (FormatException ex)
			{
				Console.WriteLine("Введено некорректное число");
			}
			Console.ReadLine();
		}
	}
}
