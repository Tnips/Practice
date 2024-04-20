using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
	internal class Program
	{
		static void Main()
		{
			int[] numbers = new int[100];
			Random random = new Random();
			for (int i = 0; i < 100; i++)
			{
				numbers[i] = random.Next(1, 1000);
			}

			for (int i = 99; i >= 0; i--)
			{
				Console.Write(numbers[i] + " ");
				if ((i + 1) % 6 == 0)
				{
					Console.WriteLine();
				}
			}

			Array.Sort(numbers);

			Console.Write("Введите число k: ");
			int k = int.Parse(Console.ReadLine());

			int index = Array.BinarySearch(numbers, k);
			if (index >= 0)
			{
				Console.WriteLine($"Число {k} найдено в массиве на позиции {index}.");
			}
			else
			{
				Console.WriteLine($"Число {k} не найдено в массиве.");
			}
			Console.ReadLine();
		}
	}
}
