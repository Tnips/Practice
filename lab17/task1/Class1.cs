using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	public class Triangle
	{
		public double A { get; set; }
		public double B { get; set; }
		public double C { get; set; }

		public Triangle(double a, double b, double c)
		{
			if (a + b > c && a + c > b && b + c > a)
			{
				A = a;
				B = b;
				C = c;
			}
			else
			{
				throw new ArgumentException("Треугольник с такими сторонами не существует.");
			}
		}

		public double Perimeter()
		{
			return A + B + C;
		}

		public double Area()
		{
			double p = Perimeter() / 2;
			return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
		}

		public string Type()
		{
			if (A == B && B == C)
			{
				return "Равносторонний";
			}
			else if (A == B || A == C || B == C)
			{
				return "Равнобедренный";
			}
			else
			{
				return "Разносторонний";
			}
		}
	}

	public class Rectangle
	{
		public double Width { get; set; }
		public double Height { get; set; }

		public Rectangle(double width, double height)
		{
			Width = width;
			Height = height;
		}

		public double Perimeter()
		{
			return 2 * (Width + Height);
		}

		public double Area()
		{
			return Width * Height;
		}
	}
}

