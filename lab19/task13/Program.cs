using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
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
			// Путь к входному файлу.
			string inputFilePath = "path_to_your_input_file.txt";
			// Путь к выходному файлу.
			string outputFilePath = "path_to_your_output_file.txt";

			// Открытие потока чтения из входного файла и потока записи в выходной файл.
			using (StreamReader reader = new StreamReader(inputFilePath))
			using (StreamWriter writer = new StreamWriter(outputFilePath))
			{
				string line;
				// Чтение каждой строки из входного файла.
				while ((line = reader.ReadLine()) != null)
				{
					// Замена '0' на 'x', затем '1' на '0', и наконец 'x' на '1'.
					string replacedLine = line.Replace('0', 'x').Replace('1', '0').Replace('x', '1');
					// Запись обработанной строки в выходной файл.
					writer.WriteLine(replacedLine);
				}
			}

			// Вывод сообщения об успешной обработке файла.
			Console.WriteLine("Файл был успешно обработан");
			Console.ReadLine();
		}
	}
}
