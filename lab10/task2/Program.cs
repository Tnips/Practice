using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	public class A
	{
		protected double a = 5;
		protected double b = 10;
		public double c
		{
			get
			{
				return a + b;
			}
		}
	}
	public class B : A
	{
		private double d = 15;
		public double c2
		{
			get
			{
				if (d > 10)
				{
					return a + b + d;
				}
				else
				{
					return a + b;
				}
			}
		}
		public B() : base()
		{
		}
		public B(double a, double b, double d)
		{
			this.a = a;
			this.b = b;
			this.d = d;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			A a = new A();
			Console.WriteLine($"Значение свойства c класса A: {a.c}");
			B b1 = new B();
			Console.WriteLine($"Значение свойства c2 класса B (с использованием конструктора, наследуемого от класса A): {b1.c2}");
			B b2 = new B(7, 8, 9);
			Console.WriteLine($"Значение свойства c2 класса B (с использованием собственного конструктора): {b2.c2}");
			Console.ReadLine();
		}
	}
}
