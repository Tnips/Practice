using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{

	class A
	{
		private int a;
		private int b;

		public A(int aValue, int bValue)
		{
			a = aValue;
			b = bValue;
		}

		public int Sum()
		{
			return a + b;
		}

		public double SinExpression()
		{
			double mult = 3.0 * a;
			double result = Math.Sin(b / mult);
			return result;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			A myObject = new A(5, 10);

			Console.WriteLine($"Сумма a и b: {myObject.Sum()}");
			Console.WriteLine($"Значение выражения sinb / 3a: {myObject.SinExpression()}");
			Console.ReadLine();
		}
	}

}
