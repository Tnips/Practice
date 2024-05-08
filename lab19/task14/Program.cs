using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace task14
{
	//<summary>
	//Главный класс программы.
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
			// Запрос на ввод количества чисел.
			Console.WriteLine("Введите количество чисел:");
			int n = int.Parse(Console.ReadLine());

			// Создание массива для хранения чисел.
			double[] numbers = new double[n];
			Console.WriteLine($"Введите {n} чисел:");
			for (int i = 0; i < n; i++)
			{
				string input = Console.ReadLine();
				// Проверка на пустой ввод.
				if (string.IsNullOrEmpty(input))
				{
					Console.WriteLine("Введено меньше чисел, чем требуется. Пожалуйста, введите число.");
					i--;
				}
				else
				{
					// Преобразование введенной строки в число и сохранение в массиве.
					numbers[i] = double.Parse(input);
				}
			}

			// Запрос на ввод числа для сравнения.
			Console.WriteLine("Введите число для сравнения:");
			double givenNumber = double.Parse(Console.ReadLine());

			// Путь к файлу для записи чисел.
			string filePath = "path_to_your_file.txt";

			// Запись чисел в файл.
			File.WriteAllLines(filePath, numbers.Select(num => num.ToString()));

			// Чтение чисел из файла.
			double[] fileNumbers = File.ReadAllLines(filePath).Select(line => double.Parse(line)).ToArray();

			// Вывод чисел, меньших заданного.
			Console.WriteLine("Числа меньше заданного:");
			foreach (var number in fileNumbers.Where(num => num < givenNumber))
			{
				Console.WriteLine(number);
			}

			// Вывод положительных чисел.
			Console.WriteLine("Положительные числа:");
			foreach (var number in fileNumbers.Where(num => num > 0))
			{
				Console.WriteLine(number);
			}

			// Вычисление среднего арифметического чисел на четных позициях.
			double average = fileNumbers.Where((num, index) => index % 2 == 0).Average();
			Console.WriteLine($"Среднее арифметическое чисел на четных позициях: {average}");
			Console.ReadLine();
		}
	}
}
