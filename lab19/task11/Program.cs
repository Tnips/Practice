using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
	internal class Program
	{
		/// <summary>
		/// Точка входа в программу.
		/// </summary>
		public static void Main()
		{
			// Создание новой директории с именем "New_folder".
			Directory.CreateDirectory("New_folder");

			// Вывод сообщения об успешном создании директории.
			System.Console.WriteLine("Папка 'New_folder' успешно создана.");
			Console.ReadLine();
		}
	}
}
