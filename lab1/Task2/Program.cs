using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите первое вещественное число:");
			double firstnumber = double.Parse(Console.ReadLine());

			Console.WriteLine("Введите второе вещественное число:");
			double secondnumber = double.Parse(Console.ReadLine());

			double maxValue = Math.Max(firstnumber, secondnumber);

			Console.WriteLine($"Максимальное значение: {maxValue}");

			Console.ReadLine();
		}
	}
}
