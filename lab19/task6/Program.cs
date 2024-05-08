using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
	/// <summary>
	/// Делегат для выполнения математических операций над фигурами.
	/// </summary>
	/// <param name="r">Радиус фигуры.</param>
	/// <returns>Результат математической операции.</returns>
	public delegate double CalcFigure(double r);

	internal class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
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

		/// <summary>
		/// Вычисляет длину окружности.
		/// </summary>
		/// <param name="R">Радиус окружности.</param>
		/// <returns>Длина окружности.</returns>
		public static double Get_Length(double R)
		{
			return 2 * Math.PI * R;
		}

		/// <summary>
		/// Вычисляет площадь круга.
		/// </summary>
		/// <param name="R">Радиус круга.</param>
		/// <returns>Площадь круга.</returns>
		public static double Get_Area(double R)
		{
			return Math.PI * Math.Pow(R, 2);
		}

		/// <summary>
		/// Вычисляет объем шара.
		/// </summary>
		/// <param name="R">Радиус шара.</param>
		/// <returns>Объем шара.</returns>
		public static double Get_Volume(double R)
		{
			return 4.0 / 3.0 * Math.PI * Math.Pow(R, 3);
		}
	}
}
