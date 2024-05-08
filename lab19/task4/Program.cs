using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
	/// <summary>
	/// Класс для выполнения математических операций.
	/// </summary>
	public class MathOperations
	{
		/// <summary>
		/// Вычисляет сумму двух чисел.
		/// </summary>
		/// <param name="a">Первое слагаемое.</param>
		/// <param name="b">Второе слагаемое.</param>
		/// <returns>Сумма двух чисел.</returns>
		public int Sum(int a, int b)
		{
			return a + b;
		}

		/// <summary>
		/// Вычисляет сумму трех чисел.
		/// </summary>
		/// <param name="a">Первое слагаемое.</param>
		/// <param name="b">Второе слагаемое.</param>
		/// <param name="c">Третье слагаемое.</param>
		/// <returns>Сумма трех чисел.</returns>
		public int Sum(int a, int b, int c)
		{
			return a + b + c;
		}
	}

	/// <summary>
	/// Главный класс программы.
	/// </summary>
	internal class program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		static void Main()
		{
			MathOperations math = new MathOperations();

			Console.Write("Введите a1: ");
			int a1 = int.Parse(Console.ReadLine());

			Console.Write("Введите b1: ");
			int b1 = int.Parse(Console.ReadLine());

			Console.Write("Введите a2: ");
			int a2 = int.Parse(Console.ReadLine());

			Console.Write("Введите b2: ");
			int b2 = int.Parse(Console.ReadLine());

			Console.Write("Введите c2: ");
			int c2 = int.Parse(Console.ReadLine());

			int result = math.Sum(a1, b1) + math.Sum(a2, b2, c2);

			Console.WriteLine($"Результат: {result}");
			Console.ReadLine();
		}
	}
}
