using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = 42;
			int firstDigit = number / 10;
			int lastDigit = number % 10;
			Console.WriteLine($"Первая цифра числа {number} - это {firstDigit}");
			Console.WriteLine($"Последняя цифра числа {number} - это {lastDigit}");
			Console.ReadLine();
		}
	}
}
