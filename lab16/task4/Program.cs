using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
	internal class Program
	{
		static void Main()
		{
			string inputFilePath = "path_to_your_input_file.txt";
			string outputFilePath = "path_to_your_output_file.txt";

			using (StreamReader reader = new StreamReader(inputFilePath))
			using (StreamWriter writer = new StreamWriter(outputFilePath))
			{
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					string replacedLine = line.Replace('0', 'x').Replace('1', '0').Replace('x', '1');
					writer.WriteLine(replacedLine);
				}
			}

			Console.WriteLine("Файл был успешно обработан");
			Console.ReadLine();
		}
	}
}
