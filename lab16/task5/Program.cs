using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	internal class Program
	{
		static void Main()
		{
			Console.WriteLine("Введите количество чисел:");
			int n = int.Parse(Console.ReadLine());

			double[] numbers = new double[n];
			Console.WriteLine($"Введите {n} чисел:");
			for (int i = 0; i < n; i++)
			{
				string input = Console.ReadLine();
				if (string.IsNullOrEmpty(input))
				{
					Console.WriteLine("Введено меньше чисел, чем требуется. Пожалуйста, введите число.");
					i--; 
				}
				else
				{
					numbers[i] = double.Parse(input);
				}
			}

			Console.WriteLine("Введите число для сравнения:");
			double givenNumber = double.Parse(Console.ReadLine());

			string filePath = "path_to_your_file.txt";

			File.WriteAllLines(filePath, numbers.Select(num => num.ToString()));

			double[] fileNumbers = File.ReadAllLines(filePath).Select(line => double.Parse(line)).ToArray();

			Console.WriteLine("Числа меньше заданного:");
			foreach (var number in fileNumbers.Where(num => num < givenNumber))
			{
				Console.WriteLine(number);
			}

			Console.WriteLine("Положительные числа:");
			foreach (var number in fileNumbers.Where(num => num > 0))
			{
				Console.WriteLine(number);
			}

			double average = fileNumbers.Where((num, index) => index % 2 == 0).Average();
			Console.WriteLine($"Среднее арифметическое чисел на четных позициях: {average}");
			Console.ReadLine();
		}
	}
}
