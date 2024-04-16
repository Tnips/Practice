using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите значение x:");
			double x = double.Parse(Console.ReadLine()); 
			double y;

			if (x >= 1 && x <= 2)
			{
				y = x * x * Math.Log(x);
				Console.WriteLine($"Значение функции y при x = {x} равно {y}");
			}
			else if (x < 1)
			{
				y = 1;
				Console.WriteLine($"Значение функции y при x < 1 равно {y}");
			}
			else 
			{
				y = Math.Exp(2 * Math.PI) * Math.Cos(5 * x);
				Console.WriteLine($"Значение функции y при x > 2 равно {y}");
			}
			Console.ReadLine();
		}
	}
}
