using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double x = 3.5;
			double y = Math.Pow(Math.Cos(x), 2) - (Math.Sqrt(Math.Pow(x, 3)) + 1) / (Math.Sin(x) + Math.Exp(Math.Log(2 * x)));

			Console.WriteLine($"Значение функции при x = {x} равно {y}.");
			Console.ReadLine();
		}
	}
}
