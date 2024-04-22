using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите предложение: ");
			string sentence = Console.ReadLine();

			string[] words = sentence.Split(' ');
			if (words.Length >= 2)
			{
				string firstWord = words[0];
				words[0] = words[words.Length - 1];
				words[words.Length - 1] = firstWord;
			}
			Console.WriteLine($"Поменяли местами первое и последнее слова: {string.Join(" ", words)}");

			if (words.Length >= 3)
			{
				words[1] = string.Concat(words[1], words[2]);
			}
			Console.WriteLine($"Склеили второе и третье слова: {string.Join(" ", words)}");

			if (words.Length >= 3)
			{
				string reversedThirdWord = new string(words[2].ToCharArray().Reverse().ToArray());
				Console.WriteLine($"Третье слово в обратном порядке: {reversedThirdWord}");
			}

			Console.ReadLine();
		}
	}
}



