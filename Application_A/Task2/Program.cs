using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	internal class Program
	{
		tatic void Main(string[] args)
		{
			Console.Write("Введите четырехзначное число: ");
			int number = int.Parse(Console.ReadLine());

			if (number >= 1000 && number <= 9999)
			{
				int digit1 = number / 1000;
				int digit2 = (number / 100) % 10;
				int digit3 = (number / 10) % 10;
				int digit4 = number % 10;

				int sum = digit1 + digit2 + digit3 + digit4;

				Console.WriteLine($"Сумма цифр числа {number} равна {sum}.");
			}
			else
			{
				Console.WriteLine("Введенное число не является четырехзначным.");
			}
			Console.ReadLine();
		}
	}
}
