using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	internal class Program
	{
		static void Main()
		{

			Directory.CreateDirectory("New_folder");

			System.Console.WriteLine("Папка 'New_folder' успешно создана.");
			Console.ReadLine();
		}
	}
}
