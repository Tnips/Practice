using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
	internal class Program
	{
		static void Main()
		{
			Console.WriteLine("Введите предложение:");
			string sentence = Console.ReadLine();

			string sentenceWithoutDigits = new string(sentence.Where(c => !char.IsDigit(c)).ToArray());

			string filePath = "path_to_your_file.txt";

			File.WriteAllText(filePath, sentenceWithoutDigits);

			string fileContent = File.ReadAllText(filePath);
			Console.WriteLine("Содержимое файла:");
			Console.WriteLine(fileContent);
			Console.ReadLine();
		}
	}
}
