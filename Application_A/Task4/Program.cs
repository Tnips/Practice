using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double xa = -1; 
			double ya = 3;  
			double xb = 6;  
			double yb = 2;  

			double distance = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));

			Console.WriteLine($"Расстояние между точками A и B: {distance}");
			
			Console.ReadLine();
		}
	}
}
