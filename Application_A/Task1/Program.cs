using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите число a");
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите число b");
			int b = int.Parse(Console.ReadLine());
			int sum = a + b;
			Console.WriteLine($"Сумма чисел {a} + {b} = {sum}");
			Console.ReadLine();
		}
	}
}
