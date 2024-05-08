using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
	//<summary>
	//Главный класс программы.
	//</summary>
	//<remarks>
	//Этот класс содержит метод Main, который является точкой входа в программу.
	//</remarks>
	public class Program
	{
		/// <summary>
		/// Делегат для функций преобразования строк.
		/// </summary>
		public delegate string StringDelegate(string s);

		/// <summary>
		/// Точка входа в программу.
		/// </summary>
		/// <param name="args">Массив аргументов командной строки.</param>
		public static void Main(string[] args)
		{
			/// <summary>
			/// Преобразование строки в верхний регистр.
			/// </summary>
			StringDelegate SD = ToUpper;
			Console.WriteLine("Преобразование в верхний регистр: " + SD("Hello, World!"));

			/// <summary>
			/// Преобразование строки в нижний регистр.
			/// </summary>
			SD = ToLower;
			Console.WriteLine("Преобразование в нижний регистр: " + SD("Hello, World!"));

			/// <summary>
			/// Реверс строки.
			/// </summary>
			SD = Reverse;
			Console.WriteLine("Реверс строки: " + SD("Hello, World!"));
			Console.ReadLine();
		}

		/// <summary>
		/// Преобразует строку в верхний регистр.
		/// </summary>
		/// <param name="s">Входная строка.</param>
		/// <returns>Строка в верхнем регистре.</returns>
		public static string ToUpper(string s)
		{
			return s.ToUpper();
		}

		/// <summary>
		/// Преобразует строку в нижний регистр.
		/// </summary>
		/// <param name="s">Входная строка.</param>
		/// <returns>Строка в нижнем регистре.</returns>
		public static string ToLower(string s)
		{
			return s.ToLower();
		}

		/// <summary>
		/// Реверсирует строку.
		/// </summary>
		/// <param name="s">Входная строка.</param>
		/// <returns>Реверсированная строка.</returns>
		public static string Reverse(string s)
		{
			char[] arr = s.ToCharArray();
			Array.Reverse(arr);
			return new string(arr);
		}
	}
}
