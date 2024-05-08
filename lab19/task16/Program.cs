using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task16
{
	internal class Program
	{
		/// <summary>
		/// Точка входа в программу.
		/// </summary>
		public static void Main()
		{
			// Перебор всех доступных дисков на компьютере.
			foreach (DriveInfo drive in DriveInfo.GetDrives())
			{
				if (drive.IsReady)
				{
					Console.WriteLine($"Файлы на диске {drive.Name}:");
					try
					{
						// Вывод всех файлов на диске.
						foreach (string file in Directory.GetFiles(drive.Name, "*.*", SearchOption.AllDirectories))
						{
							Console.WriteLine(file);
						}
					}
					catch (UnauthorizedAccessException)
					{
						// Обработка исключения, если нет доступа к одному или нескольким каталогам на диске.
						Console.WriteLine("Нет доступа к одному или нескольким каталогам на этом диске.");
					}
				}
			}

			// Создание нового каталога.
			string directoryPath = @"C:\Example_36tp";
			Directory.CreateDirectory(directoryPath);

			// Копирование файлов из одного каталога в другой.
			string sourceDirectory = @"C:\Program Files";
			string[] sourceFiles = Directory.GetFiles(sourceDirectory).Take(3).ToArray();
			foreach (string sourceFile in sourceFiles)
			{
				string destinationFile = Path.Combine(directoryPath, Path.GetFileName(sourceFile));
				File.Copy(sourceFile, destinationFile);
			}

			// Установка атрибута "скрытый" для всех файлов в каталоге и создание ссылок на эти файлы.
			foreach (string file in Directory.GetFiles(directoryPath))
			{
				File.SetAttributes(file, FileAttributes.Hidden);

				string linkFile = Path.Combine(directoryPath, Path.GetFileNameWithoutExtension(file) + "_link" + Path.GetExtension(file));
				File.Create(linkFile).Close();
			}
			Console.ReadLine();
		}
	}
}
