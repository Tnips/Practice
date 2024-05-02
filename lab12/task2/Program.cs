using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Func<double, double, double> Add = (x, y) => x + y;
			Func<double, double, double> Sub = (x, y) => x - y;
			Func<double, double, double> Mul = (x, y) => x * y;
			Func<double, double, double> Div = (x, y) => y != 0 ? x / y : throw new DivideByZeroException();

			Console.WriteLine("Введите первое число:");
			double num1 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Введите второе число:");
			double num2 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Введите операцию (Add, Sub, Mul, Div):");
			string operation = Console.ReadLine();

			switch (operation)
			{
				case "Add":
					Console.WriteLine("Результат: " + Add(num1, num2));
					break;
				case "Sub":
					Console.WriteLine("Результат: " + Sub(num1, num2));
					break;
				case "Mul":
					Console.WriteLine("Результат: " + Mul(num1, num2));
					break;
				case "Div":
					try
					{
						Console.WriteLine("Результат: " + Div(num1, num2));
					}
					catch (DivideByZeroException)
					{
						Console.WriteLine("Ошибка: деление на ноль");
					}
					break;
				default:
					Console.WriteLine("Неизвестная операция");
					break;
			}
			Console.ReadLine();
		}
	}
}
