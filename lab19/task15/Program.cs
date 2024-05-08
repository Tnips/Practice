using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace task15
{
	//<summary>
	//Главный класс программы.
	//<summary>
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
			// Запрос на ввод предложения.
			Console.WriteLine("Введите предложение:");
			string sentence = Console.ReadLine();

			// Удаление всех цифр из предложения.
			string sentenceWithoutDigits = new string(sentence.Where(c => !char.IsDigit(c)).ToArray());

			// Путь к файлу для записи предложения без цифр.
			string filePath = "path_to_your_file.txt";

			// Запись предложения без цифр в файл.
			File.WriteAllText(filePath, sentenceWithoutDigits);

			// Чтение содержимого файла.
			string fileContent = File.ReadAllText(filePath);
			Console.WriteLine("Содержимое файла:");
			Console.WriteLine(fileContent);
			Console.ReadLine();
		}
	}
}
