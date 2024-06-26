﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	public delegate double CalcFigure(double r);

	internal class Program
	{
		static void Main(string[] args)
		{
			CalcFigure CF = Get_Length;
			Console.WriteLine("Длина окружности: " + CF(5));

			CF = Get_Area;
			Console.WriteLine("Площадь круга: " + CF(5));

			CF = Get_Volume;
			Console.WriteLine("Объем шара: " + CF(5));
			Console.ReadLine();
		}

		public static double Get_Length(double R)
		{
			return 2 * Math.PI * R;
		}

		public static double Get_Area(double R)
		{
			return Math.PI * Math.Pow(R, 2);
		}

		public static double Get_Volume(double R)
		{
			return 4.0 / 3.0 * Math.PI * Math.Pow(R, 3);
		}
	}
}
