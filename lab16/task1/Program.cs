using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	internal class Program
	{

		static void Main()
		{
			var lines = File.ReadAllLines("numbers.txt");

			if (lines.Length == 0)
			{
				Console.WriteLine("Файл пуст.");
				Console.ReadLine();
				return;
			}

			if (!lines.All(line => int.TryParse(line, out _)))
			{
				Console.WriteLine("Файл не содержит только чисел.");
				Console.ReadLine();
				return;

			}

			var numbers = lines.Select(int.Parse).ToList();

			int maxNumber = numbers.Max();

			int negativeCount = numbers.Count(n => n < 0);

			Console.WriteLine($"Максимальное число: {maxNumber}");
			Console.WriteLine($"Количество отрицательных чисел: {negativeCount}");
			Console.ReadLine();
		}
	}
}
