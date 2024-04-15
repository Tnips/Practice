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
			Console.WriteLine("Введите значение угла альфа");
			double alpha = double.Parse(Console.ReadLine());

			double z1 = Math.Sin(Math.PI / 2 + 3 * alpha) / (1 - Math.Sin(3 * alpha - Math.PI));

			double z2 = 1 / Math.Tan(5.0 / 4.0 * Math.PI + 3.0 / 2.0 * alpha);

			Console.WriteLine($"z1 = {z1}");
			Console.WriteLine($"z2 = {z2}");
			Console.ReadLine();
		}
	}
}
