using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите текстовый фрагмент: ");
			string input = Console.ReadLine();

			int maxConsecutiveDigits = FindMaxConsecutiveDigits(input);
			Console.WriteLine($"Наибольшее количество цифр, идущих подряд: {maxConsecutiveDigits}");
			Console.ReadLine();
		}

		static int FindMaxConsecutiveDigits(string text)
		{
			int currentConsecutiveDigits = 0;
			int maxConsecutiveDigits = 0;

			foreach (char c in text)
			{
				if (char.IsDigit(c))
				{
					currentConsecutiveDigits++;
					maxConsecutiveDigits = Math.Max(maxConsecutiveDigits, currentConsecutiveDigits);
				}
				else
				{
					currentConsecutiveDigits = 0;
				}
			}

			return maxConsecutiveDigits;
		}
	}
}
