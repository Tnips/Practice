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
			string filePath = "path_to_your_file.txt";
			PrintFileContent(filePath);
			Console.ReadLine();
		}

		static void PrintFileContent(string filePath)
		{
			Queue<char> nonDigitQueue = new Queue<char>();
			Queue<char> digitQueue = new Queue<char>();

			using (StreamReader sr = new StreamReader(filePath))
			{
				int c;
				while ((c = sr.Read()) != -1)
				{
					char character = (char)c;
					if (Char.IsDigit(character))
					{
						digitQueue.Enqueue(character);
					}
					else
					{
						nonDigitQueue.Enqueue(character);
					}
				}
			}

			while (nonDigitQueue.Count > 0)
			{
				Console.Write(nonDigitQueue.Dequeue());
			}

			while (digitQueue.Count > 0)
			{
				Console.Write(digitQueue.Dequeue());
			}
		}
	}
}

