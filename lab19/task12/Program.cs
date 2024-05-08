using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace task12
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
			// Чтение всех строк из файла "file.txt".
			var lines = File.ReadAllLines("file.txt");

			// Бесконечный цикл для обработки выбора пользователя.
			while (true)
			{
				Console.WriteLine("\nВыберите действие:");
				Console.WriteLine("1. Вывести содержимое файла");
				Console.WriteLine("2. Подсчитать количество строк");
				Console.WriteLine("3. Подсчитать количество символов в каждой строке");
				Console.WriteLine("4. Удалить последнюю строку и записать результат в новый файл");
				Console.WriteLine("5. Вывести строки с s1 по s2");
				Console.WriteLine("6. Найти длину самой длинной строки");
				Console.WriteLine("7. Вывести строки, начинающиеся с заданной буквы");
				Console.WriteLine("8. Переписать строки в другой файл в обратном порядке");
				Console.WriteLine("Введите 'выход' для выхода из программы");

				string choice = Console.ReadLine();

				// Выход из программы, если пользователь ввел 'выход'.
				if (choice.ToLower() == "выход")
				{
					break;
				}

				// Обработка выбора пользователя.
				switch (choice)
				{
					case "1":
						Console.WriteLine("Содержимое файла:");
						foreach (var line in lines)
						{
							Console.WriteLine(line);
						}
						break;

					case "2":
						Console.WriteLine($"Количество строк: {lines.Length}");
						break;

					case "3":
						foreach (var line in lines)
						{
							Console.WriteLine($"Количество символов в строке '{line}': {line.Length}");
						}
						break;

					case "4":
						lines = lines.Take(lines.Length - 1).ToArray();
						File.WriteAllLines("file.txt", lines);
						Console.WriteLine("Последняя строка удалена, результат записан в исходный файл 'file.txt'");
						break;

					case "5":
						Console.WriteLine("Введите начальный индекс s1:");
						int s1 = int.Parse(Console.ReadLine());
						Console.WriteLine("Введите конечный индекс s2:");
						int s2 = int.Parse(Console.ReadLine());
						Console.WriteLine($"Строки с {s1} по {s2}:");
						for (int i = s1; i <= s2; i++)
						{
							Console.WriteLine(lines[i]);
						}
						break;

					case "6":
						var longestLine = lines.OrderByDescending(line => line.Length).First();
						Console.WriteLine($"Самая длинная строка: '{longestLine}', длина: {longestLine.Length}");
						break;

					case "7":
						Console.WriteLine("Введите букву:");
						char startChar = Console.ReadLine()[0];
						Console.WriteLine($"Строки, начинающиеся с буквы '{startChar}':");
						foreach (var line in lines.Where(line => line.StartsWith(startChar.ToString())))
						{
							Console.WriteLine(line);
						}
						break;

					case "8":
						File.WriteAllLines("revers_file.txt", lines.Reverse().ToArray());
						Console.WriteLine("Строки переписаны в другой файл 'reversed_file.txt' в обратном порядке");
						break;

					case "9":
						return;

					default:
						Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
						break;
				}
			}
		}
	}
}
