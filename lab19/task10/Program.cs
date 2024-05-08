using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace task10
{
	//<summary>
	// Главный класс программы.
	//</summary>
	//<remarks>
	//Этот класс содержит метод Main, который является точкой входа в программу.
	//</remarks>
	public class Program
	{
		/// <summary>
		/// Точка входа в программу.
		/// </summary>
		public static void Main()
		{
			// Чтение всех строк из файла "numbers.txt".
			var lines = File.ReadAllLines("numbers.txt");

			// Проверка на пустой файл.
			if (lines.Length == 0)
			{
				Console.WriteLine("Файл пуст.");
				Console.ReadLine();
				return;
			}

			// Проверка, содержит ли файл только числа.
			if (!lines.All(line => int.TryParse(line, out _)))
			{
				Console.WriteLine("Файл не содержит только чисел.");
				Console.ReadLine();
				return;
			}

			// Преобразование строк в числа.
			var numbers = lines.Select(int.Parse).ToList();

			// Нахождение максимального числа.
			int maxNumber = numbers.Max();

			// Подсчет количества отрицательных чисел.
			int negativeCount = numbers.Count(n => n < 0);

			// Вывод результатов.
			Console.WriteLine($"Максимальное число: {maxNumber}");
			Console.WriteLine($"Количество отрицательных чисел: {negativeCount}");
			Console.ReadLine();
		}
	}
}
