using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	internal class Program
	{
		static int CalculateF(int n)
		{
			if (n < 4)
			{
				return 0;
			}
			else if (n == 4)
			{
				return 1;
			}
			else
			{
				return (n - 2) * (n - 3);
			}
		}

		static void Main()
		{
			Console.Write("Введите значение n: ");
			int n = int.Parse(Console.ReadLine());

			int result = CalculateF(n);
			Console.WriteLine($"f({n}) = {result}");
			Console.ReadLine();
		}
	}
}
