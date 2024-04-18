using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	internal class Program
	{
	static double CalculateFunction(double x, double a, double b)
	{
		if (x >= 0.9)
		{
			return 1 * Math.Pow(b + x, 2);
		}
		else if (x >= 0 && x < 0.9)
		{
			return a * x + 0.1;
		}
		else
		{
			return Math.Pow(x, 2) + b;
		}
	}

	static void Main()
	{
		double a, b, h;

		Console.Write("Введите значение a: ");
		a = Convert.ToDouble(Console.ReadLine());

		Console.Write("Введите значение b: ");
		b = Convert.ToDouble(Console.ReadLine());

		Console.Write("Введите значение h: ");
		h = Convert.ToDouble(Console.ReadLine());

		int n = (int)((b - a) / h);

		Console.WriteLine("x\tf(x)");

		for (int i = 0; i <= n; i++)
		{
			double x = a + i * h;
			double y = CalculateFunction(x, a, b);
			Console.WriteLine($"{x}\t{y}");
		}

		Console.ReadLine();
	}
}
}
