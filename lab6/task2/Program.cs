using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите предложение: ");
			string sentence = Console.ReadLine();
			int index = sentence.IndexOf(',');
			if (index != -1)
			{
				string textBeforeComma = sentence.Substring(0, index);
				int countOfA = CountOccurrences(textBeforeComma, 'а');
				Console.WriteLine($"Количество букв 'а' перед первой запятой: {countOfA}");
			}
			else
			{
				Console.WriteLine("В предложении нет запятых.");
			}
			Console.ReadLine();
		}

		static int CountOccurrences(string text, char target)
		{
			int count = 0;
			foreach (char c in text)
			{
				if (c == target)
				{
					count++;
				}
			}
			return count;
		}
	}
}
