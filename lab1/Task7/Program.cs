using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите натуральное число:");
			int number = int.Parse(Console.ReadLine());

			FindMinMaxDigits(number, out int minDigit, out int maxDigit);

			Console.WriteLine($"Наименьшая цифра: {minDigit}");
			Console.WriteLine($"Наибольшая цифра: {maxDigit}");

			Console.ReadLine();
		}

		static void FindMinMaxDigits(int number, out int minDigit, out int maxDigit)
		{
			minDigit = 9; 
			maxDigit = 0; 

			while (number > 0)
			{
				int digit = number % 10; 
				minDigit = Math.Min(minDigit, digit);
				maxDigit = Math.Max(maxDigit, digit);
				number /= 10; 
			}
		}
	}
}
