using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
	//<summary>
	//Главный класс программы.
	//</summary>
	//-<remarks>
	//Этот класс содержит метод Main, который является точкой входа в программу.
	//</remarks>
	public class Program
	{
		/// <summary>
		/// Точка входа в программу.
		/// </summary>
		/// <param name="args">Массив аргументов командной строки.</param>
		public static void Main(string[] args)
		{
			/// <summary>
			/// Функция сложения двух чисел.
			/// </summary>
			Func<double, double, double> Add = (x, y) => x + y;

			/// <summary>
			/// Функция вычитания двух чисел.
			/// </summary>
			Func<double, double, double> Sub = (x, y) => x - y;

			/// <summary>
			/// Функция умножения двух чисел.
			/// </summary>
			Func<double, double, double> Mul = (x, y) => x * y;

			/// <summary>
			/// Функция деления двух чисел. В случае деления на ноль выбрасывает исключение.
			/// </summary>
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
	