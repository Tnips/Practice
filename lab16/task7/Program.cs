using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
	internal class Program
	{
		static void Main()
		{
			foreach (DriveInfo drive in DriveInfo.GetDrives())
			{
				if (drive.IsReady)
				{
					Console.WriteLine($"Файлы на диске {drive.Name}:");
					try
					{
						foreach (string file in Directory.GetFiles(drive.Name, "*.*", SearchOption.AllDirectories))
						{
							Console.WriteLine(file);
						}
					}
					catch (UnauthorizedAccessException)
					{
						Console.WriteLine("Нет доступа к одному или нескольким каталогам на этом диске.");
					}
				}
			}

			string directoryPath = @"C:\Example_36tp";
			Directory.CreateDirectory(directoryPath);

			string sourceDirectory = @"C:\Program Files"; 
			string[] sourceFiles = Directory.GetFiles(sourceDirectory).Take(3).ToArray();
			foreach (string sourceFile in sourceFiles)
			{
				string destinationFile = Path.Combine(directoryPath, Path.GetFileName(sourceFile));
				File.Copy(sourceFile, destinationFile);
			}

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
