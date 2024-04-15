using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double radius = 9;

			double areaCircle = Math.PI * Math.Pow(radius, 2);

			Console.WriteLine($"Площадь круга с радиусом {radius} см: {areaCircle} кв.см.");
			Console.ReadLine();
		}
	}
}
